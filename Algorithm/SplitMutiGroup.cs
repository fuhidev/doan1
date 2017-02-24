using System.Collections.Generic;
using System.Linq;
using ExamSchedule.Model;

namespace ExamSchedule.Algorithm
{
    public class SplitMutiGroup
    {
        public int MAX_ROOM_PM { get; set; }
        public int MAX_ROOM_LT { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Course> Excute(Course course)
        {
            var courses = new List<Course>();
            var lstRoomsAvailable = new List<Room>();
            var sumAvailableChair = 0;
            List<Room> rooms = null;
            // Kiểm tra xem môn thi lý thuyết hay thực hành.
            if (course.Type.Equals(Room.LAB))
            {
                rooms = Rooms.Where(a => a.Type.Equals(Room.LAB)).ToList();
            }
            else if (course.Type.Equals(Room.STANDARD))
            {
                rooms = Rooms.Where(a => a.Type.Equals(Room.STANDARD)).ToList();
            }
            for (var i = 0; i < rooms.Count; i++)
            {
                if (sumAvailableChair >= course.Quantity) break;
                sumAvailableChair += rooms[i].Size;
                lstRoomsAvailable.Add(rooms[i]);
            }
            // Số lượng sinh viên còn lại
            var lastNumOfStudents = 0;
            // chia danh sách sinh viên bắt đầu từ số lượng x;
            var startStudent = 0;
            for (var i = 0; i < lstRoomsAvailable.Count; i++)
            //for (var i = lstRoomsAvailable.Count-1; i >= 0; i--)
            {
                int block = course.Block + i + 1, quantity = 0;
                //if (i == 0)
                if (i == lstRoomsAvailable.Count - 1)
                    quantity = course.LstStudent.Count - lastNumOfStudents;
                else
                {
                    quantity = lstRoomsAvailable[i].Size;
                    lastNumOfStudents += lstRoomsAvailable[i].Size;
                }
                var lstStd = getNewStudents(course.LstStudent, startStudent, quantity).ToList();
                var c = new Course
                {
                    ID = course.ID,
                    Name = course.Name,
                    Group = course.Group,
                    Block = block,
                    Type = course.Type,
                    Constrant = course.Constrant,
                    LstStudent = lstStd
                };
                courses.Add(c);
                lstStd.ForEach(f =>
                {
                    f.LstCourse.Remove(course);
                    f.LstCourse.Add(c);
                });
                startStudent += lstRoomsAvailable[i].Size;
            }
            return courses;
        }

        public IEnumerable<Student> getNewStudents(List<Student> lstStu, int off, int length)
        {
            for (var i = off; i < off + length; i++)
                yield return lstStu[i];
        }
    }
}