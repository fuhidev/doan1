using ExamSchedule.GUI.Const;
using ExamSchedule.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace ExamSchedule.GUI
{
    public static class FormServices
    {
        public static SaveFileDialog save;

        public static IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                .Concat(controls)
                .Where(c => c.GetType() == type);
        }

        public static void ChangeLabelSkin(Control control)
        {
            var ctrls = GetAll(control, typeof(Button));
            foreach (Button bt in ctrls)
            {
                bt.Font = GUIConstant.FontMain;
                bt.ForeColor = GUIConstant.ColorForeButton;
                bt.BackColor = GUIConstant.ColorBackButton;
                bt.MouseHover += MouseHover;
                bt.MouseLeave += MouseLeave;
                RemoveBorderButton(bt);
            }
        }

        public static void ChangeButtonSkin(Control control)
        {
            var ctrls = GetAll(control, typeof(Button));
            foreach (Button bt in ctrls)
            {
                bt.Font = GUIConstant.FontMain;
                bt.ForeColor = GUIConstant.ColorForeButton;
                bt.BackColor = GUIConstant.ColorBackButton;
                bt.MouseHover += MouseHover;
                bt.MouseLeave += MouseLeave;
                RemoveBorderButton(bt);
            }
        }

        private static void MouseHover(object sender, EventArgs e)
        {
            ((Button) sender).BackColor = GUIConstant.ColorBackHoverButton;
            ((Button) sender).ForeColor = GUIConstant.ColorForeHoverButton;
        }

        private static void MouseLeave(object sender, EventArgs e)
        {
            ((Button) sender).BackColor = GUIConstant.ColorBackLeaveButton;
            ((Button) sender).ForeColor = GUIConstant.ColorForeLeaveButton;
        }

        private static void RemoveBorderButton(Button button)
        {
            button.TabStop = false;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
        }

        public static void SaveFile(TextBox fileName, Button btnSubmit)
        {
            save = new SaveFileDialog();
            save.InitialDirectory = "C:";
            save.Title = "Save as Excel File";
            save.FileName = "";
            save.Filter = @"Excel Files(.xls)|*.xls|Excel Files(.xlsx)|*.xlsx| Excel Files(*.xlsm)|*.xlsm";
            if (save.ShowDialog() == DialogResult.OK)
            {
                fileName.Text = save.FileName;
                btnSubmit.Enabled = true;
            }
        }

        public static void ExportToExcel(DataGridView datagridView)
        {
            var ExcelApp = new Application();
            ExcelApp.Application.Workbooks.Add(Type.Missing);
            ExcelApp.Columns.ColumnWidth = 25;
            for (var i = 1; i < datagridView.Columns.Count + 1; i++)
            {
                ExcelApp.Cells[1, i] = datagridView.Columns[i - 1].HeaderText;
            }
            for (var i = 0; i < datagridView.Rows.Count; i++)
            {
                for (var j = 0; j < datagridView.Columns.Count; j++)
                {
                    if (datagridView.Rows[i].Cells[j].Value != null)
                        ExcelApp.Cells[i + 2, j + 1] = datagridView.Rows[i].Cells[j].Value.ToString();
                }
            }
            ExcelApp.ActiveWorkbook.SaveCopyAs(save.FileName);
            ExcelApp.ActiveWorkbook.Saved = true;
            ExcelApp.Quit();
        }
        public static void ExportToExcelScheduling(List<Scheduling> schedulings)
        {
            var ExcelApp = new Application();
            ExcelApp.Application.Workbooks.Add(Type.Missing);
            ExcelApp.Columns.ColumnWidth = 25;
            ExcelApp.Cells[1, 1] = "Mã môn học";
            ExcelApp.Cells[1, 2] = "Tên môn học";
            ExcelApp.Cells[1, 3] = "Ngày thi";
            ExcelApp.Cells[1, 4] = "Ca thi";

            for (var i = 0; i < schedulings.Count; i++)
            {
                var sc = schedulings[i];
                ExcelApp.Cells[i + 2, 1] = sc.Course.ID;
                ExcelApp.Cells[i + 2, 2] = sc.Course.Name;
                ExcelApp.Cells[i + 2, 3] = sc.DateExam.ToShortDateString();
                ExcelApp.Cells[i + 2, 4] = sc.Exam;
            }
            ExcelApp.ActiveWorkbook.SaveCopyAs(save.FileName);
            ExcelApp.ActiveWorkbook.Saved = true;
            ExcelApp.Quit();
        }
    }
}