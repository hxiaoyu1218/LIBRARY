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
    public partial class RegistForm : DMSkin.Main
    {
        public RegistForm()
        {
            InitializeComponent();
        }

        private void RegistForm_Load(object sender, EventArgs e)
        {

        }

        private void ShutDownButton_Click(object sender, EventArgs e)
        {
            Close();
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
            else if (PasswordCueText1.Text.Trim() != "" &&PasswordCueText1.Visible == false)
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
    }
}
