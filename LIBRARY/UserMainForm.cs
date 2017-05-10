using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarySystemBackEnd;

namespace LIBRARY
{
    public partial class UserMainForm : DMSkin.Main
    {
        public UserMainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
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
            if (ReturnButton.Tag != null)//不在主页，启用返回键
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

    }
}
