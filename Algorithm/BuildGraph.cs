using ExamSchedule.Algorithm.Model;
using ExamSchedule.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamSchedule.Algorithm
{
    internal class BuildGraph : IBuildGraph
    {
        public BuildGraph(List<Student> listStudent, List<Course> listCourse, List<Room> listRoom)
        {
            ListStudent = listStudent;
            ListCourse = listCourse;
            ListRoom = listRoom;
        }

        public List<Node> ListNode { get; set; }
        public List<Student> ListStudent { get; set; }
        public List<Course> ListCourse { get; set; }
        public List<Room> ListRoom { get; set; }

        public void Build()
        {
            Console.WriteLine("Build.");
            BuildNode();
            if (ListNode == null)
                throw new NullReferenceException("Không khởi tạo được Node");
            var edges = CliquesToEdges(ListStudent);

            foreach (var e in edges)
            {
                //var n1 = ListNode.Where(a => a.ID.Equals(e.Item1.ID) && a.ListFamily.Any(b => b.Equals(e.Item1))).FirstOrDefault();
                //var n2 = ListNode.Where(a => a.ID.Equals(e.Item2.ID) && a.ListFamily.Any(b => b.Equals(e.Item2))).FirstOrDefault();
                //var n1 = ListNode.Where(a => a.Equals(e.Item1)).FirstOrDefault();
                //var n2 = ListNode.Where(a => a.Equals(e.Item2)).FirstOrDefault();
                var n1 = ListNode.FirstOrDefault(a => a.Equals(e.Item1));
                var n2 = ListNode.FirstOrDefault(a => a.Equals(e.Item2));
                if (n1 == null)
                    throw new NullReferenceException();
                if (n2 == null)
                    throw new NullReferenceException();
                //if (n1 != null && n2 != null)
                //{
                n1.AddNeighbor(n2);
                n2.AddNeighbor(n1);
                //}
            }
        }

        public IEnumerable<Tuple<Course, Course>> CliquesToEdges(IEnumerable<Student> lstStudent)
        {
            var lq = from std in lstStudent
                     from c1 in std.LstCourse
                     from c2 in std.LstCourse
                     where !c1.Equals(c2)
                     && c1.Quantity > 0 && c2.Quantity > 0
                     select new { c1, c2 };

            var l1 = from l in lq
                     group l by new
                     {
                         l.c1,
                         l.c2
                     }
                         into c
                         select Tuple.Create(c.Key.c1, c.Key.c2);
            return l1;
        }

        private void BuildNode()
        {
            //CleanCourses();
            Console.WriteLine("Build Node");
            ListNode = new List<Node>();
            if (ListCourse.Count == 0 || ListCourse == null)
            {
                throw new NullReferenceException("Không tìm thấy danh sách môn");
            }
            foreach (var c in ListCourse)
            {
                //rong thi bo qua
                if (c.Quantity == 0) continue;

                if (!c.Constrant)
                {
                    var n = ListNode.FirstOrDefault(a => a.ID == c.ID);
                    if (n == null)
                    {
                        //tạo đối tượng Node để thêm vào List
                        n = new Node
                        {
                            ID = c.ID,
                            Name = c.Name
                        };

                        //thêm node vào trong danh sách
                        ListNode.Add(n);
                    }
                    //thêm course vào trong danh sách course của node
                    n.ListFamily.Add(c);
                }
                else
                {
                    Node n = new Node
                    {
                        ID = c.ID,
                        Name = c.Name,
                    };
                    n.ListFamily.Add(c);
                    ListNode.Add(n);
                }
            }
            ListNode.ForEach(f =>
            {
                f.ListFamily.Sort((x, y) => x.Quantity.CompareTo(y.Quantity));
            });
        }
    }
}