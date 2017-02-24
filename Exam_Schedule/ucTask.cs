using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExamSchedule.GUI
{
    public partial class ucTask : UserControl
    {
        public ucTask(String room,String course,DateTime time,Color color = default(Color))
        {
            InitializeComponent();
            this.lbRoom.Text = room;
            this.lbCourse.Text = course;
            this.lbTime.Text = time.ToShortDateString();
            this.layout.BackColor = color;
        }
        public ucTask()
        {
            InitializeComponent();
        }
    }
}
