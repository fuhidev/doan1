using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ExamSchedule.BusinessDatabase;
using ExamSchedule.Model;

namespace ExamSchedule.GUI
{
    public partial class frmLichThiSinhVien : UserControl
    {
        public readonly string TEXT_SEARCH = "Nhập mã số hoặc họ tên sinh viên";
        private readonly DataProvider db;

        public frmLichThiSinhVien()
        {
            InitializeComponent();
        }

        public frmLichThiSinhVien(DataProvider db)
        {
            InitializeComponent();
            if (db != null)
                this.db = db;
        }

        private List<Student> SearchStudent(string textSearch)
        {
            textSearch = textSearch.ToUpper();
            var result = from std in db.GetListStudent()
                where
                    std.ID.StartsWith(textSearch) || std.Name.ToUpper().StartsWith(textSearch) ||
                    std.ID.EndsWith(textSearch) || std.Name.ToUpper().EndsWith(textSearch)
                select std;
            return result.ToList();
        }

        private void frmLichThiSinhVien_Load(object sender, EventArgs e)
        {
            FormServices.ChangeLabelSkin(this);
            FormServices.ChangeButtonSkin(this);
            txtSearch.Text = TEXT_SEARCH;
            UpdateListStudent();
            
        }

        private void UpdateListStudent()
        {
            var lq = from std in db.GetListStudent()
                select std;
            dataGridViewListStudent.DataSource = lq.ToList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var ListStudent = SearchStudent(txtSearch.Text);
            dataGridViewListStudent.DataSource = ListStudent;
        }

        //}

        private void dataGridViewListStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dataGridViewListStudent.CurrentRow.Cells[0].Value.ToString();
            new frmChiTietLichThiSinhVien(dataGridViewListStudent.CurrentRow.Cells[1].Value.ToString(),
                db.GetSchedulingByStudentID(id)).ShowDialog();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSearch.Text.Equals(TEXT_SEARCH))
                txtSearch.Clear();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(TEXT_SEARCH))
            {
                txtSearch.Text = "";
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSearch.Text == "")
                txtSearch.Text = TEXT_SEARCH;
        }
       
    }
}