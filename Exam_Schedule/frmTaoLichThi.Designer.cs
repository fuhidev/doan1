using System.Drawing;
namespace ExamSchedule.GUI
{
    partial class frmTaoLichThi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnLichThi = new System.Windows.Forms.Panel();
            this.dtStuCourseGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtPathExport = new System.Windows.Forms.TextBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnNhapLieu = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShedule = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoCaThi = new System.Windows.Forms.TextBox();
            this.dateTimeNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnMain.SuspendLayout();
            this.pnLichThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtStuCourseGridView)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnNhapLieu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.pnLichThi);
            this.pnMain.Controls.Add(this.pnNhapLieu);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(905, 495);
            this.pnMain.TabIndex = 35;
            // 
            // pnLichThi
            // 
            this.pnLichThi.Controls.Add(this.dtStuCourseGridView);
            this.pnLichThi.Controls.Add(this.panel6);
            this.pnLichThi.Controls.Add(this.panel2);
            this.pnLichThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLichThi.Location = new System.Drawing.Point(0, 184);
            this.pnLichThi.Name = "pnLichThi";
            this.pnLichThi.Size = new System.Drawing.Size(905, 311);
            this.pnLichThi.TabIndex = 30;
            // 
            // dtStuCourseGridView
            // 
            this.dtStuCourseGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtStuCourseGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtStuCourseGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtStuCourseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtStuCourseGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CourseName,
            this.Group,
            this.Date,
            this.Exam,
            this.Room});
            this.dtStuCourseGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtStuCourseGridView.Location = new System.Drawing.Point(0, 46);
            this.dtStuCourseGridView.Name = "dtStuCourseGridView";
            this.dtStuCourseGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtStuCourseGridView.Size = new System.Drawing.Size(905, 204);
            this.dtStuCourseGridView.TabIndex = 7;
            // 
            // ID
            // 
            this.ID.HeaderText = "Mã Môn Học";
            this.ID.Name = "ID";
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "Tên Môn Học";
            this.CourseName.Name = "CourseName";
            // 
            // Group
            // 
            this.Group.HeaderText = "Nhóm Học";
            this.Group.Name = "Group";
            // 
            // Date
            // 
            this.Date.HeaderText = "Ngày Thi";
            this.Date.Name = "Date";
            // 
            // Exam
            // 
            this.Exam.HeaderText = "Ca Thi";
            this.Exam.Name = "Exam";
            // 
            // Room
            // 
            this.Room.HeaderText = "Phòng Thi";
            this.Room.Name = "Room";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightBlue;
            this.panel6.Controls.Add(this.btnSubmit);
            this.panel6.Controls.Add(this.txtPathExport);
            this.panel6.Controls.Add(this.btnChoose);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 250);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(905, 61);
            this.panel6.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(745, 12);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(151, 30);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Xuất dữ liệu";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtPathExport
            // 
            this.txtPathExport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathExport.Location = new System.Drawing.Point(21, 16);
            this.txtPathExport.Name = "txtPathExport";
            this.txtPathExport.Size = new System.Drawing.Size(604, 26);
            this.txtPathExport.TabIndex = 2;
            // 
            // btnChoose
            // 
            this.btnChoose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoose.Location = new System.Drawing.Point(631, 12);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(108, 30);
            this.btnChoose.TabIndex = 1;
            this.btnChoose.Text = "Chọn ";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(905, 46);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 37);
            this.label2.TabIndex = 31;
            this.label2.Text = "LỊCH THI";
            // 
            // pnNhapLieu
            // 
            this.pnNhapLieu.Controls.Add(this.groupBox1);
            this.pnNhapLieu.Controls.Add(this.tableLayoutPanel1);
            this.pnNhapLieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnNhapLieu.Location = new System.Drawing.Point(0, 0);
            this.pnNhapLieu.Name = "pnNhapLieu";
            this.pnNhapLieu.Size = new System.Drawing.Size(905, 184);
            this.pnNhapLieu.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox1.Controls.Add(this.btnShedule);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(905, 184);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tạo lịch thi";
            // 
            // btnShedule
            // 
            this.btnShedule.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnShedule.Location = new System.Drawing.Point(3, 149);
            this.btnShedule.Name = "btnShedule";
            this.btnShedule.Size = new System.Drawing.Size(899, 32);
            this.btnShedule.TabIndex = 18;
            this.btnShedule.Text = "Tạo lịch thi";
            this.btnShedule.UseVisualStyleBackColor = true;
            this.btnShedule.Click += new System.EventHandler(this.btnShedule_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtSoCaThi, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dateTimeNgayBatDau, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(899, 105);
            this.tableLayoutPanel2.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ngày bắt đầu";
            // 
            // txtSoCaThi
            // 
            this.txtSoCaThi.AllowDrop = true;
            this.txtSoCaThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoCaThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoCaThi.Location = new System.Drawing.Point(112, 55);
            this.txtSoCaThi.Name = "txtSoCaThi";
            this.txtSoCaThi.Size = new System.Drawing.Size(791, 26);
            this.txtSoCaThi.TabIndex = 27;
            // 
            // dateTimeNgayBatDau
            // 
            this.dateTimeNgayBatDau.CustomFormat = "";
            this.dateTimeNgayBatDau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimeNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNgayBatDau.Location = new System.Drawing.Point(112, 3);
            this.dateTimeNgayBatDau.Name = "dateTimeNgayBatDau";
            this.dateTimeNgayBatDau.Size = new System.Drawing.Size(791, 26);
            this.dateTimeNgayBatDau.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Số ca thi";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(905, 90);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // frmTaoLichThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnMain);
            this.Name = "frmTaoLichThi";
            this.Size = new System.Drawing.Size(905, 495);
            this.Load += new System.EventHandler(this.frmTaoLichThi_Load);
            this.pnMain.ResumeLayout(false);
            this.pnLichThi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtStuCourseGridView)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnNhapLieu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnLichThi;
        private System.Windows.Forms.DataGridView dtStuCourseGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnNhapLieu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShedule;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoCaThi;
        private System.Windows.Forms.DateTimePicker dateTimeNgayBatDau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtPathExport;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnSubmit;
    }
}
