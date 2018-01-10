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

namespace LIBRARY
{
    public partial class UserSearchForm : DMSkin.Main
    {
        private UserMainForm frmMain;
        private int ButtonState;
        public UserSearchForm(UserMainForm frm)
        {
            InitializeComponent();
            frmMain = frm;
            if (PublicVar.GuestFlag == 1)
            {
                UserInfoButton.Hide();
                BookReturnButton.Hide();
                Point p = SearchPanel.Location;
                p.Y += 70;
                SearchPanel.Location = p;

            }
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            #region 返回按钮动画
            Point t = new Point(16, 11);
            frmMain.ReturnButton.Hide();
            frmMain.TitleLabel.Location = t;
            #endregion

            #region 默认搜索条件：全部检索
            AllBackground.Show();
            SearchAll.ForeColor = Color.White;//默认检索条件：全部检索
            SearchAll.BackColor = Color.FromArgb(26, 148, 129);
            ISBNBackground.Hide();
            NameBackground.Hide();
            AuthorBackground.Hide();
            PublisherBackgound.Hide();
            LabelBackground.Hide();
            ButtonState = 1;
            #endregion

            #region 按钮触发范围设置
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddEllipse(0, 0, 172, 172);
            UserInfoButton.Region = new Region(myPath);
            BookReturnButton.Region = new Region(myPath);
            #endregion
        }

