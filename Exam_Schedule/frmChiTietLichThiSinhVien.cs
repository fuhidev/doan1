using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamSchedule.Model;

namespace ExamSchedule.GUI
{
    public partial class frmChiTietLichThiSinhVien : Form
    {
        private List<Scheduling> schedulings;
        public frmChiTietLichThiSinhVien(String studentName,List<Scheduling> schedulings )
        {
            InitializeComponent();
            FormServices.ChangeButtonSkin(this);
            FormServices.ChangeLabelSkin(this);
            this.ucScheduling.AutoScrollMinSize = new Size(0, 1280);
            this.lbStudentName.Text = studentName;
            this.ucScheduling.Schedulings = schedulings;
            this.schedulings = schedulings;
            this.ucScheduling.Update();
        }
        private void btnChoose_Click(object sender, EventArgs e)
        {
            FormServices.SaveFile(txtPathExport, btnSubmit);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            FormServices.ExportToExcelScheduling(schedulings);
            btnSubmit.Enabled = false;
        }

    }
}
