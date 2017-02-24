using System;
using System.Windows.Forms;

namespace ExamSchedule.GUI.WindowsWait
{
    public partial class WaitForm : Form
    {
        private WaitForm()
        {
            InitializeComponent();
        }

        public WaitForm(string context)
        {
            InitializeComponent();
            lbContext.Text = context;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}