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
        private Point offset;
        public AdminMainForm()
        {
            ClassBackEnd.StartTime();
            InitializeComponent();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            TimeWorker.RunWorkerAsync();
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
            else if (v == 2)
            {
                MainPanel.Controls.Clear();
                BookMangeForm bookManageForm = new BookMangeForm(this);
                bookManageForm.TopLevel = false;
                bookManageForm.Dock = DockStyle.Fill;
                MainPanel.Controls.Add(bookManageForm);
                bookManageForm.Show();
            }
            else if (v == 3)
            {
                this.MainPanel.Controls.Clear();
                UserManageForm userManageForm = new UserManageForm(this);
                userManageForm.TopLevel = false;
                userManageForm.Dock = DockStyle.Fill;
                this.MainPanel.Controls.Add(userManageForm);
                userManageForm.Show();
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

        private void TimeTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                offset = new Point(e.X, e.Y);
            }
        }

        private void TimeTextBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Location = new Point(Location.X + e.X - offset.X, Location.Y + e.Y - offset.Y);
            }
        }

        private void UserChangeButton_MouseMove(object sender, MouseEventArgs e)
        {
            RemindLabel.Show();
        }

        private void UserChangeButton_MouseLeave(object sender, EventArgs e)
        {
            RemindLabel.Hide();
        }

        private void UserChangeButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
