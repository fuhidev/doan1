using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using ExamSchedule.Algorithm;
using ExamSchedule.Algorithm.Model;
using ExamSchedule.Model;

namespace ExamSchedule.Algorithm
{
    internal class AssignColor : IAssignColor
    {
        private List<Color> Colors = new List<Color>();
        private int maxScheduleDay = 2;
        private int nearestExam = 0;
        private int noOfColorCouses;
        private int noOfTimeSlot = 8;

        public List<Room> ListRoom { get; set; }

        public List<Node> ListNode { get; set; }

        private IndependentSet _independentSet;

        private readonly HashSet<int> tmpInt = new HashSet<int>();

        public AssignColor(List<Room> listRoom=null, List<Node> listNode=null)
        {
            ListRoom = listRoom;
            ListNode = listNode;
        }

        public int NumDay
        {
            get { return tmpInt.Count; }
        }

        public IEnumerable<Node> GetCourseHaveSchedule()
        {
            if (ListNode == null || ListNode.Count == 0)
                throw new NullReferenceException("ListNode is null. GetCourseHaveSchedule");
            return from n in ListNode
                   where n.Color != null
                   select n;
        }

        public void Assign()
        {
            ListNode.Sort();

            var noOfCourses = ListNode.Count;
            var first = true;

            _independentSet = new IndependentSet(ListNode);

            Console.WriteLine("Run..");
            InitColor();
            foreach (var node in ListNode)
            {
                if (node.ListFamily == null)
                    throw new NullReferenceException("Không đủ dữ liệu để thực hiện " + node.ID);
                Color color = null;
                if (node.Color == null)
                {
                    if (first)
                    {
                        first = false;
                        color = FirstNodeColor(node);
                        if (color == null) return;
                    }
                    else
                        color = SmallestAvailableColor(node);
                    if (color != null)
                    {
                        var independent = _independentSet.Run(node);
                        //to mau cho nut dang xet
                        AssignColorForNode(node, color);
                        independent.ForEach(f =>
                        {
                            int day = 1,
                                exam = 1;
                            while (true)
                            {
                                var newColor = FindColor(day, exam);
                                if (AvailableColorForNode(newColor, node) && newColor.CheckAbilityRooms(f.ListFamily))
                                {
                                    AssignColorForNode(f, newColor);
                                    break;
                                }
                                else
                                {
                                    exam++;
                                    if (exam > noOfTimeSlot)
                                    {
                                        day++;
                                        exam = 1;
                                    }
                                    if (day > maxScheduleDay)
                                    {
                                        maxScheduleDay++;
                                        InitColor(maxScheduleDay);
                                    }
                                }
                            }
                        });
                    }
                }
            }
        }
        private void InitColor(int day = 1)
        {
            //tạo danh sách Concurency Limit
            ////danh sách được tạo từ phần tử Size của Database.Rooms
            if (ListRoom == null || ListRoom.Count == 0) return;

            for (var i = day; i <= maxScheduleDay; i++)
            {
                for (var j = 1; j <= noOfTimeSlot; j++)
                {
                    if (FindColor(i, j) != null)
                        continue;
                    var CLs = new List<Color.ColorRoomCourse>();
                    ListRoom.ForEach(a => CLs.Add(new Color.ColorRoomCourse
                    {
                        Room = a,
                        Course = null
                    }));
                    var color = new Color
                    {
                        Day = i,
                        Exam = j,
                        CLs = CLs
                    };
                    Colors.Add(color);
                }
            }
        }

        private Color FindColor(int day, int exam)
        {
            return Colors.FirstOrDefault(a => a.Day == day && a.Exam == exam);
        }

        private void AssignColorForNode(Node node, Color color)
        {
            node.Color = color;
            noOfColorCouses++;
            color.ListNode.Add(node);
            //tìm danh sách phòng để cập nhật cho node, cái này chắc chắn được tại vì là đã kiểm tra khi tìm Color cho node, thỏa đủ điều kiện rồi thì mới đến được bước này
            color.AddCoursesOnRooms(node.ListFamily);
            tmpInt.Add(color.Day);
        }

