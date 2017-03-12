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

namespace LIBRARY
{
    public partial class LoginForm : DMSkin.Main
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Win32Utility.SetCueText(UserTextBox, "用户名");
            // Win32Utility.SetCueText(PasswordTextBox, "密码");
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddEllipse(0, 0, 96, 96);
            //重新设置圆形按钮region范围
            RegisterButton.Region = new Region(myPath);
            LoginButton.Region = new Region(myPath);
        }

        private void ShutDownButton_Click(object sender, EventArgs e)
        {
            Tag = false;
            Environment.Exit(0);
        }

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
        private void LoginButton_Click(object sender, EventArgs e)
        {
            //if(login) tag=true;
            Tag = true;
            Close();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegistForm registForm = new RegistForm();
            registForm.ShowDialog();
            registForm.Dispose();
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
    }
}
