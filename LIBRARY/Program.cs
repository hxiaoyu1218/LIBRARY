using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarySystemBackEnd;

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

            //Application.Run(new UserBookDetailForm(null, 0));

            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            loginForm.Dispose();

            if ((int)loginForm.Tag == 1)
            {
                Application.Run(new UserMainForm());

            }
            else if ((int)loginForm.Tag == 2)
            {
                Application.Run(new AdminMainForm());
            }
            ClassBackEnd.StopTime();
            //   Application.Run(new AddBookForm());
        }
    }
}
