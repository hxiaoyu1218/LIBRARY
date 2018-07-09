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
using System.Text.RegularExpressions;

namespace LIBRARY
{
    public partial class PasswordResetForm : DMSkin.Main
    {
        private string userID;
        public PasswordResetForm(string _userId)
        {
            userID = _userId;
            InitializeComponent();
        }

        private void PasswordChangeForm_Load(object sender, EventArgs e)
        {
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddEllipse(0, 0, 80, 80);
            OKButton.Region = new Region(myPath);
        }
        private bool IsNumAndEnCh(string input)
        {
            string pattern = @"^[A-Za-z0-9]{6,12}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(input);
        }

        private void ShutDownButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        #region 按钮水印处理


        private void NPasswordCueText1_Click(object sender, EventArgs e)
        {
            if (NPasswordTextBox1.Text == "")
            {
                NPasswordCueText1.Hide();
                NPasswordTextBox1.Focus();
            }
        }

        private void NPasswordCueText2_Click(object sender, EventArgs e)
        {
            if (NPasswordTextBox2.Text == "")
            {
                NPasswordCueText2.Hide();
                NPasswordTextBox2.Focus();
            }
        }


        private void NPasswordTextBox1_Enter(object sender, EventArgs e)
        {
            if (NPasswordTextBox1.Text == "")
            {
                NPasswordCueText1.Hide();
            }
        }

        private void NPasswordTextBox1_Leave(object sender, EventArgs e)
        {
            if (NPasswordTextBox1.Text == "")
            {
                NPasswordCueText1.Show();
            }
            else
            {
                if (!IsNumAndEnCh(NPasswordTextBox1.Text.Trim()))
                {
                    PWD1AlertLabel.Visible = true;
                }
                else
                {
                    PWD1AlertLabel.Visible = false;
                }
            }
        }

        private void NPasswordTextBox2_Enter(object sender, EventArgs e)
        {
            if (NPasswordTextBox2.Text == "")
            {
                NPasswordCueText2.Hide();
            }
        }

        private void NPasswordTextBox2_Leave(object sender, EventArgs e)
        {
            if (NPasswordTextBox2.Text == "")
            {
                NPasswordCueText2.Show();
            }
            else
            {
                if (NPasswordTextBox1.Text.Trim() != NPasswordTextBox2.Text.Trim())
                {
                    PWD2AlertLabel.Visible = true;
                }
                else
                {
                    PWD2AlertLabel.Visible = false;
                }
            }
        }
        #endregion
        private void OKButton_MouseMove(object sender, MouseEventArgs e)
        {
            OKButton.BackgroundImage = OKButton.DM_HoverImage;
        }

        private void OKButton_MouseLeave(object sender, EventArgs e)
        {
            OKButton.BackgroundImage = OKButton.DM_NolImage;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (NPasswordTextBox1.Text.Trim() == "" || NPasswordTextBox2.Text.Trim() == "")
            {
                return;
            }
            else
            {
                PublicVar.ReturnValue = -233;

                FileProtocol fileProtocol = new FileProtocol(RequestMode.AdminSetUserPassword, 6000);
                fileProtocol.Userinfo = new ClassUserBasicInfo(userID);
                fileProtocol.Userinfo.UserPassword = NPasswordTextBox1.Text.Trim();
                fileProtocol.Admin = new ClassAdmin(PublicVar.logUser.UserId);
                fileProtocol.Admin.Password = PublicVar.logUser.UserPassword;


                LoadingBox loadingBox = new LoadingBox(RequestMode.AdminSetUserPassword, "正在提交", fileProtocol);
                loadingBox.ShowDialog();
                loadingBox.Dispose();

                if (PublicVar.ReturnValue == -233)
                {
                    return;
                }
                else if (PublicVar.ReturnValue == 0)
                {//3
                    MessageBox ms = new MessageBox(3);
                    ms.ShowDialog();
                    ms.Dispose();
                    PublicVar.ReturnValue = -233;
                    Close();
                }
                else
                {
                    MessageBox ms = new MessageBox(9);
                    ms.ShowDialog();
                    ms.Dispose();
                    PublicVar.ReturnValue = -233;
                }

            }

        }


    }
}
