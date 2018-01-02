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
using System.Text.RegularExpressions;
using System.Threading;

namespace LIBRARY
{
    public partial class RegistForm : DMSkin.Main
    {
        private LoginForm loginfrm;
        public RegistForm(LoginForm lf)
        {
            loginfrm = lf;
            InitializeComponent();
        }

        private void RegistForm_Load(object sender, EventArgs e)
        {
            loginfrm.Hide();
            
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

        private void ShutDownButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        #region 水印文字及按钮响应方法
        private void StudentCheckBox_Click(object sender, EventArgs e)
        {
            if (TeacherCheckBox.Checked)
            {
                StudentCheckBox.Checked = true;
                TeacherCheckBox.Checked = false;
            }
            else StudentCheckBox.Checked = true;
        }

        private void TeacherCheckBox_Click(object sender, EventArgs e)
        {
            if (StudentCheckBox.Checked)
            {
                StudentCheckBox.Checked = false;
                TeacherCheckBox.Checked = true;
            }
            else TeacherCheckBox.Checked = true;
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

        private void PasswordTextBox1_Enter(object sender, EventArgs e)
        {
            if (PasswordTextBox1.Text.Trim() == "")
                PasswordCueText1.Hide();
            else if (PasswordTextBox1.Text.Trim() != "" && PasswordCueText1.Visible == false)
                PasswordCueText1.Hide();
        }

        private void PasswordTextBox1_Leave(object sender, EventArgs e)
        {
            if (PasswordTextBox1.Text.Trim() == "")
                PasswordCueText1.Show();
            else
            {
                if (IsNumAndEnCh(PasswordTextBox1.Text) == false)
                {
                    PWD1AlertLabel.Show();
                    if (PasswordTextBox1.Text != PasswordTextBox2.Text && PasswordTextBox2.Text != "" && PWD2AlertLabel.Visible == false)
                    {
                        PWD2AlertLabel.Show();
                    }
                }
                else
                {
                    if (PasswordTextBox1.Text == PasswordTextBox2.Text && PWD2AlertLabel.Visible == true)
                    {
                        PWD2AlertLabel.Hide();
                    }
                    else if (PasswordTextBox1.Text != PasswordTextBox2.Text && PasswordTextBox2.Text != "" && PWD2AlertLabel.Visible == false)
                    {
                        PWD2AlertLabel.Show();
                    }
                    PWD1AlertLabel.Hide();
                    PasswordCueText1.Hide();

                }
            }

        }

        private void PasswordTextBox2_Enter(object sender, EventArgs e)
        {
            if (PasswordTextBox2.Text.Trim() == "")
                PasswordCueText2.Hide();
            else if (PasswordTextBox2.Text.Trim() != "" && PasswordCueText2.Visible == false)
                PasswordCueText2.Hide();
        }

        private void PasswordTextBox2_Leave(object sender, EventArgs e)
        {
            if (PasswordTextBox2.Text.Trim() == "")
                PasswordCueText2.Show();
            else
            {
                if (PasswordTextBox1.Text != PasswordTextBox2.Text)
                {
                    PWD2AlertLabel.Show();
                }
                else
                {
                    PasswordCueText2.Hide();
                    PWD2AlertLabel.Hide();
                }
            }

        }

        private void PasswordCueText1_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox1.Text.Trim() == "")
                PasswordCueText1.Hide();
            else if (PasswordCueText1.Text.Trim() != "" && PasswordCueText1.Visible == false)
                PasswordCueText1.Hide();
            PasswordTextBox1.Focus();
        }

