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
    public partial class UserMainForm : DMSkin.Main
    {
		private Point offset;

		public UserMainForm()
        {
            ClassBackEnd.StartTime();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TimeWorker.RunWorkerAsync();
            MainPanel.Controls.Clear();
            UserSearchForm searchForm = new UserSearchForm(this);
            searchForm.TopLevel = false;
            searchForm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(searchForm);
            searchForm.Show();
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
            if (ReturnButton.Tag != null)
            {
                if ((int)ReturnButton.Tag == 1)
                {
                    MainPanel.Controls.Clear();
                    UserSearchForm searchForm = new UserSearchForm(this);
                    searchForm.TopLevel = false;
                    searchForm.Dock = DockStyle.Fill;
                    MainPanel.Controls.Add(searchForm);
                    searchForm.Show();
                    ReturnButton.Tag = null;
                }
                else if ((int)ReturnButton.Tag == 2)
                {
                    MainPanel.Controls.Clear();
                    UserSearchResultForm searchResultForm = new UserSearchResultForm(this, 0, "");
                    searchResultForm.TopLevel = false;
                    searchResultForm.Dock = DockStyle.Fill;
                    MainPanel.Controls.Add(searchResultForm);
                    searchResultForm.Tag = false;
                    searchResultForm.Show();
                    ReturnButton.Tag = 1;
                }
                else if ((int)ReturnButton.Tag == 3)
                {
                    MainPanel.Controls.Clear();
                    UserForm userForm = new UserForm(this);
                    userForm.TopLevel = false;
                    userForm.Dock = DockStyle.Fill;
                    MainPanel.Controls.Add(userForm);
                    userForm.Show();
                }
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
                System.Threading.Thread.Sleep(1000);
            }
        }

        private void TimeWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            TimeTextBox.Text = e.UserState.ToString();
        }

		private void UserChangeButton_Click(object sender, EventArgs e)
		{
			Application.Restart();
		}

		private void TimeTextBox_MouseDown(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Left)
			{
				offset = new Point(e.X, e.Y);
			}
		}

		private void TimeTextBox_MouseMove(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Left)
			{
				Location = new Point(Location.X + e.X - offset.X, Location.Y + e.Y - offset.Y);
			}
		}

		private void TitleLabel_DoubleClick(object sender, EventArgs e)
		{
			ProgramAboutBox abb = new ProgramAboutBox();
			abb.ShowDialog();
			abb.Dispose();
		}

		private void TitleLabel_MouseDown(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Left)
			{
				offset = new Point(e.X, e.Y);
			}
		}

		private void TitleLabel_MouseMove(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Left)
			{
				Location = new Point(Location.X + e.X - offset.X, Location.Y + e.Y - offset.Y);
			}
		}
	}
}
