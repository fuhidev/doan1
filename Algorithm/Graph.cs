using System;
using System.Collections.Generic;
using System.Linq;
using Database;
using ExamSchedule.Algorithm.Model;
using ExamSchedule.Model;

namespace ExamSchedule.Algorithm
{
    public class Graph : IGraph
    {
        #region Constructor

        public Graph(Databases db = null)
        {
            if (db != null)
                Database = db;
            assignColor = new AssignColor();

        }

        #endregion Constructor

        public override IEnumerable<ConflictCourse> Analyze()
        {
            List<ConflictCourse> result = new List<ConflictCourse>();
            var CLs = new List<Color.ColorRoomCourse>();
            Database.ListRoom.ForEach(a => CLs.Add(new Color.ColorRoomCourse
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
            listNode.ForEach(f =>
            {
                color.CheckAbilityRooms(f.ListFamily);


            });
            var lq = from n in listNode
                     where !color.CheckAbilityRooms(n.ListFamily)
                     select n;
            foreach (var current in lq)
            {
                //kiem tra xem size cua node co vuot qua kha nang dap ung cua ca thi hay khong
                if (current.SumSize > color.GetCL(current.Type))
                {
                    current.ListFamily.ForEach(f =>
                    {
                        result.Add(new ConflictCourse
                        {
                            Course = f,
                            Status = ConflictCourse.StatusConst.OverFlow
                        });
                    });
                }
                //neu khong phai thi tach nhom
                else
                {
                    current.ListFamily.ForEach(f =>
                    {
                        result.Add(new ConflictCourse
                        {
                            Course = f,
                            Status = ConflictCourse.StatusConst.SplitGroup
                        });
                    });
                }
            }
            this.analyzeList = result;
            return result;

        }
        public override void Run()
        {
            buildGraph = new BuildGraph(Database.ListStudent, Database.ListCourse,
                Database.ListRoom);
            buildGraph.Build();
            IEnumerable<Course> list = from n in Analyze()
                                       select n.Course;

            while (list.Count() > 0)
            {
                SplitMutiGroup mutiGroup = new SplitMutiGroup
                {
                    MAX_ROOM_PM = Database.ListRoom.Where(a => a.Type.Equals(Room.LAB)).Max(a => a.Size),
                    MAX_ROOM_LT = Database.ListRoom.Where(a => a.Type.Equals(Room.STANDARD)).Max(a => a.Size),
                    Rooms = Database.ListRoom
                };
                var enumerator = list.GetEnumerator();
                while (enumerator.MoveNext())
                {

                    var result = mutiGroup.Excute(enumerator.Current);
                    if (result.Count == 0)
                        continue;
                    Database.ListCourse.Remove(enumerator.Current);
                    Database.ListCourse.AddRange(result);
                }
                buildGraph.ListCourse = Database.ListCourse;
                buildGraph.ListStudent = Database.ListStudent;
                buildGraph.Build();
                list = from n in Analyze()
                       select n.Course;
            }

            assignColor.ListNode = this.listNode;
            assignColor.ListRoom = Database.ListRoom;
            assignColor.Assign();
            Console.WriteLine(String.Format("Số môn thi {0}, số môn đã xếp {1}", Database.ListCourse.Count, assignColor.GetCourseHaveSchedule().Count()));
        }

        public override Node GetNodeByCourse(Course course)
        {
            //var node = listNode.FirstOrDefault(a => a.ID == course.ID && a.ListFamily.Any(b => b.Equals(course)));
            var node = listNode.FirstOrDefault(f => f.Equals(course));
            if (node == null)
                Console.WriteLine(course);
            return node;
        }

        public override IEnumerable<Scheduling> GetSchedulings(DateTime timeBegin)
        {
            var assign = new AssignDate
            {
                Time = timeBegin
            };
            var lq = from n in listNode
                     where n.Color != null
                     from cl in n.Color.CLs
                     from fml in n.ListFamily
                     where
                         n != null &&
                         cl != null &&
                         fml != null &&
                         cl.Course != null
                         && cl.Course.Equals(fml)
                     select new Scheduling
                     {
                         Course = fml,
                         DateExam = assign.Assign(n.Color.Day),
                         Exam = n.Color.Exam,
                         Room = cl.Room
                     };
            return lq;
        }
        public override IEnumerable<Node> GetCourseNotColor()
        {
            var lq = from n in listNode
                     where n.Color == null
                     select n;
            return lq;
        }

        public int NumDay
        {
            get { return assignColor.NumDay; }
        }
        #region Variables
        private List<Node> listNode { get { return buildGraph.ListNode; } }
        private Databases db;
        private Databases Database { get { return db; } set { db = value; } }
        private BuildGraph buildGraph;
        private AssignColor assignColor;

        #endregion Variables

        public override int MaxDay
        {
            get
            {
                return assignColor.MaxDay;
            }
            set
            {
                assignColor.MaxDay = value;
            }
        }

        public override int TimeSlot
        {
            get
            {
                return assignColor.TimeSlot;
            }
            set
            {
                assignColor.TimeSlot = value;
            }
        }

        private List<ConflictCourse> analyzeList;

        public override IEnumerable<ConflictCourse> Resolve()
        {
            List<ConflictCourse> result = new List<ConflictCourse>();
            int maxPM = Database.ListRoom.Where(a => a.Type.Equals(Room.LAB)).Max(a => a.Size);
            int maxLT = Database.ListRoom.Where(a => a.Type.Equals(Room.STANDARD)).Max(a => a.Size);
            SplitMutiGroup mutiGroup = new SplitMutiGroup
            {
                MAX_ROOM_PM = maxPM,
                MAX_ROOM_LT = maxLT,
                Rooms = Database.ListRoom
            };
            if (analyzeList == null)
                Analyze();
            var enumerator = analyzeList.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                //get tpe of node
                var color = Color.Emulator(Database.ListRoom);
                //kiem tra xem size cua node co vuot qua kha nang dap ung cua ca thi hay khong
                switch (current.Status)
                {
                    case ConflictCourse.StatusConst.OverFlow:
                        //current.Course.Constrant = true;
                        result.Add(new ConflictCourse
                        {
                            Course = current.Course,
                            Status = ConflictCourse.StatusConst.Done
                        });
                        break;
                    case ConflictCourse.StatusConst.SplitGroup:
                        var splits = mutiGroup.Excute(current.Course);
                        if (splits.Count == 0)
                            continue;
                        String stt = "";
                        splits.ForEach(f =>
                        {
                            stt += f.ToString() + " ";
                        });

                        result.Add(new ConflictCourse
                        {
                            Course = current.Course,
                            Status = "Đã tách thành " + stt
                        });
                        break;

                }
            }
            return result;
        }
    }
}