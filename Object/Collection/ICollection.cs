using System.Collections.Generic;

namespace ExamSchedule.Model.Collection
{
    public interface ICollection<T> : System.Collections.Generic.ICollection<T>
    {
        void AddAll(IEnumerable<T> enumerable);

        IEnumerable<T> IEnumerable();
    }
}