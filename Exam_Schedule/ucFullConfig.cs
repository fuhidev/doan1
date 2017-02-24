using System;
using System.Windows.Forms;

namespace ExamSchedule.GUI
{
    public partial class ucFullConfig : UserControl
    {
        public ucFullConfig()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var config = new ConfigService();
            config.pathStudent = lbStudent.Text;
            config.pathRoom = lbRoom.Text;
            config.pathRegister = lbStuCourse.Text;
            config.pathCourse = lbCourse.Text;
            config.Save();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
        }

        private void btnDataConfig_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            Label label;
            if (btn == btnCourse)
            {
                label = lbCourse;
            }
            else if (btn == btnRoom)
            {
                label = lbRoom;
            }
            else if (btn == btnStuCourse)
            {
                label = lbStuCourse;
            }
            else if (btn == btnStudent)
            {
                label = lbStudent;
            }
            else if (btn == btnSchedule)
            {
                label = lbSchedule;
            }
            else
            {
                throw new NotSupportedException();
            }
            SetTextLabel(label);
        }

        private void SetTextLabel(Label lb)
        {
            var file = new OpenFileDialog();
            if (file.ShowDialog() != DialogResult.Cancel)
            {
                lb.Text = file.FileName;
            }
        }

        private void ucFullConfig_Load(object sender, EventArgs e)
        {
            FormServices.ChangeButtonSkin(this);
            FormServices.ChangeLabelSkin(this);
        }
    }
}