        private void PasswordCueText2_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox2.Text.Trim() == "")
                PasswordCueText2.Hide();
            else if (PasswordCueText2.Text.Trim() != "" && PasswordCueText2.Visible == false)
                PasswordCueText2.Hide();
            PasswordTextBox2.Focus();
        }

        private void UserCueText_Click(object sender, EventArgs e)
        {
            if (UserTextBox.Text.Trim() == "")
                UserCueText.Hide();
            else if (UserTextBox.Text.Trim() != "" && UserCueText.Visible == false)
                UserCueText.Hide();
            UserTextBox.Focus();
        }

        private void IDCueText_Click(object sender, EventArgs e)
        {
            if (IDTextBox.Text.Trim() == "")
                IDCueText.Hide();
            else if (IDTextBox.Text.Trim() != "" && IDCueText.Visible == false)
                IDCueText.Hide();
            IDTextBox.Focus();
        }

        private void IDTextBox_Enter(object sender, EventArgs e)
        {
            if (IDTextBox.Text.Trim() == "")
                IDCueText.Hide();
            else if (IDTextBox.Text.Trim() != "" && IDCueText.Visible == false)
                IDCueText.Hide();
        }

        private void IDTextBox_Leave(object sender, EventArgs e)
        {
            if (IDTextBox.Text.Trim() == "")
                IDCueText.Show();
            else
            {
                if (IsSchoolID(IDTextBox.Text) == false)
                {
                    IDAlertLabel.Show();
                }
                else
                {
                    IDAlertLabel.Hide();
                    IDCueText.Hide();
                }

            }

        }

        private void AcademicCueText_Click(object sender, EventArgs e)
        {
            if (AcademicTextBox.Text.Trim() == "")
                AcademicCueText.Hide();
            else if (AcademicTextBox.Text.Trim() != "" && AcademicCueText.Visible == false)
                AcademicCueText.Hide();
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

        private void ReturnButton_MouseMove(object sender, MouseEventArgs e)
        {
            ReturnButton.BackgroundImage = ReturnButton.DM_HoverImage;
        }

        private void ReturnButton_MouseLeave(object sender, EventArgs e)
        {
            ReturnButton.BackgroundImage = ReturnButton.DM_NolImage;
        }

        private void RegistButton_MouseMove(object sender, MouseEventArgs e)
        {
            RegistButton.BackgroundImage = RegistButton.DM_HoverImage;
        }

        private void RegistButton_MouseLeave(object sender, EventArgs e)
        {
            RegistButton.BackgroundImage = RegistButton.DM_NolImage;
        }
        #endregion




        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RegistButton_Click(object sender, EventArgs e)
        {


            if (IDAlertLabel.Visible == true || PWD1AlertLabel.Visible == true || PWD2AlertLabel.Visible == true)
            {
                MessageBox ib = new MessageBox(10);
                ib.ShowDialog();
                ib.Dispose();
                return;
            }
            Usertype type = Usertype.Guest;
            if (StudentCheckBox.Checked == true) type = Usertype.Student;
            else if (TeacherCheckBox.Checked == true) type = Usertype.Lecturer;

            if (type == Usertype.Guest)
            {
                MessageBox ib = new MessageBox(6);
                ib.ShowDialog();
                ib.Dispose();
                return;
            }

            ClassUserBasicInfo classUserBasicInfo = new ClassUserBasicInfo(IDTextBox.Text, UserTextBox.Text, PasswordTextBox1.Text, AcademicTextBox.Text, type);
            FileProtocol fileProtocol = new FileProtocol(RequestMode.UserRegist, 6000);
            fileProtocol.Userinfo = classUserBasicInfo;
            

            LoadingBox loadingBox = new LoadingBox(RequestMode.UserRegist, "正在注册", fileProtocol);
            loadingBox.ShowDialog();
            loadingBox.Dispose();

            var v = PublicVar.ReturnValue;
            //暂时无取消功能
            if(v==-2333)//cancel
            {
                v = -233;
                return;
            }
            if (v == 1)//success
            {
                PublicVar.ReturnValue = -233;
                MessageBox ib = new MessageBox(4);
                ib.ShowDialog();
                ib.Dispose();
                Close();
            }
            else//id error
            {
                PublicVar.ReturnValue = -233;
                MessageBox ib = new MessageBox(7);
                ib.ShowDialog();
                ib.Dispose();
            }
        }
    }
}
