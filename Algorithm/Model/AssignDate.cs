using System;

namespace ExamSchedule.Algorithm.Model
{
    public class AssignDate
    {
        public DateTime Time { get; set; }

        public DateTime Assign(int time)
        {
            return Time.AddDays(time);
        }

        public static DateTime Assign(DateTime dt, int time)
        {
            return dt.AddDays(time);
        }
    }
}