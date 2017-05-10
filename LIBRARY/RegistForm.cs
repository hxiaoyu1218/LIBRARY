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
                PasswordCueText1.Hide();
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
                PasswordCueText2.Hide();
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
                IDCueText.Hide();
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
            if (PasswordTextBox1.Text != PasswordTextBox2.Text)
            {
                InfoBox ib = new InfoBox(10);
                ib.ShowDialog();
                ib.Dispose();
                return;
            }
            USERTYPE type = USERTYPE.Guest;
            if (StudentCheckBox.Checked == true) type = USERTYPE.Student;
            else if (TeacherCheckBox.Checked == true) type = USERTYPE.Lecturer;

            if (type == 0)
            {
                InfoBox ib = new InfoBox(6);
                ib.ShowDialog();
                ib.Dispose();
                return;
            }
            var v = ClassBackEnd.Register(IDTextBox.Text, UserTextBox.Text, PasswordTextBox1.Text, type, AcademicTextBox.Text);
            if (v == 1)//success
            {
                InfoBox ib = new InfoBox(4);
                ib.ShowDialog();
                ib.Dispose();
                Close();
            }
            else if (v == 2)//id error
            {
                InfoBox ib = new InfoBox(7);
                ib.ShowDialog();
                ib.Dispose();
            }
            else if (v == 3)//username error
            {
                InfoBox ib = new InfoBox(8);
                ib.ShowDialog();
                ib.Dispose();
            }
            else if (v == 4)//unknown error
            {
                InfoBox ib = new InfoBox(9);
                ib.ShowDialog();
                ib.Dispose();
            }
        }
    }
}