        #region SearchForm 按钮动画处理
        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == 13)
            {
                SearchButton.PerformClick();
            }
        }

        private void SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                e.Handled = true;
            }
        }

        private void SearchAll_MouseMove(object sender, MouseEventArgs e)
        {
            SearchAll.ForeColor = Color.White;
        }

        private void SearchAll_MouseLeave(object sender, EventArgs e)
        {
            if (ButtonState != 1)
            {
                SearchAll.ForeColor = Color.FromArgb(26, 148, 129);
            }
        }

        private void SearchISBN_MouseMove(object sender, MouseEventArgs e)
        {
            SearchISBN.ForeColor = Color.White;
        }

        private void SearchISBN_MouseLeave(object sender, EventArgs e)
        {
            if (ButtonState != 2)
            {
                SearchISBN.ForeColor = Color.FromArgb(26, 148, 129);
            }
        }

        private void SearchName_MouseMove(object sender, MouseEventArgs e)
        {
            SearchName.ForeColor = Color.White;
        }

        private void SearchName_MouseLeave(object sender, EventArgs e)
        {
            if (ButtonState != 3)
            {
                SearchName.ForeColor = Color.FromArgb(26, 148, 129);
            }
        }

        private void SearchAuthor_MouseMove(object sender, MouseEventArgs e)
        {
            SearchAuthor.ForeColor = Color.White;
        }

        private void SearchAuthor_MouseLeave(object sender, EventArgs e)
        {
            if (ButtonState != 4)
            {
                SearchAuthor.ForeColor = Color.FromArgb(26, 148, 129);
            }
        }

        private void SearchPublisher_MouseMove(object sender, MouseEventArgs e)
        {
            SearchPublisher.ForeColor = Color.White;
        }

        private void SearchPublisher_MouseLeave(object sender, EventArgs e)
        {
            if (ButtonState != 5)
            {
                SearchPublisher.ForeColor = Color.FromArgb(26, 148, 129);
            }
        }

        private void LabelButton_MouseMove(object sender, MouseEventArgs e)
        {
            LabelButton.ForeColor = Color.White;
        }

        private void LabelButton_MouseLeave(object sender, EventArgs e)
        {
            if (ButtonState != 6)
            {
                LabelButton.ForeColor = Color.FromArgb(26, 148, 129);
            }
        }

        private void SearchAll_Click(object sender, EventArgs e)
        {
            ButtonState = 1;
            AllBackground.Show();
            ISBNBackground.Hide();
            NameBackground.Hide();
            AuthorBackground.Hide();
            PublisherBackgound.Hide();
            LabelBackground.Hide();
            SearchAll.ForeColor = Color.White;
            SearchAll.BackColor = Color.FromArgb(26, 148, 129);
            SearchISBN.ForeColor = Color.FromArgb(26, 148, 129);
            SearchISBN.BackColor = Color.Transparent;
            SearchName.ForeColor = Color.FromArgb(26, 148, 129);
            SearchName.BackColor = Color.Transparent;
            SearchAuthor.ForeColor = Color.FromArgb(26, 148, 129);
            SearchAuthor.BackColor = Color.Transparent;
            SearchPublisher.ForeColor = Color.FromArgb(26, 148, 129);
            SearchPublisher.BackColor = Color.Transparent;
            LabelButton.ForeColor = Color.FromArgb(26, 148, 129);
            LabelButton.BackColor = Color.Transparent;
        }

        private void SearchISBN_Click(object sender, EventArgs e)
        {
            ButtonState = 2;
            AllBackground.Hide();
            ISBNBackground.Show();
            NameBackground.Hide();
            AuthorBackground.Hide();
            PublisherBackgound.Hide();
            LabelBackground.Hide();
            SearchAll.ForeColor = Color.FromArgb(26, 148, 129);
            SearchAll.BackColor = Color.Transparent;
            SearchISBN.ForeColor = Color.White;
            SearchISBN.BackColor = Color.FromArgb(26, 148, 129);
            SearchName.ForeColor = Color.FromArgb(26, 148, 129);
            SearchName.BackColor = Color.Transparent;
            SearchAuthor.ForeColor = Color.FromArgb(26, 148, 129);
            SearchAuthor.BackColor = Color.Transparent;
            SearchPublisher.ForeColor = Color.FromArgb(26, 148, 129);
            SearchPublisher.BackColor = Color.Transparent;
            LabelButton.ForeColor = Color.FromArgb(26, 148, 129);
            LabelButton.BackColor = Color.Transparent;
        }

        private void SearchName_Click(object sender, EventArgs e)
        {
            ButtonState = 3;
            AllBackground.Hide();
            ISBNBackground.Hide();
            NameBackground.Show();
            AuthorBackground.Hide();
            PublisherBackgound.Hide();
            LabelBackground.Hide();
            SearchAll.ForeColor = Color.FromArgb(26, 148, 129);
            SearchAll.BackColor = Color.Transparent;
            SearchISBN.ForeColor = Color.FromArgb(26, 148, 129);
            SearchISBN.BackColor = Color.Transparent;
            SearchName.ForeColor = Color.White;
            SearchName.BackColor = Color.FromArgb(26, 148, 129);
            SearchAuthor.ForeColor = Color.FromArgb(26, 148, 129);
            SearchAuthor.BackColor = Color.Transparent;
            SearchPublisher.ForeColor = Color.FromArgb(26, 148, 129);
            SearchPublisher.BackColor = Color.Transparent;
            LabelButton.ForeColor = Color.FromArgb(26, 148, 129);
            LabelButton.BackColor = Color.Transparent;
        }

        private void SearchAuthor_Click(object sender, EventArgs e)
        {
            ButtonState = 4;
            AllBackground.Hide();
            ISBNBackground.Hide();
            NameBackground.Hide();
            AuthorBackground.Show();
            PublisherBackgound.Hide();
            LabelBackground.Hide();
            SearchAll.ForeColor = Color.FromArgb(26, 148, 129);
            SearchAll.BackColor = Color.Transparent;
            SearchISBN.ForeColor = Color.FromArgb(26, 148, 129);
            SearchISBN.BackColor = Color.Transparent;
            SearchName.ForeColor = Color.FromArgb(26, 148, 129);
            SearchName.BackColor = Color.Transparent;
            SearchAuthor.ForeColor = Color.White;
            SearchAuthor.BackColor = Color.FromArgb(26, 148, 129);
            SearchPublisher.ForeColor = Color.FromArgb(26, 148, 129);
            SearchPublisher.BackColor = Color.Transparent;
            LabelButton.ForeColor = Color.FromArgb(26, 148, 129);
            LabelButton.BackColor = Color.Transparent;
        }

        private void SearchPublisher_Click(object sender, EventArgs e)
        {
            ButtonState = 5;
            AllBackground.Hide();
            ISBNBackground.Hide();
            NameBackground.Hide();
            AuthorBackground.Hide();
            PublisherBackgound.Show();
            LabelBackground.Hide();
            SearchAll.ForeColor = Color.FromArgb(26, 148, 129);
            SearchAll.BackColor = Color.Transparent;
            SearchISBN.ForeColor = Color.FromArgb(26, 148, 129);
            SearchISBN.BackColor = Color.Transparent;
            SearchName.ForeColor = Color.FromArgb(26, 148, 129);
            SearchName.BackColor = Color.Transparent;
            SearchAuthor.ForeColor = Color.FromArgb(26, 148, 129);
            SearchAuthor.BackColor = Color.Transparent;
            SearchPublisher.ForeColor = Color.White;
            SearchPublisher.BackColor = Color.FromArgb(26, 148, 129);
            LabelButton.ForeColor = Color.FromArgb(26, 148, 129);
            LabelButton.BackColor = Color.Transparent;
        }

        private void LabelButton_Click(object sender, EventArgs e)
        {
            ButtonState = 6;
            AllBackground.Hide();
            ISBNBackground.Hide();
            NameBackground.Hide();
            AuthorBackground.Hide();
            PublisherBackgound.Hide();
            LabelBackground.Show();
            SearchAll.ForeColor = Color.FromArgb(26, 148, 129);
            SearchAll.BackColor = Color.Transparent;
            SearchISBN.ForeColor = Color.FromArgb(26, 148, 129);
            SearchISBN.BackColor = Color.Transparent;
            SearchName.ForeColor = Color.FromArgb(26, 148, 129);
            SearchName.BackColor = Color.Transparent;
            SearchAuthor.ForeColor = Color.FromArgb(26, 148, 129);
            SearchAuthor.BackColor = Color.Transparent;
            SearchPublisher.ForeColor = Color.FromArgb(26, 148, 129);
            SearchPublisher.BackColor = Color.Transparent;
            LabelButton.ForeColor = Color.White;
            LabelButton.BackColor = Color.FromArgb(26, 148, 129);
        }

        private void UserInfoButton_MouseMove(object sender, MouseEventArgs e)
        {
            UserInfoButton.BackgroundImage = UserInfoButton.DM_HoverImage;
        }

        private void UserInfoButton_MouseLeave(object sender, EventArgs e)
        {
            UserInfoButton.BackgroundImage = UserInfoButton.DM_NolImage;
        }

        private void BookReturnButton_MouseMove(object sender, MouseEventArgs e)
        {
            BookReturnButton.BackgroundImage = BookReturnButton.DM_HoverImage;
        }

        private void BookReturnButton_MouseLeave(object sender, EventArgs e)
        {
            BookReturnButton.BackgroundImage = BookReturnButton.DM_NolImage;
        }
        #endregion

        private void SearchButton_Click(object sender, EventArgs e)
        {


            frmMain.MainPanel.Controls.Clear();
            UserSearchResultForm searchResultForm = new UserSearchResultForm(frmMain, ButtonState, SearchBox.Text);
            searchResultForm.TopLevel = false;
            searchResultForm.Dock = DockStyle.Fill;
            frmMain.MainPanel.Controls.Add(searchResultForm);
            searchResultForm.Tag = true;
            searchResultForm.Show();
        }

        private void UserInfoButton_Click(object sender, EventArgs e)
        {
            //ClassUserBasicInfo classUserBasicInfo = new ClassUserBasicInfo(UserTextBox.Text, "", PasswordTextBox.Text, "", Usertype.Student);
            FileProtocol fileProtocol = new FileProtocol(RequestMode.UserInfoLoad, 6000);
            fileProtocol.Userinfo = PublicVar.logUser;
            
            LoadingBox loadingBox = new LoadingBox(RequestMode.UserInfoLoad, "正在获取", fileProtocol);
            loadingBox.ShowDialog();
            loadingBox.Dispose();
            var v = PublicVar.ReturnValue;
            if (v == -233)//cancel
            {
                return;
            }
            if (v == 1)//success
            {
                frmMain.MainPanel.Controls.Clear();
                UserForm userForm = new UserForm(frmMain);
                userForm.TopLevel = false;
                userForm.Dock = DockStyle.Fill;
                frmMain.MainPanel.Controls.Add(userForm);
                userForm.Show();
                PublicVar.ReturnValue = -233;
            }
  
        }

        private void BookReturnButton_Click(object sender, EventArgs e)
        {
            PublicVar.ReturnValue = -233;
            FileProtocol fileProtocol = new FileProtocol(RequestMode.UserBorrowedBook, 6000);
            fileProtocol.Userinfo = PublicVar.logUser;



            LoadingBox loadingBox = new LoadingBox(RequestMode.UserBorrowedBook, "正在加载", fileProtocol);
            loadingBox.ShowDialog();
            loadingBox.Dispose();

            if(PublicVar.ReturnValue==-233)
            {
                return;
            }
            PublicVar.ReturnValue = -233;

            frmMain.MainPanel.Controls.Clear();
            UserBookReturnForm bookReturnForm = new UserBookReturnForm(frmMain);
            bookReturnForm.TopLevel = false;
            bookReturnForm.Dock = DockStyle.Fill;
            frmMain.MainPanel.Controls.Add(bookReturnForm);
            bookReturnForm.Show();
        }
    }
}
