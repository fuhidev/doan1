using System;
using ExamSchedule.GUI.Properties;

namespace ExamSchedule.GUI
{
    internal class ConfigService : IConfig
    {
        private readonly Settings d = Settings.Default;

        public ConfigService()
        {
            pathStudent = d.studentPath;
            pathCourse = d.coursePath;
            pathRoom = d.roomPath;
            pathRegister = d.registerPath;
            pathCourse = d.schedulePath;
        }

        public string pathStudent { get; set; }
        public string pathCourse { get; set; }
        public string pathRoom { get; set; }
        public string pathRegister { get; set; }
        public string pathSchedule { get; set; }

        public void Default()
        {
            try
            {
                d.studentPath = @"C:\Users\TIEN\Desktop\DuLieu\DS_SV.xlsx";
                d.registerPath = @"C:\Users\TIEN\Desktop\DuLieu\DS_DKMH.xlsx";
                d.roomPath = @"C:\Users\TIEN\Desktop\DuLieu\DS_PHONG.xlsx";
                d.coursePath = @"C:\Users\TIEN\Desktop\DuLieu\DS_MON.xlsx";
                d.schedulePath = @"C:\Users\TIEN\Desktop\DuLieu\LICH_THI.xlsx";
                d.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            d.coursePath = pathCourse;
            d.roomPath = pathRoom;
            d.registerPath = pathRegister;
            d.studentPath = pathStudent;
            d.schedulePath = pathSchedule;
            Settings.Default.Save();
        }
    }
}