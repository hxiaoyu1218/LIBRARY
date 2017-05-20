using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using LibrarySystemBackEnd;

namespace LIBRARY
{
    public partial class UserManageForm : DMSkin.Main
    {
        private AdminMainForm frmMain;
        private static int maxPage;
        private static int nPage = 1;

        public UserManageForm(AdminMainForm frm)
        {
            frmMain = frm;
            InitializeComponent();

        }

        private void UserManageForm_Load(object sender, EventArgs e)
        {
          
            #region 返回按钮处理
            frmMain.ReturnButton.Tag = 1;
            Point t = new Point(61, 11);
            frmMain.ReturnButton.Show();
            frmMain.TitleLabel.Location = t;
            #endregion
            if (ClassBackEnd.UsersearchList.Count == 0) return;
            maxPage = (ClassBackEnd.UsersearchList.Count - 1) / 15 + 1;
            JumpPTextBox.Text = nPage.ToString();

           ComponentDynamicLoad(nPage);
        }
        private void PageButtonLoad()
        {
            //if ( == 0)
            //{
            //    LastPButton.Hide();
            //    NextPbutton.Hide();
            //    JumpPTextBox.Hide();
            //    PageTextBox.Hide();
            //    DividePicture.Hide();
            //}
            //else
            //{
            //    LastPButton.Show();
            //    NextPbutton.Show();
            //    JumpPTextBox.Show();
            //    PageTextBox.Show();
            //    DividePicture.Show();
            //}
        }
        private void ComponentDynamicLoad(int page)
        {
            UserPanel.Controls.Clear();


            //PageButtonLoad();
            PageTextBox.Text = maxPage.ToString();

            int picX = 81, picY = 20;
            int nameX = 161, nameY = 16;
            int idX = 163, idY = 51;
            int aceX = 163, aceY = 72;

            int start = (page - 1) * 15 + 1;
            int end = page * 15;
            if (page == maxPage) end = ClassBackEnd.UsersearchList.Count;


            for (int i = start; i <= end; i++)
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
                pic.Image = Guest.LoadHeadImage(ClassBackEnd.UsersearchList[i - 1].Username);//image load

                Label lab = new Label();
                lab.AutoSize = true;
                lab.Font = new Font("微软雅黑", 20F);
                lab.Location = new Point(nameX, nameY);
                lab.Name = "a" + (i - 1).ToString();
                lab.Size = new Size(145, 35);
                lab.TabIndex = 91;
                lab.Cursor = Cursors.Hand;
                lab.Click += new EventHandler(Label_Click);
                lab.Text = ClassBackEnd.UsersearchList[i - 1].Username;//user name load

                Label lab1 = new Label();
                lab1.AutoSize = true;
                lab1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
                lab1.Location = new Point(idX, idY);
                lab1.Name = "b" + (i - 1).ToString();
                lab1.Size = new Size(100, 21);
                lab1.TabIndex = 92;
                lab1.Cursor = Cursors.Hand;
                lab1.Click += new EventHandler(Label_Click);
                lab1.Text = ClassBackEnd.UsersearchList[i - 1].Userid;//load user id

                Label lab2 = new Label();
                lab2.AutoSize = true;
                lab2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
                lab2.Location = new Point(aceX, aceY);
                lab2.Name = "c" + (i - 1).ToString();
                lab2.Size = new Size(90, 21);
                lab2.TabIndex = 93;
                lab2.Cursor = Cursors.Hand;
                lab2.Click += new EventHandler(Label_Click);
                lab2.Text = ClassBackEnd.UsersearchList[i - 1].School;//load acedemic name

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

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SearchButton_Click(sender, e);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            ClassBackEnd.SearchUser(SearchBox.Text);
            nPage = 1;

            if (ClassBackEnd.UsersearchList.Count == 0) return;
            maxPage = (ClassBackEnd.UsersearchList.Count - 1) / 15 + 1;
            JumpPTextBox.Text = "1";
            ComponentDynamicLoad(1);
        }
        private void Label_Click(object sender, EventArgs e)
        {
            Control c = sender as Control;
            string LabName = c.Name.Substring(1);
            int LabID = Convert.ToInt32(LabName);
            //to do
            frmMain.MainPanel.Controls.Clear();
            UserDetailAdminForm userDetailAdminForm = new UserDetailAdminForm(frmMain, LabID);
            userDetailAdminForm.TopLevel = false;
            userDetailAdminForm.Dock = DockStyle.Fill;
            frmMain.MainPanel.Controls.Add(userDetailAdminForm);
            userDetailAdminForm.Show();
        }
        private void Pic_Click(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            int PicID = Convert.ToInt32(p.Name);
            //to do
            frmMain.MainPanel.Controls.Clear();
            UserDetailAdminForm userDetailAdminForm = new UserDetailAdminForm(frmMain, PicID);
            userDetailAdminForm.TopLevel = false;
            userDetailAdminForm.Dock = DockStyle.Fill;
            frmMain.MainPanel.Controls.Add(userDetailAdminForm);
            userDetailAdminForm.Show();
        }

        private void LastPButton_Click(object sender, EventArgs e)
        {
            if (nPage == 1) return;
            JumpPTextBox.Text = (--nPage).ToString();
            ComponentDynamicLoad(nPage);
        }

        private void NextPbutton_Click(object sender, EventArgs e)
        {
            if (nPage == maxPage) return;
            JumpPTextBox.Text = (++nPage).ToString();
            ComponentDynamicLoad(nPage);
        }

        private void JumpPTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var JumpPage = Convert.ToInt32(JumpPTextBox.Text);
                if (JumpPage > maxPage)
                {
                    nPage = maxPage;
                    JumpPTextBox.Text = nPage.ToString();
                }
                else nPage = Convert.ToInt32(JumpPTextBox.Text);
                ComponentDynamicLoad(nPage);
            }
            catch
            {
                if (JumpPTextBox.Text == "") return;
                InfoBox infoBox = new InfoBox(13);
                infoBox.ShowDialog();
                infoBox.Dispose();
                JumpPTextBox.Focus();
            }
        }
    }

}