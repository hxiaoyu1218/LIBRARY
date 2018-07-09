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
using System.IO;

namespace LIBRARY
{
    public partial class AdminBookAddForm : DMSkin.Main
    {
        string SavePath = "";
        private int tmp = 0;

        public AdminBookAddForm()
        {
            InitializeComponent();
        }
        private void AddBookForm_Load(object sender, EventArgs e)
        {

            AddImageButton.BackColor = Color.Transparent;
            AddImageButton.Parent = BookImagePictureBox;
            AddImageButton.Location = new Point(40, 77);
            AddImageButton.BringToFront();

            //IDTextBox.Text = ClassTime.getNextIsbn();//max 99 books per day


        }

        private void ShutDownButton_Click(object sender, EventArgs e)
        {
            if (tmp == 0 && SavePath != "")
            {
                BookImagePictureBox.Dispose();
                File.Delete(SavePath);
            }
            Close();
        }

        #region Animate
        private void BookNameCueText_Click(object sender, EventArgs e)
        {
            if (BookNameTextBox.Text == "")
            {
                BookNameCueText.Hide();
                BookNameTextBox.Focus();
            }
        }

        private void PublisherCueText_Click(object sender, EventArgs e)
        {
            if (PublisherTextBox.Text == "")
            {
                PublisherCueText.Hide();
                PublisherTextBox.Focus();
            }
        }

        private void BookAmountCueText_Click(object sender, EventArgs e)
        {
            if (BookAmountTextBox.Text == "")
            {
                BookAmountCueText.Hide();
                BookAmountTextBox.Focus();
            }
        }

        private void BookInfoCueText_Click(object sender, EventArgs e)
        {
            if (BookInfoTextBox.Text == "")
            {
                BookInfoCueText.Hide();
                BookInfoTextBox.Focus();
            }
        }

        private void Label1CueText_Click(object sender, EventArgs e)
        {
            if (Label1TextBox.Text == "")
            {
                Label1CueText.Hide();
                Label1TextBox.Focus();
            }
        }

        private void Label2CueText_Click(object sender, EventArgs e)
        {
            if (Label2TextBox.Text == "")
            {
                Label2CueText.Hide();
                Label2TextBox.Focus();
            }
        }

        private void Label3CueText_Click(object sender, EventArgs e)
        {
            if (Label3TextBox.Text == "")
            {
                Label3CueText.Hide();
                Label3TextBox.Focus();
            }
        }

        private void Label1TextBox_Enter(object sender, EventArgs e)
        {
            if (Label1TextBox.Text == "")
            {
                Label1CueText.Hide();
            }
        }

        private void Label1TextBox_Leave(object sender, EventArgs e)
        {
            if (Label1TextBox.Text == "")
            {
                Label1CueText.Show();
            }
        }

        private void Label2TextBox_Enter(object sender, EventArgs e)
        {
            if (Label2TextBox.Text == "")
            {
                Label2CueText.Hide();
            }
        }

        private void Label2TextBox_Leave(object sender, EventArgs e)
        {
            if (Label2TextBox.Text == "")
            {
                Label2CueText.Show();
            }
        }

        private void Label3TextBox_Enter(object sender, EventArgs e)
        {
            if (Label3TextBox.Text == "")
            {
                Label3CueText.Hide();
            }
        }

        private void Label3TextBox_Leave(object sender, EventArgs e)
        {
            if (Label3TextBox.Text == "")
            {
                Label3CueText.Show();
            }

        }

        private void BookNameTextBox_Enter(object sender, EventArgs e)
        {
            if (BookNameTextBox.Text == "")
            {
                BookNameCueText.Hide();
            }
        }

        private void BookNameTextBox_Leave(object sender, EventArgs e)
        {
            if (BookNameTextBox.Text == "")
            {
                BookNameCueText.Show();
            }
        }

        private void AuthorTextBox_Enter(object sender, EventArgs e)
        {
            if (AuthorTextBox.Text == "")
            {
                AuthorCueText.Hide();
            }
        }

        private void AuthorTextBox_Leave(object sender, EventArgs e)
        {
            if (AuthorTextBox.Text == "")
            {
                AuthorCueText.Show();
            }
        }

        private void PublisherTextBox_Enter(object sender, EventArgs e)
        {
            if (PublisherTextBox.Text == "")
            {
                PublisherCueText.Hide();
            }
        }

        private void PublisherTextBox_Leave(object sender, EventArgs e)
        {
            if (PublisherTextBox.Text == "")
            {
                PublisherCueText.Show();
            }
        }

        private void BookAmountTextBox_Enter(object sender, EventArgs e)
        {
            if (BookAmountTextBox.Text == "")
            {
                BookAmountCueText.Hide();
            }
        }

        private void BookAmountTextBox_Leave(object sender, EventArgs e)
        {
            if (BookAmountTextBox.Text == "")
            {
                BookAmountCueText.Show();
            }
        }

        private void BookInfoTextBox_Enter(object sender, EventArgs e)
        {
            if (BookInfoTextBox.Text == "")
            {
                BookInfoCueText.Hide();
            }
        }

        private void BookInfoTextBox_Leave(object sender, EventArgs e)
        {
            if (BookInfoTextBox.Text == "")
            {
                BookInfoCueText.Show();
            }
        }

