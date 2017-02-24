namespace ExamSchedule.GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnHeader = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnFullConfig = new System.Windows.Forms.Button();
            this.btnXemLichThiSinhVien = new System.Windows.Forms.Button();
            this.btnTaoLichThi = new System.Windows.Forms.Button();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnHeader.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnLeft.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.MintCream;
            this.pnHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnHeader.Controls.Add(this.tableLayoutPanel1);
            this.pnHeader.Controls.Add(this.panel1);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Padding = new System.Windows.Forms.Padding(10);
            this.pnHeader.Size = new System.Drawing.Size(942, 118);
            this.pnHeader.TabIndex = 32;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(210, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(720, 96);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(75, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 96);
            this.label1.TabIndex = 3;
            this.label1.Text = "HỆ THỐNG SẮP XẾP LỊCH THI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 96);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ExamSchedule.GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.SlateGray;
            this.pnLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnLeft.Controls.Add(this.pnMenu);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 118);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(200, 509);
            this.pnLeft.TabIndex = 33;
            // 
            // pnMenu
            // 
            this.pnMenu.Controls.Add(this.btnFullConfig);
            this.pnMenu.Controls.Add(this.btnXemLichThiSinhVien);
            this.pnMenu.Controls.Add(this.btnTaoLichThi);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(198, 221);
            this.pnMenu.TabIndex = 0;
            // 
            // btnFullConfig
            // 
            this.btnFullConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFullConfig.Location = new System.Drawing.Point(0, 118);
            this.btnFullConfig.Name = "btnFullConfig";
            this.btnFullConfig.Size = new System.Drawing.Size(198, 51);
            this.btnFullConfig.TabIndex = 2;
            this.btnFullConfig.Text = "Cấu hình hệ thống";
            this.btnFullConfig.UseVisualStyleBackColor = true;
            this.btnFullConfig.Click += new System.EventHandler(this.btnFullConfig_Click);
            // 
            // btnXemLichThiSinhVien
            // 
            this.btnXemLichThiSinhVien.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnXemLichThiSinhVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXemLichThiSinhVien.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemLichThiSinhVien.ForeColor = System.Drawing.Color.White;
            this.btnXemLichThiSinhVien.Location = new System.Drawing.Point(0, 60);
            this.btnXemLichThiSinhVien.Name = "btnXemLichThiSinhVien";
            this.btnXemLichThiSinhVien.Size = new System.Drawing.Size(198, 58);
            this.btnXemLichThiSinhVien.TabIndex = 1;
            this.btnXemLichThiSinhVien.Text = "Xem Lịch Thi Sinh Viên";
            this.btnXemLichThiSinhVien.UseVisualStyleBackColor = false;
            this.btnXemLichThiSinhVien.Click += new System.EventHandler(this.btnXemLichThiSinhVien_Click);
            // 
            // btnTaoLichThi
            // 
            this.btnTaoLichThi.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnTaoLichThi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaoLichThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoLichThi.ForeColor = System.Drawing.Color.White;
            this.btnTaoLichThi.Location = new System.Drawing.Point(0, 0);
            this.btnTaoLichThi.Name = "btnTaoLichThi";
            this.btnTaoLichThi.Size = new System.Drawing.Size(198, 60);
            this.btnTaoLichThi.TabIndex = 0;
            this.btnTaoLichThi.Text = "Tạo Lịch Thi";
            this.btnTaoLichThi.UseVisualStyleBackColor = false;
            this.btnTaoLichThi.Click += new System.EventHandler(this.btnTaoLichThi_Click);
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(200, 118);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(742, 509);
            this.pnMain.TabIndex = 34;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 627);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.pnHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(958, 666);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TẠO THỜI KHÓA BIỂU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnHeader.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnLeft.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btnTaoLichThi;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Button btnXemLichThiSinhVien;
        private System.Windows.Forms.Button btnFullConfig;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
    }
}

