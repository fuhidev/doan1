using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ExamSchedule.Model;

namespace ExamSchedule.Algorithm.Model
{
    public class Node : IComparable<Node>
    {
        public Node()
        {
            NeighBors = new List<NeighBor>(); //khởi tạo
            ListFamily = new List<Course>();
        }

        public string ID { get; set; }
        public string Name { get; set; }
        public List<Course> ListFamily { get; set; }
        public List<NeighBor> NeighBors { get; set; }
        public int Degree { get; set; }
        public Color Color { get; set; }

        public int CompareTo(Node other)
        {
            if (Degree > other.Degree)
                return -1;
            if (Degree < other.Degree)
                return 1;
            if (NeighBors.Count != 0
                && other.NeighBors.Count != 0)
            {
                var myW = NeighBors.Max(a => a.Weight);
                var yourW = other.NeighBors.Max(a => a.Weight);
                if (myW > yourW)
                    return -1;
                if (myW < yourW)
                    return 1;
            }
            return 0;
        }

        public IEnumerable<Student> Students
        {
            get
            {
                return from course in ListFamily
                       from std in course.LstStudent
                       select std;
            }
        }
        public int SumSize { get { return ListFamily.Sum(a => a.Quantity); } }

        public List<Node> GetNeighBorNodes()
        {
            return NeighBors.Select(a => a.Node).ToList();
        }

        private bool IsNeighborNode(Node n)
        {
            return NeighBors.Any(a => a.Node.Equals(n));
        }

        public void AddNeighbor(Node n, int w = 1)
        {
            Degree++;
            if (IsNeighborNode(n))
            {
                NeighBors.FirstOrDefault(a => a.Node.Equals(n)).Weight++;
            }
            else
            {
                NeighBors.Add(new NeighBor
                {
                    Node = n,
                    Weight = w
                });
            }
        }

        public override string ToString()
        {
            return string.Format("Node=[id={0}, name={1} ,group={2}, degree={3},course={4} Color={4}]", ID, Name, "",
                Degree, ListFamily.Count, Color);
        }

        public override bool Equals(object obj)
        {
            if (obj is Course)
            {
                var c = obj as Course;
                return ID == c.ID && this.ListFamily.Contains(c);
            }
            var n = obj as Node;
            return ID.Equals(n.ID) && this.ListFamily.First().Equals(n.ListFamily.First()); //so sánh 2 đối tượng Node thông qua so sánh 2 đối tượng Course
        }
        public String Type
        {
            get
            {
                return ListFamily.First().Type;
            }
        }

        public class NeighBor
        {
            public Node Node { get; set; }
            public int Weight { get; set; }
        }
    }
}