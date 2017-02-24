using System;
using System.Collections.Generic;
using System.Linq;
using ExamSchedule.Model;

namespace ExamSchedule.Algorithm.Model
{
    public class Color
    {
        public Color()
        {
            ListNode = new List<Node>();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int GetCL(string type)
        {
            return CLs.Where(a => a.Course == null && a.Room.Type == type).Sum(a => a.Room.Size);
        }

        public override bool Equals(object obj)
        {
            var cl = obj as Color;
            return Day.Equals(cl.Day) && Exam.Equals(cl.Exam);
        }

        public override string ToString()
        {
            return String.Format("Color=[day={0}, exam={1}, nodeCount={2}]", this.Day, this.Exam, this.ListNode.Count);
        }

        //Tìm phòng phù hợp nhất với giá trị size
        private ColorRoomCourse FindRoom(Course course)
        {
            return
                CLs.Where(a => a.Course == null && a.Room.Equals(course))
                    .FirstOrDefault(a => a.Room.Size >= course.Quantity);
        }

        public static Color Emulator(List<Room> ListRoom)
        {
            var CLs = new List<Color.ColorRoomCourse>();
            ListRoom.ForEach(a => CLs.Add(new Color.ColorRoomCourse
            {
                Room = a,
                Course = null
            }));
            var color = new Color
            {
                Day = 1,
                Exam = 1,
                CLs = CLs
            };
            return color;
        }


        /// <summary>
        ///     Kiểm tra danh sách môn thi có đáp ứng được trong Color.
        /// </summary>
        /// <param name="courses">Danh sách môn thi cần kiểm tra.</param>
        /// <returns>
        ///     true: CLs đáp ứng được cho Courses
        /// </returns>
        /// <exception cref="System.ArgumentNullException">Courses</exception>
        public bool CheckAbilityRooms(List<Course> courses)
        {
            //kiểm tra xem giá trị truyền vào chuẩn chưa
            if (courses == null || courses.Count == 0)
                throw new ArgumentNullException("Courses");
            //gán giá trị ban đầu cho index
            var index = 0;

            //duyệt từng môn
            foreach (var c in courses)
            {
                //biến để kiểm tra xem sau mỗi vòng lặp CLs thì có tìm thấy room cho môn học hay không
                var valid = false;
                //duyệt vòng lặp từ index đến hết
                for (var i = index; i < CLs.Count; i++)
                {
                    //lấy crc
                    var crc = CLs[i];
                    //kiểm tra
                    if (crc.Course == null && crc.Room.Type.Equals(c.Type))
                    {
                        //kiểm tra
                        if (crc.Room.Size >= c.Quantity)
                        {
                            //nếu như thỏa điều kiện thì cho index = i + 1, có nghĩa là môn kế tiếp muốn tìm thì sẽ tìm từ đây đến hết danh sách chứ k tìm từ đầu đến cuối danh sách của CLs
                            index = i + 1;
                            //đã tìm được
                            valid = true; //(1)
                            break;
                        }
                    }
                }
                //nếu như CLs không thể đáp ứng cho phòng thì valid = false vì nếu đáp ứng được thì đã nhảy vào mục (1)
                if (!valid)
                    //có một môn nào không tìm được phòng để đáp ứng cho nó có nghĩa là Color này không đáp ứng được cho danh sách môn học này
                    return false;
            }
            return true;
        }

        /// <summary>
        ///     Adds the courses on rooms.
        /// </summary>
        /// <param name="courses">The courses.</param>
        /// <exception cref="System.ArgumentNullException">Courses</exception>
        /// <exception cref="System.Collections.Generic.KeyNotFoundException"></exception>
        public void AddCoursesOnRooms(List<Course> courses)
        {
            if (courses == null || courses.Count == 0)
                throw new ArgumentNullException("Courses");
            foreach (var c in courses)
            {
                var crs = FindRoom(c);
                if (crs == null)
                    throw new KeyNotFoundException(c.ToString());
                crs.AddCourseOnRoom(c);
            }
        }

        public class ColorRoomCourse 
        {
            public Room Room { get; set; }
            public Course Course { get; set; }

            public bool AddCourseOnRoom(Course c)
            {
                if (c == null)
                    throw new ArgumentNullException("Course");

                Course = c;

                return true;
            }

        }

        #region Variables

        public int Day { get; set; }

        public int Exam { get; set; }
        public List<ColorRoomCourse> CLs { get; set; }
        public List<Node> ListNode { get; set; }

        #endregion Variables
    }
}