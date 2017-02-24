using System;
using System.Collections.Generic;

namespace ExamSchedule.Model
{
    public class Course : IComparer<Course>
    {
        public Course()
        {
            LstStudent = new List<Student>();
        }

        public string ID { get; set; }
        public string Name { get; set; }
        public int Group { get; set; }
        public int Block { get; set; }

        public int Quantity
        {
            get { return LstStudent.Count; }
        }

        public string Type { get; set; }
        public List<Student> LstStudent { get; set; }
        public bool Constrant { get; set; }//true neu co thi chung

        public override bool Equals(object obj)
        {
            var c = obj as Course;
            return ID.Equals(c.ID) && Group.Equals(c.Group) && c.Block.Equals(this.Block); //so sánh 2 đối tượng course thông qua so sánh 2 ID
        }

        public override string ToString()
        {
            return String.Format("id={0},name={1},group={2},block={3},students={4},type={5}", ID, Name, Group, Block, LstStudent.Count, Type);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


        public int Compare(Course x, Course y)
        {
            return x.Quantity.CompareTo(y.Quantity);
        }
    }
}