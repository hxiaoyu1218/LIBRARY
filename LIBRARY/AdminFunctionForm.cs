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
    public partial class AdminFunctionForm : DMSkin.Main
    {
        private AdminMainForm frmMain;
        public AdminFunctionForm(AdminMainForm frm)
        {
            InitializeComponent();
            frmMain = frm;
        }

        private void AdminFunctionForm_Load(object sender, EventArgs e)
        {
            #region 返回按钮动画
            frmMain.ReturnButton.Hide();
            frmMain.TitleLabel.Location = new Point(16, 11);
            #endregion



            //#region 按钮触发范围设置
            //GraphicsPath myPath = new GraphicsPath();
            //myPath.AddEllipse(0, 0, 172, 172);
            ////重新设置圆形按钮region范围
            //UserInfoButton.Region = new Region(myPath);
            //BookReturnButton.Region = new Region(myPath);
            //#endregion
        }

        private void BookReturnButton_Click(object sender, EventArgs e)
        {

        }

        private void BookReturnButton_MouseLeave(object sender, EventArgs e)
        {

        }

        private void BookReturnButton_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void UserInfoButton_Click(object sender, EventArgs e)
        {

        }

        private void UserInfoButton_MouseLeave(object sender, EventArgs e)
        {

        }

        private void UserInfoButton_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
