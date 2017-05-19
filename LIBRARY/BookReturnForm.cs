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
        public BookReturnForm(UserMainForm frm)
        {
            ClassBackEnd.LoadBorrowedBook();

            frmMain = frm;
            InitializeComponent();
            ComponentDynamicLoad(ClassBackEnd.Userbsbook.Count);     
        }
        private void ComponentDynamicLoad(int num)
        {        
            Panel.Controls.Clear();
            int x = 86, y = 138;
            int x1 = 103, y1 = 341;
            for (int i = 1; i <= num; i++)
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
                   pic.Image = Image.FromFile(@"data/book/" + ClassBackEnd.Userbsbook[i-1].Bookisbn.Substring(0,10) + ".jpg");
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
                NameLink.AutoSize = true;
                NameLink.BackColor = Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
                NameLink.Font = new Font("微软雅黑", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
                NameLink.LinkBehavior = LinkBehavior.HoverUnderline;
                NameLink.LinkColor = Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
                NameLink.Location = new Point(x1, y1);
                NameLink.Name = (i-1).ToString();
                NameLink.Size = new Size(107, 25);
                NameLink.TabStop = false;
                NameLink.Text = ClassBackEnd.Userbsbook[i-1].Bookname;
                NameLink.Click += new EventHandler(NameLink_Click);
                Panel.Controls.Add(NameLink);
                x1 += 170;

                if (i % 5 == 0)
                {
                    y = 399;y1 = 602;
                    x = 86;x1 = 103;
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
            ComponentDynamicLoad(ClassBackEnd.Userbsbook.Count);

        }
        private void pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            int picID = Convert.ToInt32(pic.Name);
            if(!ClassBackEnd.BorrowedBookIDown(picID))
            {
                InfoBox ib = new InfoBox(9);
                ib.ShowDialog();

            }
            ReturnForm returnForm = new ReturnForm(picID);
            returnForm.ShowDialog();
            returnForm.Dispose();

            ClassBackEnd.LoadBorrowedBook();
            ComponentDynamicLoad(ClassBackEnd.Userbsbook.Count);
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
    }
}
