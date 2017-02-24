using System.Windows.Forms;
namespace ExamSchedule.GUI
{
    partial class frmLichThiSinhVienCuaKhoa
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoCaThi = new System.Windows.Forms.TextBox();
            this.dateTimeNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoNgayThi = new System.Windows.Forms.TextBox();
            this.btnShedule = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbStuCourse = new System.Windows.Forms.Label();
            this.groupImportData = new System.Windows.Forms.GroupBox();
            this.btnStudent = new System.Windows.Forms.Button();
            this.lbRoom = new System.Windows.Forms.Label();
            this.btnCourse = new System.Windows.Forms.Button();
            this.lbCourse = new System.Windows.Forms.Label();
            this.btnRoom = new System.Windows.Forms.Button();
            this.lbStudent = new System.Windows.Forms.Label();
            this.btnStuCourse = new System.Windows.Forms.Button();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnLichThi = new System.Windows.Forms.Panel();
            this.pnNhapLieu = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupImportData.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.pnNhapLieu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ngày bắt đầu";
            // 
            // txtSoCaThi
            // 
            this.txtSoCaThi.AllowDrop = true;
            this.txtSoCaThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoCaThi.Location = new System.Drawing.Point(114, 103);
            this.txtSoCaThi.Name = "txtSoCaThi";
            this.txtSoCaThi.Size = new System.Drawing.Size(324, 29);
            this.txtSoCaThi.TabIndex = 27;
            // 
            // dateTimeNgayBatDau
            // 
            this.dateTimeNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dateTimeNgayBatDau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimeNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgayBatDau.Location = new System.Drawing.Point(114, 3);
            this.dateTimeNgayBatDau.Name = "dateTimeNgayBatDau";
            this.dateTimeNgayBatDau.Size = new System.Drawing.Size(324, 29);
            this.dateTimeNgayBatDau.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 22);
            this.label7.TabIndex = 26;
            this.label7.Text = "Số ca thi";
            // 
            // txtSoNgayThi
            // 
            this.txtSoNgayThi.AllowDrop = true;
            this.txtSoNgayThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoNgayThi.Location = new System.Drawing.Point(114, 53);
            this.txtSoNgayThi.Name = "txtSoNgayThi";
            this.txtSoNgayThi.Size = new System.Drawing.Size(324, 29);
            this.txtSoNgayThi.TabIndex = 25;
            // 
            // btnShedule
            // 
            this.btnShedule.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnShedule.Location = new System.Drawing.Point(3, 226);
            this.btnShedule.Name = "btnShedule";
            this.btnShedule.Size = new System.Drawing.Size(407, 32);
            this.btnShedule.TabIndex = 18;
            this.btnShedule.Text = "Tạo lịch thi";
            this.btnShedule.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtSoCaThi, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.dateTimeNgayBatDau, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtSoNgayThi, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(407, 193);
            this.tableLayoutPanel2.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 24;
            this.label6.Text = "Số ngày thi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShedule);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.groupBox1.Location = new System.Drawing.Point(421, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 261);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tạo lịch thi";
            // 
            // lbStuCourse
            // 
            this.lbStuCourse.AutoSize = true;
            this.lbStuCourse.Location = new System.Drawing.Point(101, 217);
            this.lbStuCourse.Name = "lbStuCourse";
            this.lbStuCourse.Size = new System.Drawing.Size(286, 22);
            this.lbStuCourse.TabIndex = 29;
            this.lbStuCourse.Text = "Đường dẫn danh sách đăng ký môn học";
            // 
            // groupImportData
            // 
            this.groupImportData.Controls.Add(this.lbStuCourse);
            this.groupImportData.Controls.Add(this.btnStudent);
            this.groupImportData.Controls.Add(this.lbRoom);
            this.groupImportData.Controls.Add(this.btnCourse);
            this.groupImportData.Controls.Add(this.lbCourse);
            this.groupImportData.Controls.Add(this.btnRoom);
            this.groupImportData.Controls.Add(this.lbStudent);
            this.groupImportData.Controls.Add(this.btnStuCourse);
            this.groupImportData.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupImportData.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.groupImportData.Location = new System.Drawing.Point(3, 3);
            this.groupImportData.Name = "groupImportData";
            this.groupImportData.Size = new System.Drawing.Size(412, 261);
            this.groupImportData.TabIndex = 29;
            this.groupImportData.TabStop = false;
            this.groupImportData.Text = "Nhập dữ liệu";
            // 
            // btnStudent
            // 
            this.btnStudent.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.Location = new System.Drawing.Point(16, 42);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(75, 30);
            this.btnStudent.TabIndex = 1;
            this.btnStudent.Text = "Chọn";
            this.btnStudent.UseVisualStyleBackColor = true;
            // 
            // lbRoom
            // 
            this.lbRoom.AutoSize = true;
            this.lbRoom.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.lbRoom.Location = new System.Drawing.Point(101, 161);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(214, 22);
            this.lbRoom.TabIndex = 28;
            this.lbRoom.Text = "Đường dẫn danh sách phòng ";
            // 
            // btnCourse
            // 
            this.btnCourse.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.btnCourse.Location = new System.Drawing.Point(16, 101);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(75, 30);
            this.btnCourse.TabIndex = 10;
            this.btnCourse.Text = "Chọn";
            this.btnCourse.UseVisualStyleBackColor = true;
            // 
            // lbCourse
            // 
            this.lbCourse.AutoSize = true;
            this.lbCourse.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.lbCourse.Location = new System.Drawing.Point(101, 104);
            this.lbCourse.Name = "lbCourse";
            this.lbCourse.Size = new System.Drawing.Size(258, 22);
            this.lbCourse.TabIndex = 27;
            this.lbCourse.Text = "Đường dẫn danh sách môn đăng ký";
            // 
            // btnRoom
            // 
            this.btnRoom.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.btnRoom.Location = new System.Drawing.Point(16, 158);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(75, 30);
            this.btnRoom.TabIndex = 13;
            this.btnRoom.Text = "Chọn";
            this.btnRoom.UseVisualStyleBackColor = true;
            // 
            // lbStudent
            // 
            this.lbStudent.AutoSize = true;
            this.lbStudent.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudent.Location = new System.Drawing.Point(101, 45);
            this.lbStudent.Name = "lbStudent";
            this.lbStudent.Size = new System.Drawing.Size(226, 22);
            this.lbStudent.TabIndex = 26;
            this.lbStudent.Text = "Đường dẫn danh sách sinh viên";
            // 
            // btnStuCourse
            // 
            this.btnStuCourse.Location = new System.Drawing.Point(16, 213);
            this.btnStuCourse.Name = "btnStuCourse";
            this.btnStuCourse.Size = new System.Drawing.Size(75, 30);
            this.btnStuCourse.TabIndex = 3;
            this.btnStuCourse.Text = "Chọn";
            this.btnStuCourse.UseVisualStyleBackColor = true;
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.pnLichThi);
            this.pnMain.Controls.Add(this.pnNhapLieu);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(837, 329);
            this.pnMain.TabIndex = 36;
            // 
            // pnLichThi
            // 
            this.pnLichThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLichThi.Location = new System.Drawing.Point(0, 267);
            this.pnLichThi.Name = "pnLichThi";
            this.pnLichThi.Size = new System.Drawing.Size(837, 62);
            this.pnLichThi.TabIndex = 30;
            // 
            // pnNhapLieu
            // 
            this.pnNhapLieu.Controls.Add(this.tableLayoutPanel1);
            this.pnNhapLieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnNhapLieu.Location = new System.Drawing.Point(0, 0);
            this.pnNhapLieu.Name = "pnNhapLieu";
            this.pnNhapLieu.Size = new System.Drawing.Size(837, 267);
            this.pnNhapLieu.TabIndex = 31;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupImportData, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(837, 267);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // frmLichThiSinhVienCuaKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnMain);
            this.Name = "frmLichThiSinhVienCuaKhoa";
            this.Size = new System.Drawing.Size(837, 329);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupImportData.ResumeLayout(false);
            this.groupImportData.PerformLayout();
            this.pnMain.ResumeLayout(false);
            this.pnNhapLieu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoCaThi;
        private System.Windows.Forms.DateTimePicker dateTimeNgayBatDau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoNgayThi;
        private System.Windows.Forms.Button btnShedule;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbStuCourse;
        private System.Windows.Forms.GroupBox groupImportData;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Label lbRoom;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Label lbCourse;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Label lbStudent;
        private System.Windows.Forms.Button btnStuCourse;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnLichThi;
        private System.Windows.Forms.Panel pnNhapLieu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
