using System.Threading;
using System.Windows.Forms;

namespace ExamSchedule.GUI.WindowsWait
{
    public class WaitFormManager : IWaitFormManager
    {
        private static Form form;
        private static Thread t;
        public static void CloseWaitForm()
        {
            form.Close();
        }

        public static void ShowWaitForm()
        {
            var t = new Thread(ShowForm);
            t.Start();
        }

        

        public static void ShowWaitForm(string context)
        {
            form = new WaitForm(context);
            t = new Thread(ShowForm);
            t.Start();
        }

        private static void ShowForm()
        {
            form.ShowDialog();
        }
    }
}