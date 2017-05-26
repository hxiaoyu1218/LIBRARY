using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using LibrarySystemBackEnd;

namespace LIBRARY
{
    public partial class AdminSystemLogForm : DMSkin.Main
    {
        private AdminMainForm frmMain;
        private static int maxPage;
        private static int nPage = 1;

        public AdminSystemLogForm(AdminMainForm frm)
        {
            frmMain = frm;
            InitializeComponent();         
        }

        private void AdminSystemLogForm_Load(object sender, EventArgs e)
        {
            #region 返回按钮处理
            frmMain.ReturnButton.Tag = 1;
            Point t = new Point(61, 11);
            frmMain.ReturnButton.Show();
            frmMain.TitleLabel.Location = t;
            #endregion
        }
    }

}