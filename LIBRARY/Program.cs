using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            // Application.Run(new InfoBox(5));
            //Application.Run(new UserForm());
            //Application.Run(new PasswordChangeForm());
            //Application.Run(new ReturnForm());
            //Application.Run(new BookReturnForm());
        }
    }
}
