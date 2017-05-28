using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LIBRARY
{
    public partial class InfoBox : DMSkin.Main
    {

		private Point offset;

		[DllImport("user32")]
        private static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);
        private const int AW_HOR_POSITIVE = 0x0001;//自左向右显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志
        private const int AW_HOR_NEGATIVE = 0x0002;//自右向左显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志
        private const int AW_VER_POSITIVE = 0x0004;//自顶向下显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志
        private const int AW_VER_NEGATIVE = 0x0008;//自下向上显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志该标志
        private const int AW_CENTER = 0x0010;//若使用了AW_HIDE标志，则使窗口向内重叠；否则向外扩展
        private const int AW_HIDE = 0x10000;//隐藏窗口
        private const int AW_ACTIVE = 0x20000;//激活窗口，在使用了AW_HIDE标志后不要使用这个标志
        private const int AW_SLIDE = 0x40000;//使用滑动类型动画效果，默认为滚动动画类型，当使用AW_CENTER标志时，这个标志就被忽略
        private const int AW_BLEND = 0x80000;//使用淡入淡出效果

        private int textType;
        /// <summary>
        /// 1 借阅 2 预订 3 修改 4 注册
        /// </summary>
        /// <param name="tT"></param>
        public InfoBox(int tT)
        {
            textType = tT;
            InitializeComponent();

        }

        private void InfoBox_Load(object sender, EventArgs e)
        {
            AnimateWindow(this.Handle, 10, AW_CENTER);
            if (textType == 1)
            {
                TextBox.Text = "借阅成功!";
            }
            else if (textType == 2)
            {
                TextBox.Text = "预约成功!";
            }
            else if (textType == 3)
            {
                TextBox.Text = "修改成功!";
            }
            else if (textType == 4)
            {
                TextBox.Text = "注册成功!";
            }
            else if (textType == 5)
            {
                TextBox.Text = "用户名/密码错误!";
            }
            else if (textType == 6)
            {
                TextBox.Text = "未选择用户类型!";
            }
            else if (textType == 7)
            {
                TextBox.Text = "该学号已被注册!";
            }
            else if (textType == 8)
            {
                TextBox.Text = "该用户名已被注册!";
            }
            else if (textType == 9)
            {
                TextBox.Text = "未知错误，请重试!";
            }
            else if (textType == 10)
            {
                TextBox.Text = "两次输入的密码不同，请重试!";
            }
            else if (textType == 11)
            {
                TextBox.Text = "当前借书数量已达上限!";
            }
            else if (textType == 12)
            {
                TextBox.Text = "当前预约数量已达上限!";
            }
            else if (textType == 13)
            {
                TextBox.Text = "请输入正确的数字!";
            }
            else if (textType == 14)
            {
                TextBox.Text = "充值成功!";
            }
            else if (textType == 15)
            {
                TextBox.Text = "原密码错误!";
            }
            else if (textType == 16)
            {
                TextBox.Text = "还书成功!";
            }
            else if (textType == 17)
            {
                TextBox.Text = "续借成功!";
            }
            else if (textType == 18)
            {
                TextBox.Text = "只能续借一次!";
            }
            else if (textType == 19)
            {
                TextBox.Text = "离应还日期5天以上不能续借!";
            }
            else if (textType == 20)
            {
                TextBox.Text = "书籍已过期!";
            }
            else if (textType == 21)
            {
                TextBox.Text = "取消成功!";
            }
            else if (textType == 22)
            {
                TextBox.Text = "当前预约人数过多!";
            }
            else if (textType == 23)
            {
                TextBox.Text = "删除成功！";
            }
            else if (textType == 24)
            {
                TextBox.Text = "删除失败！";
            }
            else if (textType == 25)
            {
                TextBox.Text = "书籍已被删除！";
            }
            else if (textType == 26)
            {
                TextBox.Text = "添加成功！";
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            
            Close();
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
