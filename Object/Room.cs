using System;

namespace ExamSchedule.Model
{
    public class Room : IComparable<Room>, ICloneable
    {
        public const string LAB = "PM";
        public const string STANDARD = "LT";
        public const string NOTTEST = "KhongThi";
        public string ID { get; set; }
        public int Size { get; set; }
        public string Type { get; set; }

        public object Clone()
        {
            return new Room
            {
                ID = ID,
                Size = Size,
                Type = Type
            };
        }

        public int CompareTo(Room other)
        {
            if (Size > other.Size)
                return 1;
            if (Size < other.Size)
                return -1;
            return 0;
        }

        public override string ToString()
        {
            var s = "ID: " + ID + ";Size: " + Size + ";Type: " + Type;
            return s;
        }

        public override bool Equals(object obj)
        {
            if (obj is Course)
            {
                var courseType = (obj as Course).Type;
                if (Type.Equals(courseType))
                    return true;
                return false;
            }
            return ID.Equals((obj as Room).ID);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}