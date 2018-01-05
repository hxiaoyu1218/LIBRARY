using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY
{
    public partial class UserChangeInfo : DMSkin.Main
    {
        public UserChangeInfo()
        {
            InitializeComponent();
            UserAlertLabel.Hide();
            label4.Hide();
            label1.Hide();
            PWD1AlertLabel.Hide();
            PWD2AlertLabel.Hide();
        }

        #region 水印文字及按钮响应方法

        private void BgImage_Click(object sender, EventArgs e)
        {

        }

       

        private void UserTextBox_Click(object sender, EventArgs e)
        {

        }

        private void UserCueText_Click(object sender, EventArgs e)
        {
            if (UserTextBox.Text.Trim() == "")
                UserCueText.Hide();
            else if (UserTextBox.Text.Trim() != "" && UserCueText.Visible == false)
                UserCueText.Hide();
            UserTextBox.Show();
        }

        private void UserCueText_Enter(object sender, EventArgs e)
        {
            //if(UserCueText.Text.Trim()=="")
                
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

        private void OPasswordCueText_Click(object sender, EventArgs e)
        {
            if (OPasswordTextBox.Text == "")
            {
                OPasswordCueText.Hide();
                OPasswordTextBox.Focus();
            }
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
        }

        #endregion

        private void ShutDownButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
