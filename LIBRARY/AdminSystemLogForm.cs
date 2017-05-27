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

		private void UserComingRateButton_MouseMove(object sender, MouseEventArgs e)
		{
			UserComingRateButton.BackgroundImage = UserComingRateButton.DM_HoverImage;
		}

		private void UserComingRateButton_MouseLeave(object sender, EventArgs e)
		{
			UserComingRateButton.BackgroundImage = UserComingRateButton.DM_NolImage;
		}

		private void BookLendingRateButton_MouseMove(object sender, MouseEventArgs e)
		{
			BookLendingRateButton.BackgroundImage = BookLendingRateButton.DM_HoverImage;
		}

		private void BookLendingRateButton_MouseLeave(object sender, EventArgs e)
		{
			BookLendingRateButton.BackgroundImage = BookLendingRateButton.DM_NolImage;
		}

		private void SystemLogTextButton_MouseMove(object sender, MouseEventArgs e)
		{
			SystemLogTextButton.BackgroundImage = SystemLogTextButton.DM_HoverImage;
		}

		private void SystemLogTextButton_MouseLeave(object sender, EventArgs e)
		{
			SystemLogTextButton.BackgroundImage = SystemLogTextButton.DM_NolImage;
		}

		private void UserComingRateButton_MouseHover(object sender, EventArgs e)
		{

		}
	}

}