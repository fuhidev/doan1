using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExamSchedule.Model;
using ExamSchedule.GUI.Const;

namespace ExamSchedule.GUI
{
    public partial class ucScheduling : UserControl
    {
        public ucScheduling()
        {
            InitializeComponent();
            flows = new FlowLayoutPanel[table.RowCount, table.ColumnCount];
            for (int r = 1; r < table.RowCount; r++)
                for (int c = 1; c < table.ColumnCount; c++)
                {
                    FlowLayoutPanel flow = new FlowLayoutPanel();
                    flow.FlowDirection = FlowDirection.TopDown;
                    flow.Dock = DockStyle.Fill;
                    flow.Name = r + " " + c;
                    flow.AutoScroll = true;
                    flow.Resize += flow_Resize;
                    this.table.Controls.Add(flow,c,r);
                    this.flows[r-1, c-1] = flow;
                }

        }

        void flow_Resize(object sender, EventArgs e)
        {
            var flow = sender as FlowLayoutPanel;
            for (int r = 0; r < flows.GetLength(0); r++)
                for (int c = 0; c < flows.GetLength(1); c++)
                {
                    if (flow == flows[r, c])
                    {
                        foreach (ucTask uc in flow.Controls)
                        {
                            uc.Width = (int)(flow.Width * (2.0f / 3.0f));
                        }
                        return;
                    }
                }
        }
        private FlowLayoutPanel[,] flows;
        private Color[] colors = GUIConstant.ColorsTask;
        public List<Scheduling> Schedulings { get; set; }
        private List<ucTask> Tasks = new List<ucTask>();
        private Random rd = new Random();
        public void Update()
        {
            Tasks.ForEach(f =>
            {
                this.table.Controls.Remove(f);
            });
            Tasks.Clear();
            Schedulings.ForEach(s =>
            {
                var row = s.Exam ;
                var col = FindColumn(s);
                var uc = new ucTask(s.Room.ID, s.Course.Name, s.DateExam, colors[rd.Next(colors.Length)]);
                Tasks.Add(uc);
                var flow = this.flows[row-1, col-1];
                flow.Controls.Add(uc);
            });
        }

        private int FindColumn(Scheduling s)
        {
            var col = 0;
            switch (s.DateExam.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    col = 1;
                    break;
                case DayOfWeek.Tuesday:
                    col = 2;
                    break;
                case DayOfWeek.Wednesday:
                    col = 3;
                    break;
                case DayOfWeek.Thursday:
                    col = 4;
                    break;
                case DayOfWeek.Friday:
                    col = 5;
                    break;
                case DayOfWeek.Saturday:
                    col = 6;
                    break;
                case DayOfWeek.Sunday:
                    col = 7;
                    break;
            }
            return col;
        }

    }
}
