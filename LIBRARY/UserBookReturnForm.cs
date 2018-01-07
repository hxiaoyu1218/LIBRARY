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
using System.IO;

namespace LIBRARY
{
    public partial class UserBookReturnForm : DMSkin.Main
    {
        private UserMainForm frmMain;
        private int maxPage;
        private BackgroundWorker[] threadList;

        public UserBookReturnForm(UserMainForm frm)
        {


            threadList = new BackgroundWorker[20];
            for (int i = 0; i < 20; i++)
            {
                threadList[i].DoWork += new DoWorkEventHandler(BookImageRequest_DoWork);
                threadList[i].RunWorkerCompleted += new RunWorkerCompletedEventHandler(BookImageRequest_RunWorkerCompleted);
            }





            frmMain = frm;
            InitializeComponent();
            maxPage = ClassBackEnd.Userbsbook.Count > 10 ? 2 : 1;
            ComponentDynamicLoad(1);
        }
        private void PageButtonLoad()
        {
            if (ClassBackEnd.Userbsbook.Count == 0)
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
                    string isbn = ClassBackEnd.Userbsbook[i - 1].Bookisbn.Substring(0, 10);

                    pic.Image = Properties.Resources.BookNullImage;
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
                NameLink.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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

            UserReturnForm returnForm = new UserReturnForm(linkID);
            returnForm.ShowDialog();
            returnForm.Dispose();

            ClassBackEnd.LoadBorrowedBook();
            maxPage = ClassBackEnd.Userbsbook.Count > 10 ? 2 : 1;
            if (linkID > 9) ComponentDynamicLoad(2);
            else ComponentDynamicLoad(1);

        }
        private void pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            int picID = Convert.ToInt32(pic.Name);
            if (!ClassBackEnd.BorrowedBookIDown(picID))
            {
                MessageBox ib = new MessageBox(9);
                ib.ShowDialog();

            }
            UserReturnForm returnForm = new UserReturnForm(picID);
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
            if (Convert.ToInt32(JumpPTextBox.Text) == 1)
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
        private void BookImageRequest_DoWork(object sender, DoWorkEventArgs e)
        {
            int index = (int)sender;
            if (File.Exists(@"cache\" + PublicVar.nowBook.BookImage))
            {
                FileStream fileStream = File.Open(@"cache\" + PublicVar.nowBook.BookImage, FileMode.Open);
                byte[] buffer = new byte[PublicVar.IMAGE_MAX_SIZE];
                int size = fileStream.Read(buffer, 0, PublicVar.IMAGE_MAX_SIZE);
                PublicVar.picList[index] = buffer;
                fileStream.Close();
                return;
            }

            ServerClient serverClient = new ServerClient();
            FileProtocol fp = new FileProtocol(RequestMode.PicSend, 6000);
            fp.NowBook = new ClassBook(PublicVar.nowBook.BookIsbn);
            serverClient.SendMessage(fp.ToString());

            PublicVar.picList[index] = serverClient.receiveFileAsByte();
            e.Result = index;
        }

        private void BookImageRequest_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                Control[] p = Panel.Controls.Find(((int)e.Result).ToString(), false);

                ((PictureBox)p[0]).Image = PublicVar.BytesToImage((byte[])PublicVar.picList[(int)e.Result]);

            }
            catch (Exception ee)
            {
                System.Windows.Forms.MessageBox.Show(ee.Message);
                return;
            }
            FileStream fileStream = File.Open(@"cache\" + PublicVar.nowBook.BookImage, FileMode.Create);
            fileStream.Write(PublicVar.pic, 0, PublicVar.pic.Length);
            fileStream.Close();
        }
    }
}
