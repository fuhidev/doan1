using System;
using System.Collections.Generic;
using System.Linq;
using ExamSchedule.Model;

namespace Database
{
    public class Databases
    {
        public List<Course> ListCourse { get; set; }
        public List<Student> ListStudent { get; set; }
        public List<Room> ListRoom { get; set; }

        public void ImportData(string fileNameCourse, string fileNameStudent, string fileNameRoom,
            string fileNameRegistration)
        {
            try
            {
                ListStudent = ReadDatabase.ReadStudent(fileNameStudent);
                ListCourse = ReadDatabase.ReadCourse(fileNameCourse).ToList();
                
                ListRoom = ReadDatabase.ReadRoom(fileNameRoom);
                //RoomsCollection.AddAll(ReadDatabase.ReadRoom(fileNameRoom));
                //CoursesCollection.AddAll(ReadDatabase.ReadCourse(fileNameCourse));
                ReadDatabase.ReadRegisterList(fileNameRegistration, ListStudent, ListCourse);
                ListCourse = ListCourse.Where(w => w.Quantity > 0).ToList();
                //ListCourse = CoursesCollection.IEnumerable().ToList();
                //ListRoom = RoomsCollection.IEnumerable().ToList();
                //ListStudent = StudentsCollection.IEnumerable().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}