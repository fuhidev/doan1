using System;
using System.Collections;
using System.Collections.Generic;

namespace ExamSchedule.Model.Collection
{
    public class CoursesCollection : ICollection<Course>
    {
        private readonly List<Course> list;

        public CoursesCollection()
        {
            list = new List<Course>();
        }

        public void Add(Course item)
        {
            list.Add(item);
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(Course item)
        {
            return list.Contains(item);
        }

        public void CopyTo(Course[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return list.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(Course item)
        {
            return list.Remove(item);
        }

        public IEnumerator<Course> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void AddAll(IEnumerable<Course> enumerable)
        {
            list.AddRange(enumerable);
        }

        public IEnumerable<Course> IEnumerable()
        {
            return list;
        }
    }
}