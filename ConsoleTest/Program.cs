using System;
using ExamSchedule.BusinessDatabase;
using Database;

namespace ConsoleTest
{
    internal class
        Program
    {
        private static void TestDatabase()
        {
            //var db = new DataProvider();
            ////db.readCourse(@"D:\Google Drive\Documents\Project 1\DATA\DanhSachMon_HK3_CNTT.xlsx");
            ////db.lstCourse.ForEach(a => Console.WriteLine(a.ToString()));
            ////db.readRoom(@"D:\Google Drive\Documents\Project 1\DATA\PhongThi_HK3.xlsx");
            ////db.lstRoom.ForEach(a => Console.WriteLine(a.ToString()));
            //db.readStudent(@"D:\Google Drive\Documents\Project 1\DATA\danhsachsinhvien.xlsx");
            //db.ListStudent.ForEach(a => Console.WriteLine(a.ToString()));
            //Console.WriteLine(db.lstStudent.Count);
        }

        private static void TestIndepent()
        {
            //var db = new Databases();
            //db.ImportData(@"D:\Documents\Visual Studio 2013\Projects\DoAn2\data\DS_MON.xlsx",
            //                @"D:\Documents\Visual Studio 2013\Projects\DoAn2\data\DS_SV.xlsx",
            //                @"D:\Documents\Visual Studio 2013\Projects\DoAn2\data\DS_PHONG.xlsx",
            //                @"D:\Documents\Visual Studio 2013\Projects\DoAn2\data\DS_DKMH.xlsx");
            //IndependentSet independentSet = new IndependentSet(db);
            //var list = independentSet.Run();
            //list.ForEach(f=>Console.WriteLine(f));
        }
        private static void Main(string[] args)
        {
            //TestIndepent();

            try
            {
                var db = new DataProvider();
                String path = @"D:\Documents\Visual Studio 2013\Projects\DoAn1\data\DuLieuKhoa\";
                db.ImportData(path + "DS_MON.xlsx",
                                path + "DS_SV.xlsx",
                                path + "DS_PHONG.xlsx",
                                path + "DS_DKMH.xlsx");
                //db.GetStudentByLikeID("5130").ForEach(a => Console.WriteLine(a.ID));
                //db.GetStudentByLikeName("Hồ").ForEach(a => Console.WriteLine(a.Name));
                db.CreateScheduling(DateTime.Now, 8);
                var sch = db.GetScheduling();
                //var sch = db.GetSchedulingByStudentID("51303415");
                ////Console.WriteLine(sch.Count);
                foreach (var s in sch)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("________________________________________");
                db.GetCourseNotColor().ForEach(a => Console.WriteLine(a.Course));
                Console.WriteLine(db.GetCourseNotColor().Count);
                while (true)
                {
                    var id = Console.ReadLine();
                    var sc = db.GetSchedulingByStudentID(id);
                    foreach (var s in sc)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            //CleanCourses();
        }
    }
}