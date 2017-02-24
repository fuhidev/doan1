using System;
using System.Collections.Generic;

namespace ExamSchedule.Model
{
    public class Student
    {
        public Student()
        {
            LstCourse = new List<Course>();
        }

        public string ID { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public List<Course> LstCourse { get; set; }

        public override bool Equals(object obj)
        {
            return ID.Equals((obj as Student).ID);
        }

        public override string ToString()
        {
            var s = "ID:" + ID + ";Name:" + Name + ";course:\n";
            foreach (var c in LstCourse)
                s += c.ID + " ";
            return s;
        }

    }
}