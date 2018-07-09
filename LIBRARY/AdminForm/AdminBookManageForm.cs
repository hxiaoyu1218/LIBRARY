using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LIBRARY
{
    public partial class AdminBookManageForm : DMSkin.Main
    {
        private AdminMainForm frmMain;
        private FileProtocol fileProtocol;
        private static int maxPage;
        private static int nPage = 1;
        public static int lastState;
        public static string lastString;
        private int flag = 1;
        private int tmpPage = nPage;//解决翻页跳页临时断网 页码修改问题 引入的中间变量
        private int ButtonState;// 1 ALL 2 ISBN 3 NAME 4 AUTHOR 5 PUBLISHER 6 LABEL

        public AdminBookManageForm(AdminMainForm frm, int state, string searchS)
        {
            frmMain = frm;
            lastState = state;
            lastString = searchS;
            InitializeComponent();
            PageButtonLoad(PublicVar.bookTotalAmount);
            //SearchBox.Focus();
        }

        private void searchBook()
        {
            PublicVar.ReturnValue = -233;
            fileProtocol = new FileProtocol(RequestMode.UserSearchBook, 6000);
            fileProtocol.Curnum = (nPage - 1) * 10 + 1;
            fileProtocol.Searchwords = lastString;
            fileProtocol.Searchcat = lastState;

            LoadingBox loadingBox = new LoadingBox(RequestMode.UserSearchBook, "正在查询", fileProtocol);
            loadingBox.ShowDialog();
            loadingBox.Dispose();
            if (PublicVar.ReturnValue == -233)
                return;
            tmpPage = nPage;
            PublicVar.ReturnValue = -233;
            DataSheetLoad();
        }

        private void PageButtonLoad(int num)
        {
            if (num == 0)
            {
                LastPButton.Hide();
                NextPbutton.Hide();
                JumpPTextBox.Hide();
                PageTextBox.Hide();
                DividePicture.Hide();
            }
            else
            {
                LastPButton.Show();
                NextPbutton.Show();
                JumpPTextBox.Show();
                PageTextBox.Show();
                DividePicture.Show();
            }
        }

        private void DataSheetLoad()
        {
            ResultDataSheet.Rows.Clear();
            ResultDataSheet.Hide();
            if (PublicVar.currentBookList == null)
            {
                return;
            }

            for (int i = 0; i < PublicVar.currentBookList.Length; i++)
            {
                var c = PublicVar.currentBookList[i];
                DataGridViewRow row = (DataGridViewRow)ResultDataSheet.RowTemplate.Clone();
                int index = ResultDataSheet.Rows.Add(row);
                ResultDataSheet.Rows[index].Cells[0].Value = c.BookIsbn;
                ResultDataSheet.Rows[index].Cells[1].Value = c.BookName;
                ResultDataSheet.Rows[index].Cells[2].Value = c.BookAuthor;
                ResultDataSheet.Rows[index].Cells[3].Value = c.BookPublisher;
                ResultDataSheet.Rows[index].Cells[4].Value = "详情";
            }
            if (PublicVar.currentBookList.Length == 0)
                NoResultTextBox.Show();


            ResultDataSheet.Show();
            ResultDataSheet.ClearSelection();
            ResultDataSheet.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            JumpPTextBox.Text = nPage.ToString();
            maxPage = PublicVar.bookTotalAmount / 10 + (PublicVar.bookTotalAmount % 10 == 0 ? 0 : 1);
            PageTextBox.Text = maxPage.ToString();
        }

        private void BookManageForm_Load(object sender, EventArgs e)
        {
            #region 返回按钮处理
            frmMain.ReturnButton.Tag = 1;//1 第一层  2 第二层
            Point t = new Point(61, 11);
            frmMain.ReturnButton.Show();
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
            NoResultTextBox.Hide();
            DataSheetLoad();
            SearchBox.Focus();
        }

        #region SearchResultForm 按钮动画处理
        private void SearchBox_KeyDown(object sender, KeyEventArgs e)//屏蔽换行回车键
        {
            if ((int)e.KeyCode == 13)
            {
                SearchButton.PerformClick();
            }
        }

        private void SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == System.Convert.ToChar(13))
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

        #endregion

        private void ResultDataSheet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {

                FileProtocol fileProtocol = new FileProtocol(RequestMode.UserBookLoad, 6000);
                fileProtocol.NowBook = PublicVar.currentBookList[e.RowIndex];

                fileProtocol.Userinfo = PublicVar.logUser;


                LoadingBox loadingBox = new LoadingBox(RequestMode.UserBookLoad, "正在加载", fileProtocol);
                loadingBox.ShowDialog();
                loadingBox.Dispose();

                if (PublicVar.ReturnValue == -233)
                {
                    return;
                }
                PublicVar.ReturnValue = -233;
                frmMain.MainPanel.Controls.Clear();
                AdminBookDetailForm bookDetailForm = new AdminBookDetailForm(frmMain, e.RowIndex);
                bookDetailForm.TopLevel = false;
                bookDetailForm.Dock = DockStyle.Fill;
                frmMain.MainPanel.Controls.Add(bookDetailForm);
                bookDetailForm.Show();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            NoResultTextBox.Hide();
            nPage = 1;
            lastState = ButtonState;
            lastString = SearchBox.Text;
            searchBook();
            PageButtonLoad(PublicVar.bookTotalAmount);
        }

        private void LastPButton_Click(object sender, EventArgs e)
        {
            if (nPage == 1) return;
            tmpPage = nPage;
            nPage--;
            searchBook();
            JumpPTextBox.Text = tmpPage.ToString();
            nPage = tmpPage;
            }

        private void NextPButton_Click(object sender, EventArgs e)
        {
            if (nPage == maxPage) return;
            tmpPage = nPage;
            nPage++;
            searchBook();
            JumpPTextBox.Text = tmpPage.ToString();
            nPage = tmpPage;
        }

        private void JumpPTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                nPage = Convert.ToInt32(JumpPTextBox.Text);
                // if(Convert.ToInt32(JumpPTextBox.Text)<)
                var JumpPage = Convert.ToInt32(JumpPTextBox.Text);
                if (JumpPage > maxPage)
                {
                    nPage = maxPage;
                    JumpPTextBox.Text = nPage.ToString();
                }
                else if (Convert.ToInt32(JumpPTextBox.Text) <= 1)
                {
                    nPage = 1;
                    JumpPTextBox.Text = nPage.ToString();
                }
                else nPage = Convert.ToInt32(JumpPTextBox.Text);
                searchBook();
            }
            catch
            {
                if (JumpPTextBox.Text == "") return;
                MessageBox infoBox = new MessageBox(13);
                infoBox.ShowDialog();
                infoBox.Dispose();
                JumpPTextBox.Focus();
            }

        }

        private void JumpPTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    tmpPage = nPage;
                    nPage = Convert.ToInt32(JumpPTextBox.Text.Trim());
                    // if(Convert.ToInt32(JumpPTextBox.Text)<)
                    var JumpPage = Convert.ToInt32(JumpPTextBox.Text);
                    if (JumpPage > maxPage)
                    {
                        nPage = maxPage;
                        //JumpPTextBox.Text = nPage.ToString();
                    }
                    else if (Convert.ToInt32(JumpPTextBox.Text) <= 1)
                    {
                        nPage = 1;
                        //JumpPTextBox.Text = nPage.ToString();
                    }
                    else nPage = Convert.ToInt32(JumpPTextBox.Text);
                    searchBook();
                    JumpPTextBox.Text = tmpPage.ToString();
                    nPage = tmpPage;

                }
                catch
                {
                    if (JumpPTextBox.Text == "") return;
                    MessageBox infoBox = new MessageBox(13);
                    infoBox.ShowDialog();
                    infoBox.Dispose();
                    JumpPTextBox.Focus();
                }
            }
            //JumpPTextBox_Leave(JumpPTextBox, new EventArgs());
        }

        private void JumpPTextBox_Leave_1(object sender, EventArgs e)
        {
            this.Focus();
        }
    }

}