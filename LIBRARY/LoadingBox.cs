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
using System.Threading;

namespace LIBRARY
{
    public partial class LoadingBox : DMSkin.Main
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

        private RequestMode mode;
        private string boxString;
        private FileProtocol fileProtocol;
        private ServerClient serverClient;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tT"></param>
        /// <param name="boxString">提示文字</param>
        /// <param name="mode">请求类别</param>
        public LoadingBox(RequestMode mode, string boxString, FileProtocol fileProtocol)
        {
            this.mode = mode;
            this.boxString = boxString;
            this.fileProtocol = fileProtocol;
            InitializeComponent();

        }

        private void InfoBox_Load(object sender, EventArgs e)
        {
            AnimateWindow(this.Handle, 10, AW_CENTER);
            TextBox.Text = boxString;
            SendingThread.RunWorkerAsync();

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

        private void WaitingThread_DoWork(object sender, DoWorkEventArgs e)
        {
            serverClient.BeginRead();
            int timer = 0;
            //超时判断
            switch (mode)
            {
                case RequestMode.UserLogin:
                case RequestMode.UserRegist:
                    while (PublicVar.ReturnValue == -233 && timer < 10000)
                    {
                        timer += 50;
                        Thread.Sleep(50);
                    }
                    break;
                case RequestMode.UserSearchBook:
                    while (PublicVar.ReturnValue == -233 && timer < 10000)
                    {
                        timer += 50;
                        Thread.Sleep(50);
                    }
                    break;
                case RequestMode.UserBookLoad:
                    break;
                case RequestMode.UserBookStateLoad:
                    break;
                case RequestMode.UserBookCommentLoad:
                    break;
                case RequestMode.UserBorrowBook:
                    break;
                case RequestMode.UserCommentBook:
                    break;
                case RequestMode.UserDelComment:
                    break;
                case RequestMode.UserOrderBook:
                    break;
                case RequestMode.UserInfoLoad:
                    break;
                case RequestMode.UserInfoChange:
                    break;
                case RequestMode.UserNotificationLoad:
                    break;
                case RequestMode.UserBorrowedBook:
                    break;
                case RequestMode.UserBorrowHis:
                    break;
                case RequestMode.UserBadRecord:
                    break;
                case RequestMode.UserAbookLoad:
                    break;
                case RequestMode.UserReturnBook:
                    break;
                case RequestMode.UserDelayBook:
                    break;
                default:
                    break;
            }
            if (timer >= 10000)
            {
                e.Cancel = true;
                
            }
        }

        private void WaitingThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Cancelled)
            {
                TextBox.Text = "请求超时";
                LoadGIFBox.Enabled = false;
                ConfirmButton.Visible = true;
            }
            else
                Close();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SendingThread_DoWork(object sender, DoWorkEventArgs e)
        {
            serverClient = new ServerClient();
        }

        private void SendingThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (serverClient.isTimeOut)
            {
                ConfirmButton.Visible = true;
                LoadGIFBox.Enabled = false;
                TextBox.Text = "请求超时";
                return;
            }
            serverClient.SendMessage(fileProtocol.ToString());
            WaitingThread.RunWorkerAsync();
        }
    }
}
