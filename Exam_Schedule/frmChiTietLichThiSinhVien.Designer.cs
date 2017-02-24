namespace ExamSchedule.GUI
{
    partial class frmChiTietLichThiSinhVien
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPathExport = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.pnStudentScheduleName = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbStudentName = new System.Windows.Forms.Label();
            this.pnMain = new System.Windows.Forms.Panel();
            this.ucScheduling = new ExamSchedule.GUI.ucScheduling();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnStudentScheduleName.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightBlue;
            this.panel6.Controls.Add(this.tableLayoutPanel2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 690);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(912, 39);
            this.panel6.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.LightBlue;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.txtPathExport, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnSubmit, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnChoose, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(912, 39);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // txtPathExport
            // 
            this.txtPathExport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathExport.Location = new System.Drawing.Point(3, 6);
            this.txtPathExport.Name = "txtPathExport";
            this.txtPathExport.Size = new System.Drawing.Size(632, 26);
            this.txtPathExport.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(777, 6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(132, 25);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Xuất dữ liệu";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChoose.Location = new System.Drawing.Point(641, 6);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(130, 25);
            this.btnChoose.TabIndex = 1;
            this.btnChoose.Text = "Chọn ";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // pnStudentScheduleName
            // 
            this.pnStudentScheduleName.BackColor = System.Drawing.Color.PowderBlue;
            this.pnStudentScheduleName.Controls.Add(this.tableLayoutPanel1);
            this.pnStudentScheduleName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnStudentScheduleName.Location = new System.Drawing.Point(0, 0);
            this.pnStudentScheduleName.Name = "pnStudentScheduleName";
            this.pnStudentScheduleName.Size = new System.Drawing.Size(912, 54);
            this.pnStudentScheduleName.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightBlue;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.lbStudentName, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(912, 51);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lbStudentName
            // 
            this.lbStudentName.AutoSize = true;
            this.lbStudentName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentName.Location = new System.Drawing.Point(276, 5);
            this.lbStudentName.Name = "lbStudentName";
            this.lbStudentName.Size = new System.Drawing.Size(358, 40);
            this.lbStudentName.TabIndex = 1;
            this.lbStudentName.Text = "Hiếu Hồ";
            this.lbStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.ucScheduling);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 54);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(912, 636);
            this.pnMain.TabIndex = 14;
            // 
            // ucScheduling
            // 
            this.ucScheduling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucScheduling.Location = new System.Drawing.Point(0, 0);
            this.ucScheduling.Name = "ucScheduling";
            this.ucScheduling.Schedulings = null;
            this.ucScheduling.Size = new System.Drawing.Size(912, 636);
            this.ucScheduling.TabIndex = 0;
            // 
            // frmChiTietLichThiSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 729);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnStudentScheduleName);
            this.Controls.Add(this.panel6);
            this.Name = "frmChiTietLichThiSinhVien";
            this.Text = "frmChiTietLichThiSinhVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pnStudentScheduleName.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtPathExport;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel pnStudentScheduleName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbStudentName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pnMain;
        private ucScheduling ucScheduling;
    }
}