        public Color FirstNodeColor(Node node)
        {
            for (var i = 1; i <= maxScheduleDay; i++)
            {
                for (var j = 1; j <= noOfTimeSlot; j++)
                {
                    var color = FindColor(i, j);
                    var check = color.CheckAbilityRooms(node.ListFamily);
                    if (check)
                        return color;
                }
            }
            return null;
        }

        #region SmallestAvailableColor

        private int InternalDistance(Color c1, Color c2)
        {
            return Math.Abs(c1.Exam - c2.Exam);
        }

        private int ExternalDistance(Color c1, Color c2)
        {
            return Math.Abs(c1.Day - c2.Day);
        }
        public bool AvailableColorForNode(Color color, Node node)
        {
            var valid = true;
            foreach (var n in node.GetNeighBorNodes())
            {
                //lấy màu của node kế cận với node
                var color_N = n.Color;
                //nếu node đã được gán màu
                if (color_N != null)
                {
                    //if (Color.Day.Day != i || Color.Exam != j)
                    //kiểm tra có trùng với ngày hoặc trùng với ca thi hay không
                    if (color_N.Day != color.Day || color_N.Exam != color.Exam)
                    {
                        //nếu có thì kiểm tra 2 ngày thi có trùng sau không
                        if (ExternalDistance(color_N, color) == 0 && InternalDistance(color_N, color) == 0)
                        {
                            valid = false;
                            break;
                        }
                    }
                    //nếu node kế cận chưa được gán màu thì không cần so sánh làm gì
                    else
                    {
                        valid = false;
                        break;
                    }
                }
            }
            return valid;
        }

        public Color SmallestAvailableColor(Node node, int day = 1)
        {
            var lA = node.GetNeighBorNodes(); //lấy danh sách các node kế cận với node

            for (var i = day; i <= maxScheduleDay; i++)
            {
                for (var j = 1; j <= noOfTimeSlot; j++)
                {
                    var valid = true;
                    //lấy màu của ngày thứ i ca thứ j
                    var color = FindColor(i, j);
                    //kiểm tra sức chứa của màu có đáp ứng được node
                    var sumSize = node.SumSize;
                    if (color.GetCL(node.ListFamily.First().Type) >= sumSize)
                    {
                        //kiểm tra sức chứa của màu có đáp ứng được Family của Node
                        var check = color.CheckAbilityRooms(node.ListFamily);
                        if (check)
                        {
                            //Kiểm tra Color có trùng với những màu kế cận với node (kế cận thì không được trùng màu)
                            foreach (var n in lA)
                            {
                                //lấy màu của node kế cận với node
                                var color_N = n.Color;
                                //nếu node đã được gán màu
                                if (color_N != null)
                                {
                                    //if (Color.Day.Day != i || Color.Exam != j)
                                    //kiểm tra có trùng với ngày hoặc trùng với ca thi hay không
                                    if (color_N.Day != color.Day || color_N.Exam != color.Exam)
                                    {
                                        //nếu có thì kiểm tra 2 ngày thi có trùng sau không
                                        if (ExternalDistance(color_N, color) == 0)
                                        {
                                            //nếu trùng thì kiểm tra xem 2 ca thi có trùng hoặc liền kề nhau hay không
                                            if (InternalDistance(color_N, color) <= nearestExam)
                                            {
                                                valid = false;
                                                break;
                                            }
                                        }
                                    }
                                    //nếu node kế cận chưa được gán màu thì không cần so sánh làm gì
                                    else
                                    {
                                        valid = false;
                                        break;
                                    }
                                }
                            }
                        }
                        else continue;
                    }
                    else continue;
                    //nếu như thỏa hết điều kiện thì trả về
                    if (valid) return color;
                }
            }
            //không thỏa điều kiện thì không tìm được màu nào
            return null;
        }
        #endregion SmallestAvailableColor

        private int maxDay = 7;
        public int MaxDay
        {
            get
            {
                return maxDay;
            }
            set
            {
                maxDay = value;
            }
        }

        public int TimeSlot
        {
            get
            {
                return noOfTimeSlot;
            }
            set
            {
                noOfTimeSlot = value;
            }
        }
    }
}