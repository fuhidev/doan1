using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ExamSchedule.Model;
using Excel;

namespace Database
{
    internal class ReadDatabase
    {
        //public const string FILE_COURSE_PATH = "D:/course.xlsx";
        //public const string FILE_STUDENT_PATH = "D:/student.xlsx";
        //public const string FILE_ROOM_PATH = "D:/room.xlsx";
        private static IExcelDataReader excelReader;

        private static IExcelDataReader Connection(string fileName)
        {
            try
            {
                var stream = File.Open(fileName, FileMode.Open, FileAccess.Read);

                //1. Reading from a binary Excel file ('97-2003 format; *.xls)
                //IExcelDataReader excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
                //...
                //2. Reading from a OpenXml Excel file (2007 format; *.xlsx)
                excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                //...
                //3. DataSet - The result of each spreadsheet will be created in the result.Tables
                var result = excelReader.AsDataSet();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //...
            //4. DataSet - Create column names from first row
            //excelReader.IsFirstRowAsColumnNames = true;
            //DataSet result = excelReader.AsDataSet();

            //5. Data Reader methods

            //6. Free resources (IExcelDataReader is IDisposable)
            return excelReader;
        }

        public static IEnumerable<Course> ReadCourse(string fileName)
        {
            Console.WriteLine("Đang đọc danh sách môn");
            List<Course> result = new List<Course>();
            try
            {
            Connection(fileName);
            var first = true;
            while (excelReader.Read())
            {
                if (first)
                {
                    first = false;
                    continue;
                }
                var course = new Course();
                var id = excelReader.GetString(0);
                var name = excelReader.GetString(1);
                var group = excelReader.GetString(2);
                var block = excelReader.GetString(3);
                //var quantity = excelReader.GetString(4);
                var type = excelReader.GetString(5);
                var constrant = excelReader.GetString(6);
                if (!string.IsNullOrEmpty(id)
                    && !string.IsNullOrEmpty(name)
                    && !string.IsNullOrEmpty(group)
                    && !string.IsNullOrEmpty(type)
                    && !type.Equals(Room.NOTTEST)
                    )
                {
                    course.ID = id;
                    course.Name = name;
                    course.Group = string.IsNullOrEmpty(group) ? -1 : int.Parse(group);
                    course.Block = string.IsNullOrEmpty(block) ? -1 : int.Parse(block);
                    //course.Quantity = String.IsNullOrEmpty(quantity) ? -1 : Int32.Parse(quantity);
                    course.Type = string.IsNullOrEmpty(type) && (type.Equals(Room.LAB) || type.Equals(Room.STANDARD))
                        ? ""
                        : type;
                    course.Constrant = string.IsNullOrEmpty(constrant) ? false : true;
                    if (course.Type.Equals(Room.NOTTEST))
                    {
                        continue;
                    }
                    //yield return course;
                    result.Add(course);
                }
            }
            }
            catch (Exception ex)
            {
                throw ex;
                Console.WriteLine(ex);
            }
            excelReader.Close();
            Console.WriteLine("Đọc danh sách môn thành công");
            return result;
        }

        public static List<Student> ReadStudent(string fileName)
        {
            Console.WriteLine("Đang đọc danh sách sinh viên");
            var result = new List<Student>();
            try
            {
                Connection(fileName);
                var first = true;
                while (excelReader.Read())
                {
                    if (first)
                    {
                        first = false;
                        continue;
                    }
                    var student = new Student();
                    var id = excelReader.GetString(0);
                    var name = excelReader.GetString(1);

                    if (!string.IsNullOrEmpty(id))
                    {
                        student.ID = id;
                        student.Name = "";
                        student.Name = string.IsNullOrEmpty(name) ? "" : name;
                        result.Add(student);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
            excelReader.Close();
            Console.WriteLine("Đọc danh sách sinh viên thành công");
            return result;
        }

        public static List<Room> ReadRoom(string fileName)
        {
            Console.WriteLine("Đang đọc danh sách phòng");
            var result = new List<Room>();
            try
            {
                Connection(fileName);
                var first = true;
                while (excelReader.Read())
                {
                    var room = new Room();
                    if (first)
                    {
                        first = false;
                        continue;
                    }
                    var id = excelReader.GetString(0);
                    var size = excelReader.GetString(1);
                    var type = excelReader.GetString(2);
                    if (!string.IsNullOrEmpty(id)
                        && !string.IsNullOrEmpty(size)
                        && !string.IsNullOrEmpty(type))
                    {
                        room.ID = id;
                        room.Size = int.Parse(size);
                        room.Type = type;
                        result.Add(room);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
            excelReader.Close();
            result = result.OrderBy(a => a.Size).ToList();
            Console.WriteLine("Đọc danh sách phòng thành công");
            return result;
        }

        //public static void write()
        //{
        //    try
        //    {
        //        var listStd = new List<Student>();
        //        var result = new List<Student>();
        //        Connection(@"D:\Google Drive\Documents\Project 1\DATA\dssv.xlsx");
        //        var first = true;
        //        string[] lines = System.IO.File.ReadAllLines(@"D:\WriteLines2.txt");
        //        while (excelReader.Read())
        //        {
        //            if (first)
        //            {
        //                first = false;
        //                continue;
        //            }
        //            var stdid = excelReader.GetString(0);
        //            var stdname = excelReader.GetString(1);
        //            var std = new Student
        //            {
        //                ID = stdid,
        //                Name = stdname
        //            };

        //            listStd.Add(std);
        //        }
        //        foreach (var line in lines)
        //        {
        //            var std = listStd.FirstOrDefault(a => a.ID.Equals(line));
        //            var name = "";
        //            if (std != null)
        //            {
        //                name = std.Name;
        //            }
        //            var std1 = new Student
        //            {
        //                ID = line,
        //                Name = name
        //            };
        //            result.Add(std1);
        //        }
        //        using (System.IO.StreamWriter file =
        //        new System.IO.StreamWriter(@"D:\dssv.txt"))
        //        {
        //            foreach (var line in result)
        //            {
        //                // If the line doesn't contain the word 'Second', write the line to the file.
        //                file.WriteLine(line.ID + "\t" + line.Name);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    excelReader.Close();
        //}

        public static void ReadRegisterList(string fileName, List<Student> listStd, List<Course> listCourse)
        {
            Console.WriteLine("Đang gán dữ liệu");
            Connection(fileName);
            var first = true;
            while (excelReader.Read())
            {
                if (first)
                {
                    first = false;
                    continue;
                }
                var stdid = excelReader.GetString(0);
                var cid = excelReader.GetString(1);
                var cGroup = excelReader.GetString(3);
                if (!string.IsNullOrEmpty(stdid) && !string.IsNullOrEmpty(cid) && !string.IsNullOrEmpty(cGroup))
                {
                    var std = listStd.FirstOrDefault(a => a.ID.Equals(stdid));
                    var crs = listCourse.FirstOrDefault(a => a.ID.Equals(cid) && a.Group.Equals(int.Parse(cGroup)));
                    if (std != null && crs != null)
                    {
                        std.LstCourse.Add(crs);
                        crs.LstStudent.Add(std);
                        //crs.Quantity += 1;
                    }
                }
            }
            excelReader.Close();
            Console.WriteLine("Gán dữ liệu thành công");
        }

        private class StudentCourse
        {
            public string StdID { get; set; }
            public string CourseID { get; set; }
        }
    }
}