        private void AddImageButton_MouseMove(object sender, MouseEventArgs e)
        {
            AddImageButton.BackgroundImage = AddImageButton.DM_HoverImage;
        }

        private void AddImageButton_MouseLeave(object sender, EventArgs e)
        {
            AddImageButton.BackgroundImage = AddImageButton.DM_NolImage;
        }

        private void OKButton_MouseMove(object sender, MouseEventArgs e)
        {
            OKButton.BackgroundImage = OKButton.DM_HoverImage;
        }

        private void OKButton_MouseLeave(object sender, EventArgs e)
        {
            OKButton.BackgroundImage = OKButton.DM_NolImage;
        }

        private void IDTextBox_Enter(object sender, EventArgs e)
        {
            if (IDTextBox.Text == "")
                ISBNCueText.Hide();

        }

        private void IDTextBox_Leave(object sender, EventArgs e)
        {
            if (IDTextBox.Text == "")
                ISBNCueText.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OKButton_Click(OKButton, new EventArgs());
        }

        #endregion

        private void AddImageButton_Click(object sender, EventArgs e)
        {
            DialogResult result = OpenImage.ShowDialog();
            if (result == DialogResult.OK)
            {
                tmp = 1;
                string path = OpenImage.FileName;
                BookImagePictureBox.Image = Image.FromFile(path);
                PublicVar.pic = PublicVar.ImageToBytes(BookImagePictureBox.Image);
                OpenImage.InitialDirectory = path.Substring(0, path.Length - OpenImage.SafeFileName.Length);
                AddImageButton.Hide();
            }
        }
        private bool CheckInput()
        {
            if (IDTextBox.Text == "" || BookNameTextBox.Text == "" || AuthorTextBox.Text == "" || PublisherTextBox.Text == "" || BookAmountTextBox.Text == "" || Label1TextBox.Text == "" || Label2TextBox.Text == "" || Label3TextBox.Text == "" || BookInfoTextBox.Text == "")
            {
                MessageBox infoBox = new MessageBox(33);
                infoBox.ShowDialog();
                infoBox.Dispose();
                this.Focus();
                //BookAmountTextBox.Focus();
                return false;
            }
            try
            {
                var Isbn = Convert.ToString(IDTextBox.Text.Trim());

                //if(IDTextBox.Text.Length==13)
                //var amount = Convert.ToInt32(BookAmountTextBox.Text.Trim());
                if (Isbn.Length!=13)
                {
                    MessageBox infoBox = new MessageBox(35);
                    infoBox.ShowDialog();
                    infoBox.Dispose();
                    //BookAmountTextBox.Focus();
                    return false; ;
                }
            }
            catch
            {
                MessageBox infoBox = new MessageBox(35);
                infoBox.ShowDialog();
                infoBox.Dispose();
                //BookAmountTextBox.Focus();
                return false;
            }
            try
            {
                var amount = Convert.ToInt32(BookAmountTextBox.Text);
                if (tmp == 0)
                {
                    MessageBox infoBox = new MessageBox(34);
                    infoBox.ShowDialog();
                    infoBox.Dispose();
                    //BookAmountTextBox.Focus();
                    return false; ;
                }
            }
            catch
            {
                MessageBox infoBox = new MessageBox(13);
                infoBox.ShowDialog();
                infoBox.Dispose();
                BookAmountTextBox.Focus();
                return false;
            }
            return true;
        }
        private void OKButton_Click(object sender, EventArgs e)
        {

            if (CheckInput())
            {
                FileProtocol fileProtocol = new FileProtocol(RequestMode.AdminAddBook, 6000);
                fileProtocol.Admin = new ClassAdmin(PublicVar.logUser.UserId);
                fileProtocol.Admin.Password = PublicVar.logUser.UserPassword;
                fileProtocol.NowBook = new ClassBook(IDTextBox.Text.Trim());
                fileProtocol.NowBook.BookAmount = Convert.ToInt32(BookAmountTextBox.Text.Trim());
                fileProtocol.NowBook.BookName = BookNameTextBox.Text.Trim();
                fileProtocol.NowBook.BookAuthor = AuthorTextBox.Text.Trim();
                fileProtocol.NowBook.BookLable1 = Label1TextBox.Text.Trim();
                fileProtocol.NowBook.BookLable2 = Label2TextBox.Text.Trim();
                fileProtocol.NowBook.BookLable3 = Label3TextBox.Text.Trim();
                fileProtocol.NowBook.BookPublisher = PublisherTextBox.Text.Trim();
                fileProtocol.NowBook.BookPublishTime = DateTime.Now;
                fileProtocol.NowBook.BookIntroduction = BookInfoTextBox.Text.Trim();

                LoadingBox loadingBox = new LoadingBox(RequestMode.AdminAddBook, "正在提交", fileProtocol);
                loadingBox.ShowDialog();
                loadingBox.Dispose();


                if (PublicVar.ReturnValue == -233)
                {
                    return;

                }
                else
                {
                    PublicVar.ReturnValue = -233;
                    MessageBox infoBox = new MessageBox(26);
                    infoBox.ShowDialog();
                    infoBox.Dispose();
                    Close();
                }
            }


        }

        private void ISBNCueText_Click(object sender, EventArgs e)
        {
            if(IDTextBox.Text=="")
            {
                ISBNCueText.Hide();
                IDTextBox.Focus();
            }
        }
    }
}
