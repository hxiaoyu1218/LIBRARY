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

namespace LIBRARY
{
    public partial class AdminMainForm : DMSkin.Main
    {
        private Point offset;

        public AdminMainForm()
        {
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

                PublicVar.userTotalAmount = 0;
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
                AdminBookManageForm bookManageForm = new AdminBookManageForm(this,AdminBookManageForm.lastState,AdminBookManageForm.lastString);
                bookManageForm.TopLevel = false;
                bookManageForm.Dock = DockStyle.Fill;
                MainPanel.Controls.Add(bookManageForm);
                bookManageForm.Show();
            }
            else if (v == 3)
            {
                MainPanel.Controls.Clear();
                AdminUserManageForm userManageForm = new AdminUserManageForm(this);
                userManageForm.TopLevel = false;
                userManageForm.Dock = DockStyle.Fill;
                MainPanel.Controls.Add(userManageForm);
                userManageForm.Show();
            }
            else if (v == 4)
            {
                MainPanel.Controls.Clear();
                AdminUserDetailForm userDetailAdminForm = new AdminUserDetailForm(this, AdminUserDetailForm.UserIndex);
                userDetailAdminForm.TopLevel = false;
                userDetailAdminForm.Dock = DockStyle.Fill;
                MainPanel.Controls.Add(userDetailAdminForm);
                userDetailAdminForm.Show();
            }
        }

        private void TimeWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker myworker = (BackgroundWorker)sender;
            while (true)
            {
                myworker.ReportProgress(1, DateTime.Now);

                System.Threading.Thread.Sleep(1000);
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




        private void UserChangeButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void TitleLabel_DoubleClick(object sender, EventArgs e)
        {
            ProgramAboutBox abb = new ProgramAboutBox();
            abb.ShowDialog();
            abb.Dispose();
        }

        private void TitleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                offset = new Point(e.X, e.Y);
            }
        }

        private void TitleLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Location = new Point(Location.X + e.X - offset.X, Location.Y + e.Y - offset.Y);
            }
        }
    }
}
