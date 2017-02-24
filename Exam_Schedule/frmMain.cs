using System;
using System.Windows.Forms;
using ExamSchedule.BusinessDatabase;
using ExamSchedule.GUI.Properties;

namespace ExamSchedule.GUI
{
    public partial class MainForm : Form
    {
        private DataProvider db = new DataProvider();
        private frmLichThiSinhVien frmLichThiSinhVien;
        // Lấy danh sách sinh viên

        private frmTaoLichThi frmTaoLichThi;

        private ucFullConfig ucFullConfig;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //WindowsWait.SplashScreenManager.ShowWaitForm();
            //WindowsWait.WaitFormManager.ShowWaitForm("Đang cập nhật dữ liệu");
            FormServices.ChangeLabelSkin(this);
            db = new DataProvider();
            ImportData();
            //WindowsWait.WaitFormManager.CloseWaitForm();
            //WindowsWait.SplashScreenManager.CloseWaitForm();
        }

        private void ImportData()
        {
            //ConfigService config = new ConfigService();
            //config.Default();
            Settings.Default.Reset();
            var pathStudent = Settings.Default.studentPath;
            var pathCourse = Settings.Default.coursePath;
            var pathRoom = Settings.Default.roomPath;
            var pathRegister = Settings.Default.registerPath;
            try
            {
                db.ImportData(pathCourse, pathStudent, pathRoom, pathRegister);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tho^ng ba'o");
                Application.Exit();
            }
        }

        private void btnTaoLichThi_Click(object sender, EventArgs e)
        {
            if (frmTaoLichThi == null)
            {
                frmTaoLichThi = new frmTaoLichThi(db);
                frmTaoLichThi.Dock = DockStyle.Fill;
            }
            ChangeFormOnpnMain(frmTaoLichThi);
        }

        private void btnXemLichThiSinhVien_Click(object sender, EventArgs e)
        {
            if (frmLichThiSinhVien == null)
            {
                frmLichThiSinhVien = new frmLichThiSinhVien(db);
                frmLichThiSinhVien.Dock = DockStyle.Fill;
            }
            ChangeFormOnpnMain(frmLichThiSinhVien);
        }

        private void ChangeFormOnpnMain(UserControl frm)
        {
            if (pnMain.Controls.Contains(frm))
                return;
            foreach (Control c in pnMain.Controls)
            {
                pnMain.Controls.Remove(c);
            }
            pnMain.Controls.Add(frm);
        }

        private void btnFullConfig_Click(object sender, EventArgs e)
        {
            if (ucFullConfig == null)
            {
                ucFullConfig = new ucFullConfig();
                ucFullConfig.Dock = DockStyle.Fill;
            }
            ChangeFormOnpnMain(ucFullConfig);
        }
    }
}