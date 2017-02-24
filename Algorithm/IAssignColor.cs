namespace ExamSchedule.Algorithm
{
    internal interface IAssignColor
    {
        void Assign();
        int MaxDay { get; set; }
        int TimeSlot { get; set; }
    }
}