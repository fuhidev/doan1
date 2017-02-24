using Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSchedule.Algorithm.SplitGroups
{
    public class SplitMutiGroup
    {
        public int MAX_ROOM_PM { get; set; }
        public int MAX_ROOM_LT { get; set; }
        public List<Room> rooms { get; set; }
       
        public List<Course> excuteSplit(Course course)
        {
            List<Course> courses = new List<Course>();
            List<Room> lstRoomsAvailable = new List<Room>();
            int sumAvailableChair = 0;
            // Kiểm tra xem môn thi lý thuyết hay thực hành.
            if (course.Type.Equals(Room.LAB))
            {
                rooms = rooms.Where(a => a.Type.Equals(Room.LAB)).ToList();
            }
            else if (course.Type.Equals(Room.STANDARD))
            {
                rooms = rooms.Where(a => a.Type.Equals(Room.STANDARD)).ToList();
            }
            for (int i = rooms.Count - 1; i >= 0; i--)
            {
                if (sumAvailableChair >= course.Quantity) break;
                sumAvailableChair += rooms[i].Size;
                lstRoomsAvailable.Add(rooms[i]);

            }
            // Số lượng sinh viên còn lại
            int lastNumOfStudents = 0;
            // chia danh sách sinh viên bắt đầu từ số lượng x;
            int startStudent = 0;
            for (int i = 0; i < lstRoomsAvailable.Count; i++)
            {
                int block = course.Block + i + 1, quantity = 0;
                if (i == lstRoomsAvailable.Count - 1)
                {
                    quantity = (course.LstStudent.Count - lastNumOfStudents);
                }
                else
                {
                    quantity = lstRoomsAvailable[i].Size;
                    lastNumOfStudents += lstRoomsAvailable[i].Size;
                }
                courses.Add(new Course
                {
                    ID = course.ID,
                    Name = course.Name,
                    Group = course.Group,
                    Block = block,
                    Quantity = quantity,
                    Type = course.Type,
                    LstStudent = getNewStudents(course.LstStudent, startStudent, quantity).ToList()

                });
                startStudent += lstRoomsAvailable[i].Size;
            }
            return courses;
        }
        public IEnumerable<Student> getNewStudents(List<Student> lstStu, int off, int length) {
            for (int i = off; i < off + length; i++)
                yield return lstStu[i];
            
        }
    }
}
