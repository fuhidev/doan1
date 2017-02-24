using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ExamSchedule.Model.Collection
{
    public class RoomsCollection : ICollection<Room>
    {
        public List<Room> List { get; set; }

        public void Add(Room item)
        {
            List.Add(item);
        }

        public void AddAll(IEnumerable<Room> rooms)
        {
            List.AddRange(rooms);
        }

        public void Clear()
        {
            List.Clear();
        }

        public bool Contains(Room item)
        {
            return List.Contains(item);
        }

        public void CopyTo(Room[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return List.Count; }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public bool Remove(Room item)
        {
            return List.Remove(item);
        }

        public IEnumerator<Room> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Room> IEnumerable()
        {
            return List;
        }

        public int GetMaximum(string type)
        {
            return List.Where(a => a.Type.Equals(type)).Max(a => a.Size);
        }

        public int GetNum(string type)
        {
            return List.Where(a => a.Type.Equals(type)).Count();
        }
    }
}