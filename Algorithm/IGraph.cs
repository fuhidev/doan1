using Database;
using ExamSchedule.Algorithm.Model;
using ExamSchedule.Model;
using System;
using System.Collections.Generic;

namespace ExamSchedule.Algorithm
{
    public abstract class IGraph
    {
        public Databases Database { set; get; }

        public abstract IEnumerable<ConflictCourse> Analyze();

        public abstract IEnumerable<ConflictCourse> Resolve();

        public abstract void Run();

        public abstract Node GetNodeByCourse(Course c);

        public abstract IEnumerable<Scheduling> GetSchedulings(DateTime timeBegin);

        public abstract IEnumerable<Node> GetCourseNotColor();

        public abstract int MaxDay { get; set; }
        public abstract int TimeSlot { get; set; }
        private IAssignColor assignColor;
        private IBuildGraph buildGraph;
    }
}