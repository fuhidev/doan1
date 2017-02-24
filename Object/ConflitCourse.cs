using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamSchedule.Model
{
    public class ConflictCourse
    {
        public static class StatusConst
        {
            public const String OverFlow = "Vượt quá khả năng";
            public const String SplitGroup = "Cần tách nhóm";
            public const String Done = "Giải quyết xong";

        }
        public Course Course { get; set; }
        public string ID { get { return Course.ID; } set { Course.ID = value; } }
        public string Name { get { return Course.Name; } set { Course.Name = value; } }
        public int Group { get { return Course.Group; } set { Course.Group = value; } }
        public int Block { get { return Course.Block; } set { Course.Block = value; } }
        public String Status { get; set; }


    }
}
