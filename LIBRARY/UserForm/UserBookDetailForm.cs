using System;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using WindowsFormsControlLibrary1;
using System.Threading;
using System.IO;

namespace LIBRARY
{
    public partial class UserBookDetailForm : DMSkin.Main
    {
        private UserMainForm frmMain;

        private int commentPage;

        private int bookIndex;//booklist索引

       

        private UserControl1[] commentControlList;

        public UserBookDetailForm(UserMainForm frm, int bookindex)
        {
            
            bookIndex = bookindex;
            frmMain = frm;
            commentPage = 1;
            InitializeComponent();
            if (PublicVar.GuestFlag == 1)
            {
                BookBorrowButton.Hide();
                BookOrderButton.Hide();
				CommentSubmitBtn.Hide();
				commentTextBox.Hide();
				label3.Hide();//添加评论标签
            }
        }

        public void BookListRefresh()
        {
            ResultDataSheet.Rows.Clear();//清空上一次搜索表
            for (int i = 0; i < PublicVar.eachBookState.Length; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = ResultDataSheet.Rows.Add(row);
                ResultDataSheet.Rows[index].Cells[0].Value = PublicVar.eachBookState[i].BookIsbn;
                if (PublicVar.eachBookState[i].BookState == Bookstate.Available)
                {
                    ResultDataSheet.Rows[index].Cells[1].Value = "可借";
                }
                else if (PublicVar.eachBookState[i].BookState == Bookstate.Borrowed)
                {
                    ResultDataSheet.Rows[index].Cells[1].Value = "已借";
                }
                else if (PublicVar.eachBookState[i].BookState == Bookstate.Unavailable)
                {
                    ResultDataSheet.Rows[index].Cells[1].Value = "不可用";
                }
                else if (PublicVar.eachBookState[i].BookState == Bookstate.Scheduled)
                {
                    ResultDataSheet.Rows[index].Cells[1].Value = "仅预约";
                }

                ResultDataSheet.Rows[index].Height = 40;
            }
            ResultDataSheet.ClearSelection();
            ResultDataSheet.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ResultDataSheet.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void BookDetailLoad()
        {
            BookNameLabel.Text = PublicVar.nowBook.BookName;
            AuthorText.Text = PublicVar.nowBook.BookAuthor;
            BookIDText.Text = PublicVar.nowBook.BookIsbn;
            PublisherText.Text = PublicVar.nowBook.BookPublisher;
            BookInfoTextbox.Text = PublicVar.nowBook.BookIntroduction;
            AmountText.Text = PublicVar.nowBook.BookAmount.ToString();
            Label1Text.Text = PublicVar.nowBook.BookLable1;
            Label2Text.Text = PublicVar.nowBook.BookLable2;
            Label3Text.Text = PublicVar.nowBook.BookLable3;



            BookPictureBox.Image = Properties.Resources.BookNullImage;//set default image
            BookImageRequest.RunWorkerAsync();
        }

        private void OrderOrBorrow()
        {
            switch (PublicVar.ReturnValue)
            {
                case 0:
                    BookBorrowButton.Hide();
                    BookOrderButton.Hide();
                    NoUseButton.Show();
                    break;
                case 1:
                    BookBorrowButton.DM_NolImage = Properties.Resources.AlreadyBorrow;
                    BookBorrowButton.Enabled = false;
                    BookOrderButton.Hide();
                    break;
                case 2:
                    BookBorrowButton.DM_NolImage = Properties.Resources.BookBorrowButton;
                    BookOrderButton.Hide();
                    break;
                case 3:
                    BookOrderButton.DM_NolImage = Properties.Resources.AlreadyOrder;
                    BookOrderButton.Enabled = false;
                    BookBorrowButton.Hide();
                    break;
                case 4:
                    BookBorrowButton.Hide();
                    BookOrderButton.DM_NolImage = Properties.Resources.BookOrderButton;
                    BookOrderButton.Show();

                    break;
                default:
                    break;
            }
        }

        private void BookDetailForm_Load(object sender, EventArgs e)
        {
            //test
            LoadGIFBox.Visible = true;
            BookCommentRequest.RunWorkerAsync();


            BookDetailLoad();
            if (PublicVar.GuestFlag != 1) OrderOrBorrow();

            frmMain.ReturnButton.Tag = 2;

            #region 设置圆形按钮区域
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddEllipse(0, 0, 96, 96);
            BookBorrowButton.Region = new Region(myPath);
            BookOrderButton.Region = new Region(myPath);
            #endregion

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            BookListRefresh();
        }

        private void BookBorrowButton_Click(object sender, EventArgs e)
        {
            BookBorrowButton.Enabled = false;

            FileProtocol fileProtocol = new FileProtocol(RequestMode.UserBorrowBook, 6000);
            fileProtocol.NowBook = PublicVar.currentBookList[bookIndex];
            fileProtocol.Userinfo = PublicVar.logUser;
            PublicVar.ReturnValue = -233;

            LoadingBox loadingBox = new LoadingBox(RequestMode.UserBorrowBook, "正在提交", fileProtocol);
            loadingBox.ShowDialog();
            loadingBox.Dispose();


            var v = PublicVar.ReturnValue;
            if (v == -233)
            {
                BookBorrowButton.Enabled = true;
                return;
            }


            if (v == 0)//success
            {
                #region Infobox Show
                MessageBox infoBox = new MessageBox(1);
                infoBox.ShowDialog();
                infoBox.Dispose();
                #endregion


            }
            else if (v == 1)//amount
            {
                #region Infobox Show
                MessageBox infoBox = new MessageBox(11);
                infoBox.ShowDialog();
                infoBox.Dispose();
                #endregion


            }
            else if (v == 2)
            {
                #region Infobox Show
                MessageBox infoBox = new MessageBox(29);
                infoBox.ShowDialog();
                infoBox.Dispose();
                #endregion

            }
            else
            {
                #region Infobox Show
                MessageBox infoBox = new MessageBox(9);
                infoBox.ShowDialog();
                infoBox.Dispose();
                #endregion
            }

            PublicVar.ReturnValue = -233;
            BookListRequest.RunWorkerAsync();
        }

        private void BookOrderButton_Click(object sender, EventArgs e)
        {
            BookOrderButton.Enabled = false;
            FileProtocol fileProtocol = new FileProtocol(RequestMode.UserOrderBook, 6000);
            fileProtocol.NowBook = PublicVar.currentBookList[bookIndex];
            fileProtocol.Userinfo = PublicVar.logUser;
            PublicVar.ReturnValue = -233;

            LoadingBox loadingBox = new LoadingBox(RequestMode.UserOrderBook, "正在提交", fileProtocol);
            loadingBox.ShowDialog();
            loadingBox.Dispose();

            var v = PublicVar.ReturnValue;
            if (v == -233)
            {
                BookOrderButton.Enabled = true;
                return;
            }
            if (v == 0)//success
            {
                #region Infobox Show
                MessageBox infoBox = new MessageBox(2);
                infoBox.ShowDialog();
                infoBox.Dispose();
                #endregion

                PublicVar.ReturnValue = -233;
                BookListRequest.RunWorkerAsync();
            }
            else if (v == 1)//amount
            {
                BookOrderButton.Enabled = true;
                #region Infobox Show
                MessageBox infoBox = new MessageBox(12);
                infoBox.ShowDialog();
                infoBox.Dispose();
                #endregion

                PublicVar.ReturnValue = -233;
            }
            else//error
            {
                BookOrderButton.Enabled = true;
                PublicVar.ReturnValue = -233;
                #region Infobox Show
                MessageBox infoBox = new MessageBox(9);
                infoBox.ShowDialog();
                infoBox.Dispose();
                #endregion
            }

        }

        private void NoUseButton_Click(object sender, EventArgs e)
        {
            #region Infobox Show
            MessageBox infoBox = new MessageBox(22);
            infoBox.ShowDialog();
            infoBox.Dispose();
            #endregion
        }

        private void BookOrderButton_MouseMove(object sender, MouseEventArgs e)
        {
            BookOrderButton.DM_NolImage = BookOrderButton.DM_HoverImage;
        }

        private void BookOrderButton_MouseLeave(object sender, EventArgs e)
        {
            BookOrderButton.DM_NolImage = Properties.Resources.BookOrderButton;
        }

        private void BookBorrowButton_MouseMove(object sender, MouseEventArgs e)
        {
            BookBorrowButton.DM_NolImage = BookBorrowButton.DM_HoverImage;
        }

        private void BookBorrowButton_MouseLeave(object sender, EventArgs e)
        {
            BookBorrowButton.DM_NolImage = Properties.Resources.BookBorrowButton;
        }

        private void BookImageRequest_DoWork(object sender, DoWorkEventArgs e)
        {

            if (File.Exists(@"cache\" + PublicVar.nowBook.BookImage))
            {
                FileStream fileStream = File.Open(@"cache\" + PublicVar.nowBook.BookImage, FileMode.Open);
                byte[] buffer = new byte[PublicVar.IMAGE_MAX_SIZE];
                int size = fileStream.Read(buffer, 0, PublicVar.IMAGE_MAX_SIZE);
                PublicVar.pic = buffer;
                fileStream.Close();
                return;
            }

            //Array.Clear(PublicVar.pic, 0, PublicVar.pic.Length);
            ServerClient serverClient = new ServerClient();
            FileProtocol fp = new FileProtocol(RequestMode.PicSend, 6000);
            fp.NowBook = new ClassBook(PublicVar.nowBook.BookIsbn);
            serverClient.SendMessage(fp.ToString());

            PublicVar.pic = serverClient.receiveFileAsByte();

        }

        private void BookImageRequest_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                BookPictureBox.Image = PublicVar.BytesToImage(PublicVar.pic);
                BookPictureBox.BorderStyle = BorderStyle.None;
            }
            catch (Exception ee)
            {
                System.Windows.Forms.MessageBox.Show(ee.Message);
                return;
            }
			if (!File.Exists(@"cache\" + PublicVar.nowBook.BookImage))
			{
				FileStream fileStream = File.Open(@"cache\" + PublicVar.nowBook.BookImage, FileMode.Create);
				fileStream.Write(PublicVar.pic, 0, PublicVar.pic.Length);
				fileStream.Close();
				return;
			}
			
        }


        private void BookCommentRequest_DoWork(object sender, DoWorkEventArgs e)
        {
            ServerClient serverClient = new ServerClient();
            if (serverClient.isTimeOut)
            {
                e.Cancel = true;
            }
            else
            {
                FileProtocol fp = new FileProtocol(RequestMode.UserBookCommentLoad, 6000);
                fp.NowBook = new ClassBook(PublicVar.nowBook.BookIsbn);
                fp.Curnum = commentPage;
                serverClient.SendMessage(fp.ToString());
            }
            e.Result = serverClient;
        }

        private void BookCommentRequest_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ServerClient serverClient = (ServerClient)e.Result;
            if (serverClient.isTimeOut)
            {
                MessageBox infoBox = new MessageBox(28);
                infoBox.ShowDialog();
                infoBox.Dispose();
            }
            else
            {
                WaitingThread.RunWorkerAsync(serverClient);
            }

        }

        private void WaitingThread_DoWork(object sender, DoWorkEventArgs e)
        {
            PublicVar.ReturnValue = -233;
            ServerClient serverClient = (ServerClient)e.Argument;
            serverClient.BeginRead();
            int timer = 0;
            while (PublicVar.ReturnValue == -233 && timer < 10000)
            {
                Thread.Sleep(50);
                timer += 50;
            }
            if (timer >= 10000)
            {
                e.Cancel = true;
            }
        }

        private void WaitingThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            PublicVar.ReturnValue = -233;
            if (e.Cancelled)
            {
                System.Windows.Forms.MessageBox.Show("error time out!");
                //time out
                return;
            }
            if (PublicVar.currentCommentList == null)
            {
                System.Windows.Forms.MessageBox.Show("comment list null!");
                return;
            }
            else
            {


                commentTextBox.Text = "";
                LoadGIFBox.Visible = false;
                if (commentControlList != null)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        flowLayoutPanel1.Controls.Remove(commentControlList[i]);
                    }//exception??
                }

                commentControlList = new UserControl1[5];
                for (int i = 0; i < 5; i++)
                {
                    UserControl1 comment = new UserControl1();
                    comment.AutoSize = true;
                    comment.Location = new Point(66, 706);
                    comment.Margin = new Padding(64, 16, 64, 3);
                    comment.Name = i.ToString();
                    comment.Size = new Size(844, 86);
                    commentControlList[i] = comment;
                }


                for (int i = 0; i < PublicVar.currentCommentList.Length; i++)
                {
                    if (PublicVar.currentCommentList[i].UserId == PublicVar.logUser.UserId)
                    {
                        commentControlList[i].setDeleteBtn(false);
                    }
                    else
                    {
                        commentControlList[i].setDeleteBtn(true);
                    }
                    commentControlList[i].setTime(PublicVar.currentCommentList[i].CommentTime.ToShortDateString());
                    commentControlList[i].setText(PublicVar.currentCommentList[i].Text);
                    commentControlList[i].UserControlDeleteBtnClicked += new UserControl1.deleteBtnClickHandle(this.CommentDeleteBtn_Click);
                    flowLayoutPanel1.Controls.Add(commentControlList[i]);
                    flowLayoutPanel1.Controls.SetChildIndex(commentControlList[i], i + 4);
                }
            }
        }

        private void CommentDeleteBtn_Click(object sender, EventArgs e)
        {
            PublicVar.ReturnValue = -233;
            int index = Convert.ToInt32(((UserControl1)sender).Name);
            FileProtocol fileProtocol = new FileProtocol(RequestMode.UserDelComment, 6000);
            fileProtocol.NowComment = new ClassComment();
            fileProtocol.NowComment.CommentIsbn = PublicVar.currentCommentList[index].CommentIsbn;
            LoadingBox loadingBox = new LoadingBox(RequestMode.UserDelComment, "正在删除", fileProtocol);
            loadingBox.ShowDialog();
            loadingBox.Dispose();
            if (PublicVar.ReturnValue == 0)
            {
                System.Windows.Forms.MessageBox.Show("delete error!");
                return;
            }
            if (PublicVar.ReturnValue == -233)
            {
                return;
            }
            else
            {
                PublicVar.ReturnValue = -233;
                commentPage = 1;
                LoadGIFBox.Visible = true;
                BookCommentRequest.RunWorkerAsync();
            }
        }

        private void CommentSubmitBtn_Click(object sender, EventArgs e)
        {
            if (commentTextBox.Text.Trim() == "")
            {
                return;
            }
            else
            {
                PublicVar.ReturnValue = -233;
                FileProtocol fileProtocol = new FileProtocol(RequestMode.UserCommentBook, 6000);
                fileProtocol.NowComment = new ClassComment();
                fileProtocol.NowComment.CommentIsbn = PublicVar.nowBook.BookIsbn;
                fileProtocol.NowComment.UserId = PublicVar.logUser.UserId;
                fileProtocol.NowComment.Text = commentTextBox.Text.Trim();

                LoadingBox loadingBox = new LoadingBox(RequestMode.UserCommentBook, "正在提交", fileProtocol);
                loadingBox.ShowDialog();
                loadingBox.Dispose();
                if (PublicVar.ReturnValue == 0)
                {
                    System.Windows.Forms.MessageBox.Show("submit error!");
                    return;
                }
                if (PublicVar.ReturnValue == -233)
                {
                    return;
                }
                else
                {
                    PublicVar.ReturnValue = -233;
                    commentPage = 1;
                    LoadGIFBox.Visible = true;
                    BookCommentRequest.RunWorkerAsync();
                }
            }
        }

        private void LastPageButton_Click(object sender, EventArgs e)
        {
            if (commentPage == 1)
                return;
            else
            {
                commentPage -= 5;
                LoadGIFBox.Visible = true;
                BookCommentRequest.RunWorkerAsync();
            }

        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            if (commentPage + 5 > PublicVar.commentTotalAmount)
            {
                return;
            }
            else
            {
                commentPage += 5;
                LoadGIFBox.Visible = true;
                BookCommentRequest.RunWorkerAsync();
            }
        }

        private void BookListRequest_DoWork(object sender, DoWorkEventArgs e)
        {
            ServerClient serverClient = new ServerClient();
            if (serverClient.isTimeOut)
            {
                e.Cancel = true;
            }
            else
            {
                FileProtocol fileProtocol = new FileProtocol(RequestMode.UserBookStateLoad, 6000);
                fileProtocol.NowBook = PublicVar.currentBookList[bookIndex];
                fileProtocol.Userinfo = PublicVar.logUser;
                serverClient.SendMessage(fileProtocol.ToString());
            }
            e.Result = serverClient;
        }

        private void BookListRequest_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ServerClient serverClient = (ServerClient)e.Result;
            if (serverClient.isTimeOut)
            {
                MessageBox infoBox = new MessageBox(28);
                infoBox.ShowDialog();
                infoBox.Dispose();
                BookBorrowButton.Hide();
                BookOrderButton.Hide();
                NoUseButton.Enabled = false;

            }
            else
            {
                BookListRequestWaiting.RunWorkerAsync(serverClient);
            }
        }

        private void BookListRequestWaiting_DoWork(object sender, DoWorkEventArgs e)
        {
            PublicVar.ReturnValue = -233;
            ServerClient serverClient = (ServerClient)e.Argument;
            serverClient.BeginRead();
            int timer = 0;
            while (PublicVar.ReturnValue == -233 && timer < 10000)
            {
                Thread.Sleep(50);
                timer += 50;
            }
            if (timer >= 10000)
            {
                e.Cancel = true;
            }
        }

        private void BookListRequestWaiting_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox infoBox = new MessageBox(28);
                infoBox.ShowDialog();
                infoBox.Dispose();
                BookBorrowButton.Hide();
                BookOrderButton.Hide();
                NoUseButton.Enabled = false;
                //time out
            }
            else
            {
                BookBorrowButton.Enabled = true;
                BookOrderButton.Enabled = true;

                BookListRefresh();
                OrderOrBorrow();
            }
        }
    }
}
