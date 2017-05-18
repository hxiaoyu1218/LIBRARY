using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarySystemBackEnd;

namespace LIBRARY
{
    public partial class AdminMainForm : DMSkin.Main
    {
        public AdminMainForm()
        {
            ClassBackEnd.StartTime();
            InitializeComponent();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            AdminFunctionForm adminFunctionForm = new AdminFunctionForm(this);
            adminFunctionForm.TopLevel = false;
            adminFunctionForm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(adminFunctionForm);
            adminFunctionForm.Show();
        }

        private void ShutDownButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MinButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            int v = (int)ReturnButton.Tag;
            if (v == 1)
            {
                MainPanel.Controls.Clear();
                AdminFunctionForm adminFunctionForm = new AdminFunctionForm(this);
                adminFunctionForm.TopLevel = false;
                adminFunctionForm.Dock = DockStyle.Fill;
                MainPanel.Controls.Add(adminFunctionForm);
                adminFunctionForm.Show();
            }
        }

        private void TimeWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker myworker = (BackgroundWorker)sender;
            while (true)
            {
                if (myworker.CancellationPending != true)
                {
                    TimeWork.GetLastInputTime();
                    myworker.ReportProgress(1, ClassTime.SystemTime);
                }
                System.Threading.Thread.Sleep(5000);
            }
        }

        private void TimeWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            TimeTextBox.Text = e.UserState.ToString();
        }

    }
}
