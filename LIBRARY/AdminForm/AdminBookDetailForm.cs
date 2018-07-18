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
using System.Threading;
using WindowsFormsControlLibrary1;
using System.IO;
using System.Globalization;

namespace LIBRARY
{
    public partial class AdminBookDetailForm : DMSkin.Main
    {
        private AdminMainForm frmMain;
        private int commentPage;
        private int bookIndex;//booklist索引
        private int canDeleteFlag = 0;//可否删除图书
        private UserControl1[] commentControlList;
        public AdminBookDetailForm(AdminMainForm frm, int bookindex)
        {

            bookIndex = bookindex;
            frmMain = frm;
            commentPage = 1;
            InitializeComponent();
            button2.Show();
         //   if (PublicVar.scheduleList.Length == 0) label1.Hide();

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
                    canDeleteFlag = 1;
                }
                else if (PublicVar.eachBookState[i].BookState == Bookstate.Unavailable)
                {
                    ResultDataSheet.Rows[index].Cells[1].Value = "不可用";
                    canDeleteFlag = 1;
                }
                else if (PublicVar.eachBookState[i].BookState == Bookstate.Scheduled)
                {
                    ResultDataSheet.Rows[index].Cells[1].Value = "仅预约";
                    canDeleteFlag = 1;
                }
                ResultDataSheet.Rows[index].Cells[2].Value = "查看历史";

                ResultDataSheet.Rows[index].Height = 40;
            }
            ResultDataSheet.ClearSelection();
            ResultDataSheet.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ResultDataSheet.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ResultDataSheet.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            schQueDataSheet.Rows.Clear();

            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font("微软雅黑", 12);
            style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn col in this.schQueDataSheet.Columns)
            {
                col.HeaderCell.Style = style;
            }
            if (PublicVar.scheduleList.Length != 0)
                canDeleteFlag = 1;
            for (int i = 0; i < PublicVar.scheduleList.Length; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = schQueDataSheet.Rows.Add(row);
                schQueDataSheet.Rows[index].Cells[0].Value = PublicVar.scheduleList[i].UserId;
                schQueDataSheet.Rows[index].Cells[1].Value = PublicVar.scheduleList[i].BorrowTime.ToString("yyyy-MM-dd", DateTimeFormatInfo.InvariantInfo);
                schQueDataSheet.Rows[index].Height = 40;
            }



            schQueDataSheet.ClearSelection();
            schQueDataSheet.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            schQueDataSheet.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            schQueDataSheet.Refresh();

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


        private void ResultDataSheet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                AdminBookHistoryInfoForm bookHistoryInfoForm = new AdminBookHistoryInfoForm(e.RowIndex);
                bookHistoryInfoForm.ShowDialog();
                bookHistoryInfoForm.Dispose();
            }
        }

        private void BookDetailForm_Load(object sender, EventArgs e)
        {

            LoadGIFBox.Visible = true;
            BookCommentRequest.RunWorkerAsync();

            BookDetailLoad();
            frmMain.ReturnButton.Tag = 2;

            #region 设置圆形按钮区域
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddEllipse(0, 0, 96, 96);

            #endregion

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            BookListRefresh();
            if (canDeleteFlag == 1)
                button2.Hide();
        }

        

        private void BookNameLabel_Click(object sender, EventArgs e)
        {

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
                    commentControlList[i].setDeleteBtn(false);

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
                PublicVar.ReturnValue = -233;
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

        private void button2_Click(object sender, EventArgs e)
        {
			//删除图书
			DeleteBox deleteBox = new DeleteBox(PublicVar.nowBook.BookIsbn);
			deleteBox.ShowDialog();
           // deleteBox.Show();
			if(PublicVar.ReturnValue == 1) {
				PublicVar.ReturnValue = -233;
				frmMain.ReturnButton_Click(sender, e);
				//this.Close();
			} else {

			}
        }
    }
}
