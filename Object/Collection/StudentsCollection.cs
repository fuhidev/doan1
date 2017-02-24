using System;
using System.Collections;
using System.Collections.Generic;

namespace ExamSchedule.Model.Collection
{
    public class StudentsCollection : ICollection<Student>
    {
        private readonly List<Student> list;

        public StudentsCollection()
        {
            list = new List<Student>();
        }

        public void AddAll(IEnumerable<Student> students)
        {
            list.AddRange(students);
        }

        public IEnumerator<Student> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Student item)
        {
            list.Add(item);
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(Student item)
        {
            return list.Contains(item);
        }

        public void CopyTo(Student[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Student item)
        {
            return list.Remove(item);
        }

        public int Count
        {
            get { return list.Count; }
        }

        public bool IsReadOnly { get; private set; }

        public IEnumerable<Student> IEnumerable()
        {
            return list;
        }
    }
}