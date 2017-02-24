using System.Threading;
using System.Windows.Forms;

namespace ExamSchedule.GUI.WindowsWait
{
    public class SplashScreenManager
    {
        private static Form form;

        public static void CloseWaitForm()
        {
            form.Close();
        }

        public static void ShowWaitForm()
        {
            form = new SplashScreen();
            var t = new Thread(ShowForm);
            t.Start();
        }

        public static void ShowWaitForm(Form f)
        {
            form = f;
            var t = new Thread(ShowForm);
            t.Start();
        }

        private static void ShowForm()
        {
            form.ShowDialog();
        }
    }
}