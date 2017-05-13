using System;
using System.ComponentModel;
using System.Windows.Forms;
using LibrarySystemBackEnd;

namespace LIBRARY
{
    public partial class UserMainForm : DMSkin.Main
    {
        public UserMainForm()
        {
            ClassBackEnd.StartTime();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TimeWorker.RunWorkerAsync();
            MainPanel.Controls.Clear();
            SearchForm searchForm = new SearchForm(this);
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
                    SearchForm searchForm = new SearchForm(this);
                    searchForm.TopLevel = false;
                    searchForm.Dock = DockStyle.Fill;
                    MainPanel.Controls.Add(searchForm);
                    searchForm.Show();
                    ReturnButton.Tag = null;
                }
                else if ((int)ReturnButton.Tag == 2)
                {
                    MainPanel.Controls.Clear();
                    SearchResultForm searchResultForm = new SearchResultForm(this, 0, "");
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
                    string[] a = ClassTime.SystemTime.Split();
                    myworker.ReportProgress(1, a[0]);
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
