using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.Compression;
using System.Threading;

namespace LIBRARY
{
    public partial class LoginForm : DMSkin.Main
    {
        private static string RememberMeFileName = @"remember.lbs";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

            GraphicsPath myPath = new GraphicsPath();
            myPath.AddEllipse(0, 0, 96, 96);
            RegisterButton.Region = new Region(myPath);
            LoginButton.Region = new Region(myPath);

            string name = "";
            string pass = "";

            RememberMeRead(ref name, ref pass);

            if (name != "")
            {
                UserTextBox.Text = name;
                PasswordTextBox.Text = pass;
                RememberCheckBox.Checked = true;


                UserCueText.Hide();
                PasswordCueText.Hide();

            }
        }

        private void ShutDownButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        #region 按钮动画和水印文字
        private void RegisterButton_MouseMove(object sender, MouseEventArgs e)
        {
            RegisterButton.BackgroundImage = RegisterButton.DM_HoverImage;
        }

        private void RegisterButton_MouseLeave(object sender, EventArgs e)
        {
            RegisterButton.BackgroundImage = RegisterButton.DM_NolImage;
        }

        private void LoginButton_MouseMove(object sender, MouseEventArgs e)
        {
            LoginButton.BackgroundImage = LoginButton.DM_HoverImage;
        }

        private void LoginButton_MouseLeave(object sender, EventArgs e)
        {
            LoginButton.BackgroundImage = LoginButton.DM_NolImage;
        }

        private void UserTextBox_Enter(object sender, EventArgs e)
        {
            if (UserTextBox.Text.Trim() == "")
                UserCueText.Hide();
            else if (UserTextBox.Text.Trim() != "" && UserCueText.Visible == false)
                UserCueText.Hide();
        }

        private void UserTextBox_Leave(object sender, EventArgs e)
        {
            if (UserTextBox.Text.Trim() == "")
                UserCueText.Show();
            else
                UserCueText.Hide();
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text.Trim() == "")
                PasswordCueText.Hide();
            else if (PasswordTextBox.Text.Trim() != "" && PasswordCueText.Visible == false)
                PasswordCueText.Hide();
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text.Trim() == "")
                PasswordCueText.Show();
            else
                PasswordCueText.Hide();
        }
        private void UserCueText_Click(object sender, EventArgs e)
        {
            if (UserTextBox.Text.Trim() == "")
                UserCueText.Hide();
            else if (UserTextBox.Text.Trim() != "" && UserCueText.Visible == false)
                UserCueText.Hide();
            UserTextBox.Focus();
        }

        private void PasswordCueText_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text.Trim() == "")
                PasswordCueText.Hide();
            else if (PasswordTextBox.Text.Trim() != "" && PasswordCueText.Visible == false)
                PasswordCueText.Hide();
            PasswordTextBox.Focus();
        }
        #endregion

        private void LoginButton_Click(object sender, EventArgs e)
        {
            ClassUserBasicInfo classUserBasicInfo = new ClassUserBasicInfo(UserTextBox.Text, "", PasswordTextBox.Text, "", Usertype.Student);
            FileProtocol fileProtocol = new FileProtocol(RequestMode.UserLogin, 6000);
            fileProtocol.Userinfo = classUserBasicInfo;



            LoadingBox loadingBox = new LoadingBox(RequestMode.UserLogin, "正在登录", fileProtocol);
            loadingBox.ShowDialog();
            loadingBox.Dispose();

            if(PublicVar.ReturnValue==-233)
            {
                return;
            }

            var v = PublicVar.ReturnValue;
            if (v == 1)//用户登录
            {

                PublicVar.ReturnValue = -233;
                PublicVar.logUser = new ClassUserBasicInfo(UserTextBox.Text);
                PublicVar.logUser.UserPassword = PasswordTextBox.Text;


                if (RememberCheckBox.Checked == true)
                {
                    RememberMeWrite(true, UserTextBox.Text, PasswordTextBox.Text);
                }
                else
                {
                    RememberMeWrite(false);
                }
                PublicVar.ReturnValue = -233;
                Tag = 1;
                Close();
            }
            else if (v == 2)//管理员登录
            {
                PublicVar.ReturnValue = -233;
                PublicVar.logUser = new ClassUserBasicInfo(UserTextBox.Text);
                PublicVar.logUser.UserPassword = PasswordTextBox.Text;

                if (RememberCheckBox.Checked == true)
                {
                    RememberMeWrite(true, UserTextBox.Text, PasswordTextBox.Text);
                }
                else
                {
                    RememberMeWrite(false);
                }
                PublicVar.ReturnValue = -233;
                Tag = 2;
                Close();
            }
            else if (v == 0)
            {
                MessageBox ib = new MessageBox(5);
                ib.ShowDialog();
                ib.Dispose();
                PublicVar.ReturnValue = -233;
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegistForm registForm = new RegistForm(this);
            registForm.ShowDialog();
            Show();
            registForm.Dispose();
        }

        private void GuestLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Tag = 1;
            PublicVar.GuestFlag = 1;
			PublicVar.logUser = new ClassUserBasicInfo("");
			PublicVar.logUser.UserPassword = "";
            Close();
        }
        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                LoginButton_Click(sender, e);
            }
        }

        private void RememberMeRead(ref string username, ref string userpassword)
        {
            FileStream fs = null; GZipStream gzip = null; StreamReader sr = null;
            try
            {
                fs = new FileStream(RememberMeFileName, FileMode.OpenOrCreate);
                gzip = new GZipStream(fs, CompressionMode.Decompress);
                sr = new StreamReader(gzip);

                while (!sr.EndOfStream)
                {
                    username = sr.ReadLine();
                    userpassword = sr.ReadLine();
                }
            }
            catch { return; }
            finally
            {
                if (sr != null) sr.Close();
                if (gzip != null) gzip.Close();
                if (fs != null) fs.Close();
            }
        }

        private void RememberMeWrite(bool rem, string username = "", string userpassword = "")
        {
            FileStream fs = null; GZipStream gzip = null; StreamWriter sw = null;
            try
            {
                fs = new FileStream(RememberMeFileName, FileMode.Create);
                gzip = new GZipStream(fs, CompressionMode.Compress);
                sw = new StreamWriter(gzip);

                if (rem == true)
                {
                    sw.WriteLine(username);
                    sw.WriteLine(userpassword);
                }
            }
            catch { return; }
            finally
            {
                if (sw != null) sw.Close();
                if (gzip != null) gzip.Close();
                if (fs != null) fs.Close();
            }
        }

        private void PasswordForgetLink_Click(object sender, EventArgs e)
        {
            MessageBox infoBox = new MessageBox(27);
            infoBox.ShowDialog();
            infoBox.Dispose();
        }

        private void PasswordForgetLink_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
			MessageBox box = new MessageBox(27);
			box.ShowDialog();
			box.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginButton_Click(LoginButton, new EventArgs());
        }
    }
}
