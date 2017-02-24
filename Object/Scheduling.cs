using System;

namespace ExamSchedule.Model
{
    public class Scheduling
    {
        public Course Course { get; set; }
        public Room Room { get; set; }
        public DateTime DateExam { get; set; }
        public int Exam { get; set; }

        public override string ToString()
        {
            return Course + "\n" + Room.ID.PadRight(10) + DateExam.ToShortDateString().PadRight(20) + Exam;
        }
    }
}