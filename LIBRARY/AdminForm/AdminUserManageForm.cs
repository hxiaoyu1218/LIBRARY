using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LIBRARY
{
    public partial class AdminUserManageForm : DMSkin.Main
    {
        private AdminMainForm frmMain;
        private static int maxPage;
        private static int nPage = 1;

        public AdminUserManageForm(AdminMainForm frm)
        {
            frmMain = frm;
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);
            //SearchBox.Focus();
        }

        private void UserManageForm_Load(object sender, EventArgs e)
        {
            SearchBox.Focus();
            #region 返回按钮处理
            frmMain.ReturnButton.Tag = 1;
            Point t = new Point(61, 11);
            frmMain.ReturnButton.Show();
            frmMain.TitleLabel.Location = t;
            #endregion
            PageButtonLoad(PublicVar.userTotalAmount);
            if (PublicVar.userTotalAmount == 0) return;
            maxPage = PublicVar.userTotalAmount / 15 + (PublicVar.userTotalAmount % 15 == 0 ? 0 : 1);
            JumpPTextBox.Text = nPage.ToString();
            //SearchBox.Focus();

            ComponentDynamicLoad(nPage);
            //SearchBox.Focus();
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
        private void ComponentDynamicLoad(int page)
        {
            UserPanel.Controls.Clear();

            PageButtonLoad(PublicVar.userTotalAmount);
            PageTextBox.Text = maxPage.ToString();

            int picX = 81, picY = 20;
            int nameX = 161, nameY = 16;
            int idX = 163, idY = 51;
            int aceX = 163, aceY = 72;
            
            for (int i = 1; i <= PublicVar.adminSearchUser.Length; i++)
            {
                PictureBox pic = new PictureBox();
                pic.BackColor = Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
                pic.Location = new System.Drawing.Point(picX, picY);
                pic.Name = (i - 1).ToString();
                pic.Size = new Size(74, 74);
                pic.SizeMode = PictureBoxSizeMode.AutoSize;
                pic.Cursor = Cursors.Hand;
                pic.TabIndex = 76;
                pic.TabStop = false;
                pic.Click += new EventHandler(Pic_Click);
                pic.MouseMove += new MouseEventHandler(Pic_MouseMove);
                pic.MouseLeave += new EventHandler(Pic_MouseLeave);
                pic.Image = PublicVar.PickHeadImage(PublicVar.adminSearchUser[i - 1].UserName);//image load

                Label lab = new Label();
                lab.AutoSize = true;
                lab.Font = new Font("微软雅黑", 20F);
                lab.Location = new Point(nameX, nameY);
                lab.Name = "a" + (i - 1).ToString();
                lab.Size = new Size(145, 35);
                lab.TabIndex = 91;
                lab.Cursor = Cursors.Hand;
                lab.Click += new EventHandler(Label_Click);
                lab.MouseMove += new MouseEventHandler(Label_MouseMove);
                lab.MouseLeave += new EventHandler(Label_MouseLeave);
                lab.Text = PublicVar.adminSearchUser[i - 1].UserName;//user name load

                Label lab1 = new Label();
                lab1.AutoSize = true;
                lab1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
                lab1.Location = new Point(idX, idY);
                lab1.Name = "b" + (i - 1).ToString();
                lab1.Size = new Size(100, 21);
                lab1.TabIndex = 92;
                lab1.Cursor = Cursors.Hand;
                lab1.Click += new EventHandler(Label_Click);
                lab1.MouseMove += new MouseEventHandler(Label_MouseMove);
                lab1.MouseLeave += new EventHandler(Label_MouseLeave);
                lab1.Text = PublicVar.adminSearchUser[i - 1].UserId;//load user id

                Label lab2 = new Label();
                lab2.AutoSize = true;
                lab2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
                lab2.Location = new Point(aceX, aceY);
                lab2.Name = "c" + (i - 1).ToString();
                lab2.Size = new Size(90, 21);
                lab2.TabIndex = 93;
                lab2.Cursor = Cursors.Hand;
                lab2.Click += new EventHandler(Label_Click);
                lab2.MouseMove += new MouseEventHandler(Label_MouseMove);
                lab2.MouseLeave += new EventHandler(Label_MouseLeave);
                lab2.Text = PublicVar.adminSearchUser[i - 1].UserSchool;//load acedemic name

                UserPanel.Controls.Add(pic);
                UserPanel.Controls.Add(lab);
                UserPanel.Controls.Add(lab1);
                UserPanel.Controls.Add(lab2);

                picX += 300;
                nameX += 300;
                idX += 300;
                aceX += 300;

                if (i % 3 == 0)
                {
                    picX = 81;
                    nameX = 161;
                    idX = 163;
                    aceX = 163;
                    picY += 108;
                    nameY += 108;
                    idY += 108;
                    aceY += 108;
                }
            }
        }

        private void searchUser(int page)
        {
            PublicVar.ReturnValue = -233;
            FileProtocol fileProtocol = new FileProtocol(RequestMode.AdminSearchUser, 6000);
            fileProtocol.Searchwords = SearchBox.Text.Trim();
            fileProtocol.Curnum = (page - 1) * 15 + 1;
            fileProtocol.Admin =new ClassAdmin(PublicVar.logUser.UserId);
            fileProtocol.Admin.Password = PublicVar.logUser.UserPassword;


            LoadingBox loadingBox = new LoadingBox(RequestMode.AdminSearchUser, "正在查询", fileProtocol);
            loadingBox.ShowDialog();
            loadingBox.Dispose();


            if (PublicVar.ReturnValue == -233)
            {
                return;
            }
            PublicVar.ReturnValue = -233;
            nPage = page;
            maxPage = PublicVar.userTotalAmount / 15 + (PublicVar.userTotalAmount % 15 == 0 ? 0 : 1);

            JumpPTextBox.Text = page.ToString();
            ComponentDynamicLoad(page);
        }
        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == 13)
            {
                SearchButton.PerformClick();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            searchUser(1);
        }
        private void Label_Click(object sender, EventArgs e)
        {
            Control c = sender as Control;
            string LabName = c.Name.Substring(1);
            int LabID = Convert.ToInt32(LabName);

            Label_Pic_Click(LabID);
        }
        private void Pic_Click(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            int PicID = Convert.ToInt32(p.Name);

            Label_Pic_Click(PicID);
           
        }
        private void Label_Pic_Click(int index)
        {
            PublicVar.ReturnValue = -233;
            FileProtocol fileProtocol = new FileProtocol(RequestMode.AdminGetUserDetail, 6000);

            fileProtocol.Userinfo = PublicVar.adminSearchUser[index];
            fileProtocol.Admin = new ClassAdmin(PublicVar.logUser.UserId);
            fileProtocol.Admin.Password = PublicVar.logUser.UserPassword;


            LoadingBox loadingBox = new LoadingBox(RequestMode.AdminGetUserDetail, "正在加载", fileProtocol);
            loadingBox.ShowDialog();
            loadingBox.Dispose();


            if (PublicVar.ReturnValue == -233)
            {
                return;
            }
            PublicVar.ReturnValue = -233;

            frmMain.MainPanel.Controls.Clear();
            AdminUserDetailForm userDetailAdminForm = new AdminUserDetailForm(frmMain, index);
            userDetailAdminForm.TopLevel = false;
            userDetailAdminForm.Dock = DockStyle.Fill;
            frmMain.MainPanel.Controls.Add(userDetailAdminForm);
            userDetailAdminForm.Show();
        }
        private void Label_MouseMove(object sender, EventArgs e)
        {
            Control c = sender as Control;
            string LabName = c.Name.Substring(1);
            int LabID = Convert.ToInt32(LabName);
            string LabelName1 = "a" + LabID.ToString();
            string LabelName2 = "b" + LabID.ToString();
            string LabelName3 = "c" + LabID.ToString();
            foreach (Control lab in UserPanel.Controls)
            {
                if (lab.Name == LabelName1 || lab.Name == LabelName2 || lab.Name == LabelName3)
                {
                    Label la = lab as Label;
                    la.Font = new Font(la.Font, FontStyle.Underline);
                }
            }
        }
        private void Pic_MouseMove(object sender, EventArgs e)
        {
            Control c = sender as Control;
            string PicName = c.Name;
            int PicID = Convert.ToInt32(PicName);
            string LabelName1 = "a" + PicID.ToString();
            string LabelName2 = "b" + PicID.ToString();
            string LabelName3 = "c" + PicID.ToString();
            foreach (Control lab in UserPanel.Controls)
            {
                if (lab.Name == LabelName1 || lab.Name == LabelName2 || lab.Name == LabelName3)
                {
                    Label la = lab as Label;
                    la.Font = new Font(la.Font, FontStyle.Underline);
                }
            }
        }
        private void Pic_MouseLeave(object sender, EventArgs e)
        {
            Control c = sender as Control;
            string PicName = c.Name;
            int PicID = Convert.ToInt32(PicName);
            string LabelName1 = "a" + PicID.ToString();
            string LabelName2 = "b" + PicID.ToString();
            string LabelName3 = "c" + PicID.ToString();
            foreach (Control lab in UserPanel.Controls)
            {
                if (lab.Name == LabelName1 || lab.Name == LabelName2 || lab.Name == LabelName3)
                {
                    Label la = lab as Label;
                    la.Font = new Font(la.Font, FontStyle.Regular);
                }
            }
        }
        private void Label_MouseLeave(object sender, EventArgs e)
        {
            Control c = sender as Control;
            string LabName = c.Name.Substring(1);
            int LabID = Convert.ToInt32(LabName);
            string LabelName1 = "a" + LabID.ToString();
            string LabelName2 = "b" + LabID.ToString();
            string LabelName3 = "c" + LabID.ToString();
            foreach (Control lab in UserPanel.Controls)
            {
                if (lab.Name == LabelName1 || lab.Name == LabelName2 || lab.Name == LabelName3)
                {
                    Label la = lab as Label;
                    la.Font = new Font(la.Font, FontStyle.Regular);
                }
            }
        }
        private void LastPButton_Click(object sender, EventArgs e)
        {
            if (nPage == 1) return;
            JumpPTextBox.Text = (--nPage).ToString();
            searchUser(nPage);
        }

        private void NextPbutton_Click(object sender, EventArgs e)
        {
            if (nPage == maxPage) return;
            JumpPTextBox.Text = (++nPage).ToString();
            searchUser(nPage);
        }

        private void SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == System.Convert.ToChar(13))
            {
                e.Handled = true;
            }
        }

        private void JumpPTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == 13)
            {
                SearchButton.PerformClick();
            }
        }

        private void SearchButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SearchButton_Click(SearchButton, new EventArgs());
        }
    }

}