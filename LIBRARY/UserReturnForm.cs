using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using LibrarySystemBackEnd;
using System.IO;

namespace LIBRARY
{
    public partial class UserReturnForm : DMSkin.Main
    {
        private int index;
        public UserReturnForm(int _index)
        {
            index = _index;
            InitializeComponent();
        }

        private void ReturnForm_Load(object sender, EventArgs e)
        {
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddEllipse(0, 0, 102, 102);
            ReturnButton.Region = new Region(myPath);
            ReBorrowButton.Region = new Region(myPath);
            BookImageRequest.RunWorkerAsync();
            BookDetailLoad();
        }


        #region 按钮动画
        private void ReturnButton_MouseMove(object sender, MouseEventArgs e)
        {
            ReturnButton.BackgroundImage = ReturnButton.DM_HoverImage;
        }

        private void ReturnButton_MouseLeave(object sender, EventArgs e)
        {
            ReturnButton.BackgroundImage = ReturnButton.DM_NolImage;
        }

        private void ReBorrowButton_MouseMove(object sender, MouseEventArgs e)
        {
            ReBorrowButton.BackgroundImage = ReBorrowButton.DM_HoverImage;
        }

        private void ReBorrowButton_MouseLeave(object sender, EventArgs e)
        {
            ReBorrowButton.BackgroundImage = ReBorrowButton.DM_NolImage;
        }
        #endregion
        private void BookDetailLoad()
        {
            BookNameText.Text = PublicVar.nowABook.BookName;
            AuthorText.Text = PublicVar.nowABook.BookAuthor;
            BookIDText.Text = PublicVar.nowABook.BookIsbn;
            PublisherText.Text = PublicVar.nowABook.BookPublisher;
            BorrowDateText.Text = PublicVar.nowABook.BorrowTime.ToLongDateString();
            ReturnDateText.Text = PublicVar.nowABook.ReturnTime.ToLongDateString();



        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {

            PublicVar.ReturnValue = -233;
            FileProtocol fileProtocol = new FileProtocol(RequestMode.UserReturnBook, 6000);
            fileProtocol.NowABook = PublicVar.nowABook;
            fileProtocol.Userinfo = PublicVar.logUser;


            LoadingBox loadingBox = new LoadingBox(RequestMode.UserReturnBook, "正在提交", fileProtocol);
            loadingBox.ShowDialog();
            loadingBox.Dispose();

            if (PublicVar.ReturnValue == -233)
            {
                return;
            }

            if (PublicVar.ReturnValue == 0)
            {
                MessageBox ib = new MessageBox(16);
                ib.ShowDialog();
                ib.Dispose();
                PublicVar.ReturnValue = -233;
                Close();
            }
            else
            {
                PublicVar.ReturnValue = -233;
                MessageBox ib = new MessageBox(9);
                ib.ShowDialog();
                ib.Dispose();
            }
            
        }

        private void ReBorrowButton_Click(object sender, EventArgs e)
        {
            PublicVar.ReturnValue = -233;
            FileProtocol fileProtocol = new FileProtocol(RequestMode.UserDelayBook, 6000);
            fileProtocol.NowABook = PublicVar.nowABook;
            fileProtocol.Userinfo = PublicVar.logUser;


            LoadingBox loadingBox = new LoadingBox(RequestMode.UserDelayBook, "正在提交", fileProtocol);
            loadingBox.ShowDialog();
            loadingBox.Dispose();

            if (PublicVar.ReturnValue == -233)
            {
                return;
            }
            if (PublicVar.ReturnValue == 0)
            {
                MessageBox ib = new MessageBox(17);
                ib.ShowDialog();
                ib.Dispose();
                PublicVar.ReturnValue = -233;
                Close();
            }
            else if(PublicVar.ReturnValue == 1|| PublicVar.ReturnValue == 5)
            {
                MessageBox ib = new MessageBox(9);
                ib.ShowDialog();
                ib.Dispose();
                PublicVar.ReturnValue = -233;
            }
            else if(PublicVar.ReturnValue == 2)
            {
                MessageBox ib = new MessageBox(20);
                ib.ShowDialog();
                ib.Dispose();
                PublicVar.ReturnValue = -233;
            }
            else if (PublicVar.ReturnValue == 3)
            {
                MessageBox ib = new MessageBox(19);
                ib.ShowDialog();
                ib.Dispose();
                PublicVar.ReturnValue = -233;
            }
            else if (PublicVar.ReturnValue == 4)
            {
                MessageBox ib = new MessageBox(18);
                ib.ShowDialog();
                ib.Dispose();
                PublicVar.ReturnValue = -233;
            }
        }

        private void ShutDownButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BookImageRequest_DoWork(object sender, DoWorkEventArgs e)
        {
            if (File.Exists(@"cache\" + PublicVar.nowABook.BookImage))
            {
                FileStream fileStream = File.Open(@"cache\" + PublicVar.nowABook.BookImage, FileMode.Open);
                byte[] buffer = new byte[PublicVar.IMAGE_MAX_SIZE];
                int size = fileStream.Read(buffer, 0, PublicVar.IMAGE_MAX_SIZE);
                PublicVar.pic = buffer;
                fileStream.Close();
                return;
            }
            Array.Clear(PublicVar.pic, 0, PublicVar.pic.Length);
            ServerClient serverClient = new ServerClient();
            FileProtocol fp = new FileProtocol(RequestMode.PicSend, 6000);
            fp.NowBook = new ClassBook(PublicVar.nowABook.BookIsbn.Substring(0, 13));
            serverClient.SendMessage(fp.ToString());

            PublicVar.pic = serverClient.receiveFileAsByte();
        }

        private void BookImageRequest_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                BookPictureBox.Image = PublicVar.BytesToImage(PublicVar.pic);

            }
            catch (Exception ee)
            {
                System.Windows.Forms.MessageBox.Show(ee.Message);
                return;
            }
            FileStream fileStream = File.Open(@"cache\" + PublicVar.nowABook.BookImage, FileMode.Create);
            fileStream.Write(PublicVar.pic, 0, PublicVar.pic.Length);
            fileStream.Close();
        }
    }
}
