using System;
using System.Collections.Generic;
using System.Linq;
using Database;
using ExamSchedule.Algorithm;
using ExamSchedule.Algorithm.Model;
using ExamSchedule.Model;

namespace ExamSchedule.BusinessDatabase
{
    public class DataProvider
    {
        private readonly Databases db;
        private readonly Graph graph;
        private IEnumerable<Scheduling> listSchedulings;
        private AssignDate Time;
        //private StudentProvider StudentProvider;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DataProvider" /> class.
        ///     /Khi khởi tạo thì Graph và DataProvider sẽ được khởi tạo theo.
        /// </summary>
        public DataProvider()
        {
            db = new Databases();
            graph = new Graph(db);
            //this.StudentProvider = new StudentProvider(db.ListStudent);
        }

        /// <summary>
        ///     Chèn dữ liệu vào chương trình
        /// </summary>
        /// <param name="fileNameCourse">Đường dẫn của danh sách môn học.</param>
        /// <param name="fileNameStudent">Đường dẫn của danh sách sinh viên.</param>
        /// <param name="fileNameRoom">Đường dẫn danh sách phòng.</param>
        /// <param name="fileNameRegistration">Đường dẫn danh sách đăng ký môn học.</param>
        /// <exception cref="System.Exception"></exception>
        public void ImportData(string fileNameCourse, string fileNameStudent, string fileNameRoom,
            string fileNameRegistration)
        {
            Console.WriteLine("Đang đọc dữ liệu...");
            try
            {
                db.ImportData(fileNameCourse, fileNameStudent, fileNameRoom, fileNameRegistration);
                //db.readCourse(fileNameCourse); db.readStudent(fileNameStudent); db.readRoom(fileNameRoom); db.AddStudentCourse(fileNameRegistration);
                Console.WriteLine("Đọc dữ liệu xong.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        ///     Tạo lịch thi
        /// </summary>
        /// <param name="TimeBegin">Thời điểm bắt đầu để bắt đầu kỳ thi.</param>
        /// <param name="MaxSchedule">Thời gian tối đa cho kỳ thi.</param>
        /// <param name="TS">Ca thi trong một ngày.</param>
        /// <exception cref="System.Exception"></exception>
        public void CreateScheduling(DateTime TimeBegin, int TS)
        {
                //graph.BuildGraph();

                //graph.AssignColor();


                graph.Run();
                graph.TimeSlot = TS;
                listSchedulings = graph.GetSchedulings(TimeBegin);
                Time = new AssignDate {Time = TimeBegin};
        }

        /// <summary>
        ///     Lấy lịch thi.
        /// </summary>
        /// <returns>Danh sách lịch thi</returns>
        /// <exception cref="System.InvalidTimeZoneException">Không tìm thấy thời gian khởi đầu</exception>
        public List<Scheduling> GetScheduling()
        {
            return listSchedulings.ToList();
        }

        /// <summary>
        ///     Lấy lịch thi cho sinh viên.
        /// </summary>
        /// <param name="student">Sinh viên cần lấy lịch thi.</param>
        /// <returns></returns>
        public List<Scheduling> GetSchedulingByStudent(Student student)
        {
            var result = new List<Scheduling>();
            foreach (var course in student.LstCourse)
            {
                var node = graph.GetNodeByCourse(course);
                var room = node.Color.CLs.
                    Where(
                        a => a.Course != null && a.Room.Type == course.Type).
                    FirstOrDefault(a => a.Course.Equals(course) && a.Course.Block == course.Block).Room;

                result.Add(new Scheduling
                {
                    Course = course,
                    DateExam = Time.Assign(node.Color.Day),
                    Exam = node.Color.Exam,
                    Room = room
                });
            }
            return result;
        }

        public List<Scheduling> GetCourseNotColor()
        {
            var list = graph.GetCourseNotColor();
            //foreach (var node in list)
            //{
            //    Console.WriteLine(node);
            //}

            return (from n in  list
                   from fml in n.ListFamily
                select new Scheduling
                {
                    Course = fml
                }).ToList();
        }


        /// <summary>
        ///     Lấy lịch thi cho sinh viên.
        /// </summary>
        /// <param name="studentID">Mã sinh viên.</param>
        /// <returns>Lịch thi của sinh viên</returns>
        /// <exception cref="System.ArgumentNullException">Không tìm thấy sinh viên: " + studentID</exception>
        public List<Scheduling> GetSchedulingByStudentID(string studentID)
        {
            var student = db.ListStudent.FirstOrDefault(a => a.ID == studentID);
            if (student == null)
                throw new ArgumentNullException("Không tìm thấy sinh viên: " + studentID);
            return GetSchedulingByStudent(student);
        }

        /// <summary>
        ///     Lấy danh sách sinh viên.
        /// </summary>
        /// <returns>Danh sách sinh viên</returns>
        public List<Student> GetListStudent()
        {
            return db.ListStudent;
        }

        /// <summary>
        ///     Lấy danh sách môn học.
        /// </summary>
        /// <returns>Danh sách môn học</returns>
        public List<Course> GetListCourse()
        {
            return db.ListCourse;
        }

        /// <summary>
        ///     Lấy danh sách phòng.
        /// </summary>
        /// <returns>Danh sách phòng</returns>
        public List<Room> GetListRoom()
        {
            return db.ListRoom;
        }

        /// <summary>
        ///     Lấy danh sách sinh viên với Tên tương tự
        /// </summary>
        /// <param name="ID">Một phần hoặc toàn bộ Tên của sinh viên.</param>
        /// <returns>Danh sách sinh viên</returns>
        /// <exception cref="System.ArgumentNullException">Tên bị trống</exception>
        public List<Student> GetStudentByLikeName(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("Tên bị trống");
            return (from std in db.ListStudent
                where std.Name.StartsWith(name)
                select std).ToList();
        }

        /// <summary>
        ///     Lấy danh sách sinh viên với ID tương tự
        /// </summary>
        /// <param name="ID">Một phần hoặc toàn bộ ID của sinh viên.</param>
        /// <returns>Danh sách sinh viên</returns>
        /// <exception cref="System.ArgumentNullException">ID bị trống</exception>
        public List<Student> GetStudentByLikeID(string ID)
        {
            if (string.IsNullOrEmpty(ID))
                throw new ArgumentNullException("ID bị trống");
            return (from std in db.ListStudent
                where std.ID.StartsWith(ID)
                select std).ToList();
        }

        /// <summary>
        ///     Lấy danh sách sinh viên với thuộc tính bất kỳ.
        /// </summary>
        /// <param name="Request">ID hoặc tên hoặc lớp....</param>
        /// <returns>Danh sách sinh viên</returns>
        /// <exception cref="System.ArgumentNullException">Dữ liệu truyền vào bị trống</exception>
        public List<Student> GetStudentLikeRequest(string Request)
        {
            if (string.IsNullOrEmpty(Request))
                throw new ArgumentNullException("Dữ liệu truyền vào bị trống");
            return (from std in db.ListStudent
                where std.ID.StartsWith(Request) ||
                      std.Name.StartsWith(Request) ||
                      std.Class.StartsWith(Request)
                select std).ToList();
        }

        //public List<Node> GetListNode()
        //{
        //    return graph.ListNode;
        //}

        #region Node

        //public IEnumerable<Node> GetCourseNotSchedule()
        //{
        //    try
        //    {
        //        return graph.GetCourseNotSchedule();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public IEnumerable<Node> GetCourseHaveSchedule()
        //{
        //    try
        //    {
        //        return graph.GetCourseHaveSchedule();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public bool CheckFullAssignColor()
        //{
        //    try
        //    {
        //        return graph.CheckFullAssignColor();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        #endregion Node
    }
}