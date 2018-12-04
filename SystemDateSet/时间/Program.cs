using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 时间
{
    static class Program
    {
        private static System.Threading.Mutex mutex;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            int i = 0;
            if (args.Count() > 0 && int.TryParse(args[0],out i))
            {
                Form1.SetLocalDateTime(DateTime.Now.AddDays(int.Parse(args[0])));
                Application.Exit();
            }
            else
            {
                mutex = new System.Threading.Mutex(true, "OnlyRunTimer");
                if (mutex.WaitOne(0, false))
                {
                    Application.Run(new Form1());
                }
                else
                {
                    MessageBox.Show("程序已经在运行！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
            }
        }
    }
}
