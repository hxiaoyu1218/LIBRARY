using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LIBRARY
{
    public partial class UserChangeInfo : DMSkin.Main
    {
        public UserChangeInfo()
        {
            InitializeComponent();
            //UserAlertLabel.Hide();
            //label4.Hide();
            label1.Hide();
            PWD1AlertLabel.Hide();
            PWD2AlertLabel.Hide();
        }

        #region 水印文字及按钮响应方法

        private void BgImage_Click(object sender, EventArgs e)
        {

        }

        private bool IsSchoolID(string input)
        {
            Regex regex = new Regex("^\\d{10}$");
            return regex.IsMatch(input);
        }
        private bool IsNumAndEnCh(string input)
        {
            string pattern = @"^[A-Za-z0-9]{6,12}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(input);
        }

        private void UserTextBox_Click(object sender, EventArgs e)
        {

        }

        private void UserCueText_Click(object sender, EventArgs e)
        {
            if (UserTextBox.Text.Trim() == "")
                UserCueText.Hide();
            else if (UserTextBox.Text.Trim() != "" && UserCueText.Visible == false)
            {
                UserCueText.Hide();
            }
            UserTextBox.Focus();
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

        private void AcademicCueText_Click(object sender, EventArgs e)
        {
            if (AcademicTextBox.Text.Trim() == "")
                AcademicCueText.Hide();
            else if (AcademicTextBox.Text.Trim() != "" && AcademicCueText.Visible == false)
            {
                AcademicCueText.Hide();
            }
            AcademicTextBox.Focus();
        }

        private void AcademicTextBox_Enter(object sender, EventArgs e)
        {
            if (AcademicTextBox.Text.Trim() == "")
                AcademicCueText.Hide();
            else if (AcademicTextBox.Text.Trim() != "" && AcademicCueText.Visible == false)
                AcademicCueText.Hide();
        }

        private void AcademicTextBox_Leave(object sender, EventArgs e)
        {
            if (AcademicTextBox.Text.Trim() == "")
                AcademicCueText.Show();
            else
                AcademicCueText.Hide();
        }

        private void OPasswordCueText_Click(object sender, EventArgs e)
        {
            if (OPasswordTextBox.Text.Trim() == "")
                OPasswordCueText.Hide();
            else if (OPasswordTextBox.Text.Trim() != "" && OPasswordCueText.Visible == false)
                OPasswordCueText.Hide();
            OPasswordTextBox.Focus();
        }

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

        private void OPasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (OPasswordTextBox.Text == "")
            {
                OPasswordCueText.Hide();
            }
        }

        private void OPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (OPasswordTextBox.Text == "")
            {
                OPasswordCueText.Show();
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
                if (IsNumAndEnCh(NPasswordTextBox1.Text) == false)
                {
                    PWD1AlertLabel.Show();
                    if (NPasswordTextBox1.Text != NPasswordTextBox2.Text && NPasswordTextBox2.Text != "" && PWD2AlertLabel.Visible == false)
                    {
                        PWD2AlertLabel.Show();
                    }
                }
                else
                {
                    if (NPasswordTextBox1.Text == NPasswordTextBox2.Text && PWD2AlertLabel.Visible == true)
                    {
                        PWD2AlertLabel.Hide();
                    }
                    else if (NPasswordTextBox1.Text != NPasswordTextBox2.Text && NPasswordTextBox2.Text != "" && PWD2AlertLabel.Visible == false)
                    {
                        PWD2AlertLabel.Show();
                    }
                    PWD1AlertLabel.Hide();
                    NPasswordCueText1.Hide();

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
                if (NPasswordTextBox1.Text != NPasswordTextBox2.Text)
                {
                    PWD2AlertLabel.Show();
                }
                else
                {
                    NPasswordCueText2.Hide();
                    PWD2AlertLabel.Hide();
                }
            }
        }

        private void OPasswordTextBox_Enter_1(object sender, EventArgs e)
        {
            if (OPasswordTextBox.Text.Trim() == "")
                OPasswordCueText.Hide();
            else if (OPasswordTextBox.Text.Trim() != "" && OPasswordCueText.Visible == false)
                OPasswordCueText.Hide();
        }

        private void OPasswordTextBox_Leave_1(object sender, EventArgs e)
        {
            if (OPasswordTextBox.Text.Trim() == "")
                OPasswordCueText.Show();
            else if (IsNumAndEnCh(OPasswordTextBox.Text) == false)
            {
                label1.Show();
            }
            else
                OPasswordCueText.Hide();
                
        }
        #endregion

        private void ShutDownButton_Click(object sender, EventArgs e)
        {
            Tag = false;
            Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if(OPasswordTextBox.Text!=PublicVar.logUser.UserPassword)
            {
                MessageBox ib = new MessageBox(15);
                ib.ShowDialog();
                ib.Dispose();
                return;
            }
            else if(label1.Visible==true||PWD1AlertLabel.Visible==true||PWD2AlertLabel.Visible==true)
            {
                MessageBox ib = new MessageBox(29);
                ib.ShowDialog();
                ib.Dispose();
                return;
            }
            else if(UserTextBox.Text.Trim()==""||AcademicTextBox.Text.Trim()=="")
            {
                MessageBox ib = new MessageBox(30);
                ib.ShowDialog();
                ib.Dispose();
                return;
            }
            else
            {
                ClassUserBasicInfo classUserBasicInfo = new ClassUserBasicInfo("", UserTextBox.Text, NPasswordTextBox2.Text, AcademicTextBox.Text, Usertype.Student);//此处和肖智轩核对
                FileProtocol fileProtocol = new FileProtocol(RequestMode.UserInfoChange, 6000);
                fileProtocol.Userinfo = classUserBasicInfo;
                
                LoadingBox loadingBox = new LoadingBox(RequestMode.UserInfoChange, "正在修改", fileProtocol);
                loadingBox.ShowDialog();
                loadingBox.Dispose();

                MessageBox ib = new MessageBox(3);
                ib.ShowDialog();
                ib.Dispose();
                Tag = true;
                //return;
                Close();
                
            }
            //Close();
        }
    }
}
