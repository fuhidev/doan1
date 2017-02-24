namespace ExamSchedule.GUI

{
    partial class ucFullConfig
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
            this.groupImportData = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStudent = new System.Windows.Forms.Button();
            this.lbStudent = new System.Windows.Forms.Label();
            this.btnCourse = new System.Windows.Forms.Button();
            this.lbCourse = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRoom = new System.Windows.Forms.Button();
            this.lbRoom = new System.Windows.Forms.Label();
            this.btnStuCourse = new System.Windows.Forms.Button();
            this.lbStuCourse = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.lbSchedule = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.groupConfigDesignApp = new System.Windows.Forms.GroupBox();
            this.groupImportData.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupImportData
            // 
            this.groupImportData.BackColor = System.Drawing.Color.PowderBlue;
            this.groupImportData.Controls.Add(this.tableLayoutPanel1);
            this.groupImportData.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupImportData.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupImportData.Location = new System.Drawing.Point(0, 0);
            this.groupImportData.Name = "groupImportData";
            this.groupImportData.Size = new System.Drawing.Size(852, 202);
            this.groupImportData.TabIndex = 30;
            this.groupImportData.TabStop = false;
            this.groupImportData.Text = "Cấu hình dữ liệu";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(846, 175);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.06235F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.93765F));
            this.tableLayoutPanel2.Controls.Add(this.btnStudent, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbStudent, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCourse, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbCourse, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(417, 90);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnStudent
            // 
            this.btnStudent.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.Location = new System.Drawing.Point(3, 3);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(75, 30);
            this.btnStudent.TabIndex = 1;
            this.btnStudent.Text = "Chọn";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnDataConfig_Click);
            // 
            // lbStudent
            // 
            this.lbStudent.AutoSize = true;
            this.lbStudent.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudent.Location = new System.Drawing.Point(94, 0);
            this.lbStudent.Name = "lbStudent";
            this.lbStudent.Size = new System.Drawing.Size(218, 20);
            this.lbStudent.TabIndex = 26;
            this.lbStudent.Text = "Đường dẫn danh sách sinh viên";
            // 
            // btnCourse
            // 
            this.btnCourse.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.btnCourse.Location = new System.Drawing.Point(3, 48);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(75, 30);
            this.btnCourse.TabIndex = 10;
            this.btnCourse.Text = "Chọn";
            this.btnCourse.UseVisualStyleBackColor = true;
            this.btnCourse.Click += new System.EventHandler(this.btnDataConfig_Click);
            // 
            // lbCourse
            // 
            this.lbCourse.AutoSize = true;
            this.lbCourse.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCourse.Location = new System.Drawing.Point(94, 45);
            this.lbCourse.Name = "lbCourse";
            this.lbCourse.Size = new System.Drawing.Size(244, 20);
            this.lbCourse.TabIndex = 27;
            this.lbCourse.Text = "Đường dẫn danh sách môn đăng ký";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.06235F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.93765F));
            this.tableLayoutPanel3.Controls.Add(this.btnRoom, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbRoom, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnStuCourse, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbStuCourse, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(426, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(417, 90);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btnRoom
            // 
            this.btnRoom.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.btnRoom.Location = new System.Drawing.Point(3, 3);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(75, 30);
            this.btnRoom.TabIndex = 13;
            this.btnRoom.Text = "Chọn";
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.btnDataConfig_Click);
            // 
            // lbRoom
            // 
            this.lbRoom.AutoSize = true;
            this.lbRoom.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoom.Location = new System.Drawing.Point(94, 0);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(205, 20);
            this.lbRoom.TabIndex = 28;
            this.lbRoom.Text = "Đường dẫn danh sách phòng ";
            // 
            // btnStuCourse
            // 
            this.btnStuCourse.Location = new System.Drawing.Point(3, 48);
            this.btnStuCourse.Name = "btnStuCourse";
            this.btnStuCourse.Size = new System.Drawing.Size(75, 30);
            this.btnStuCourse.TabIndex = 3;
            this.btnStuCourse.Text = "Chọn";
            this.btnStuCourse.UseVisualStyleBackColor = true;
            this.btnStuCourse.Click += new System.EventHandler(this.btnDataConfig_Click);
            // 
            // lbStuCourse
            // 
            this.lbStuCourse.AutoSize = true;
            this.lbStuCourse.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStuCourse.Location = new System.Drawing.Point(94, 45);
            this.lbStuCourse.Name = "lbStuCourse";
            this.lbStuCourse.Size = new System.Drawing.Size(272, 20);
            this.lbStuCourse.TabIndex = 29;
            this.lbStuCourse.Text = "Đường dẫn danh sách đăng ký môn học";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.82254F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.17746F));
            this.tableLayoutPanel4.Controls.Add(this.btnSchedule, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbSchedule, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 99);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(417, 73);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // btnSchedule
            // 
            this.btnSchedule.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.btnSchedule.Location = new System.Drawing.Point(3, 3);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(75, 30);
            this.btnSchedule.TabIndex = 30;
            this.btnSchedule.Text = "Chọn";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnDataConfig_Click);
            // 
            // lbSchedule
            // 
            this.lbSchedule.AutoSize = true;
            this.lbSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSchedule.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSchedule.Location = new System.Drawing.Point(93, 0);
            this.lbSchedule.Name = "lbSchedule";
            this.lbSchedule.Size = new System.Drawing.Size(321, 73);
            this.lbSchedule.TabIndex = 31;
            this.lbSchedule.Text = "Đường dẫn lịch thi";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.btnSave, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.btnDelete, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnDefault, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(426, 99);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(417, 73);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(3, 39);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(202, 30);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(211, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(203, 30);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xóa cài đặt";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnDefault
            // 
            this.btnDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefault.Location = new System.Drawing.Point(3, 3);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(202, 30);
            this.btnDefault.TabIndex = 0;
            this.btnDefault.Text = "Mặc đinh";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // groupConfigDesignApp
            // 
            this.groupConfigDesignApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupConfigDesignApp.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.groupConfigDesignApp.Location = new System.Drawing.Point(0, 202);
            this.groupConfigDesignApp.Name = "groupConfigDesignApp";
            this.groupConfigDesignApp.Size = new System.Drawing.Size(852, 264);
            this.groupConfigDesignApp.TabIndex = 31;
            this.groupConfigDesignApp.TabStop = false;
            this.groupConfigDesignApp.Text = "Cấu hình giao diện";
            // 
            // ucFullConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupConfigDesignApp);
            this.Controls.Add(this.groupImportData);
            this.Name = "ucFullConfig";
            this.Size = new System.Drawing.Size(852, 466);
            this.Load += new System.EventHandler(this.ucFullConfig_Load);
            this.groupImportData.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupImportData;
        private System.Windows.Forms.Label lbStuCourse;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Label lbRoom;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Label lbCourse;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Label lbStudent;
        private System.Windows.Forms.Button btnStuCourse;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Label lbSchedule;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.GroupBox groupConfigDesignApp;
    }
}
