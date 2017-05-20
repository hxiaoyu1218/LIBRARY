using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarySystemBackEnd;

namespace LIBRARY
{
    public partial class BookReturnForm : DMSkin.Main
    {
        private UserMainForm frmMain;
        private int maxPage;
        public BookReturnForm(UserMainForm frm)
        {
            ClassBackEnd.LoadBorrowedBook();

            frmMain = frm;
            InitializeComponent();
            maxPage = ClassBackEnd.Userbsbook.Count > 10 ? 2 : 1;
            ComponentDynamicLoad(1);
        }
        private void PageButtonLoad()
        {
            if(ClassBackEnd.Userbsbook.Count==0)
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
        private void ComponentDynamicLoad(int page)
        {
            Panel.Controls.Clear();
            PageButtonLoad();

            PageTextBox.Text = maxPage.ToString();
            JumpPTextBox.Text = page.ToString();

            int start = (page - 1) * 10 + 1;
            int end = page * 10;
            if (page == maxPage) end = ClassBackEnd.Userbsbook.Count;
            int num = end - start + 1;
            int x = 86, y = 48;
            int x1 = 86, y1 = 251;
            for (int i = start, j = 1; i <= end; j++, i++)
            {
                PictureBox pic = new PictureBox();
                pic.Cursor = Cursors.Hand;
                pic.BackColor = Color.FromArgb(244, 244, 244);
                pic.BorderStyle = BorderStyle.FixedSingle;
                pic.Dock = DockStyle.None;
                pic.Enabled = true;
                pic.Size = new Size(140, 200);
                try
                {
                    pic.Image = Image.FromFile(@"data/book/" + ClassBackEnd.Userbsbook[i - 1].Bookisbn.Substring(0, 10) + ".jpg");
                }
                catch
                {
                    pic.Image = Properties.Resources.BookNullImage;//set default image
                }
                pic.Location = new Point(x, y);
                pic.Name = (i - 1).ToString();
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Click += new EventHandler(pic_Click);
                Panel.Controls.Add(pic);
                x += 170;

                LinkLabel NameLink = new LinkLabel();
                NameLink.ActiveLinkColor = Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
                NameLink.AutoSize = false;
                NameLink.TextAlign= System.Drawing.ContentAlignment.TopCenter;
                NameLink.BackColor = System.Drawing.Color.Transparent;
                NameLink.Font = new Font("微软雅黑", 13F, FontStyle.Regular, GraphicsUnit.Point, 134);
                NameLink.LinkBehavior = LinkBehavior.HoverUnderline;
                NameLink.LinkColor = Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
                NameLink.Location = new Point(x1, y1);
                NameLink.Name = (i - 1).ToString();
                NameLink.Size = new Size(140, 55);
                NameLink.TabStop = false;
                NameLink.Text = ClassBackEnd.Userbsbook[i - 1].Bookname;
                NameLink.Click += new EventHandler(NameLink_Click);
                Panel.Controls.Add(NameLink);
                x1 += 170;

                if (j % 5 == 0)
                {
                    y = 309; y1 = 512;
                    x = 86; x1 = 86;
                }
            }
            if (num == 0) RemindLabel.Show();
            else RemindLabel.Hide();
            RemindLabel.Parent = Panel;
        }
        private void NameLink_Click(object sender, EventArgs e)
        {
            LinkLabel link = sender as LinkLabel;
            int linkID = Convert.ToInt32(link.Name);

            ClassBackEnd.BorrowedBookIDown(linkID);

            ReturnForm returnForm = new ReturnForm(linkID);
            returnForm.ShowDialog();
            returnForm.Dispose();

            ClassBackEnd.LoadBorrowedBook();
            maxPage = ClassBackEnd.Userbsbook.Count > 10 ? 2 : 1;
            if (linkID>9) ComponentDynamicLoad(2);
            else ComponentDynamicLoad(1);

        }
        private void pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            int picID = Convert.ToInt32(pic.Name);
            if (!ClassBackEnd.BorrowedBookIDown(picID))
            {
                InfoBox ib = new InfoBox(9);
                ib.ShowDialog();

            }
            ReturnForm returnForm = new ReturnForm(picID);
            returnForm.ShowDialog();
            returnForm.Dispose();

            ClassBackEnd.LoadBorrowedBook();
            maxPage = ClassBackEnd.Userbsbook.Count > 10 ? 2 : 1;
            if (picID > 9) ComponentDynamicLoad(2);
            else ComponentDynamicLoad(1);
        }
        private void BookReturnForm_Load(object sender, EventArgs e)
        {
            #region 返回按钮处理
            frmMain.ReturnButton.Tag = 1;//1 第一层  2 第二层
            Point t = new Point(61, 11);
            frmMain.ReturnButton.Show();
            frmMain.TitleLabel.Location = t;
            #endregion
        }

        private void LastPButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(JumpPTextBox.Text)==1)
            {
                return;
            }
            else
            {
                ComponentDynamicLoad(Convert.ToInt32(JumpPTextBox.Text) - 1);
                JumpPTextBox.Text = "1";
            }
        }

        private void NextPbutton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(JumpPTextBox.Text) == maxPage)
            {
                return;
            }
            else
            {
                ComponentDynamicLoad(Convert.ToInt32(JumpPTextBox.Text) + 1);
                JumpPTextBox.Text = "2";
            }
        }
    }
}
