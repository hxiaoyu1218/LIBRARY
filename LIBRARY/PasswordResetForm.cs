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
using LibrarySystemBackEnd;

namespace LIBRARY
{
    public partial class PasswordResetForm : DMSkin.Main
    {
        public PasswordResetForm()
        {
            InitializeComponent();
        }

        private void PasswordChangeForm_Load(object sender, EventArgs e)
        {
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddEllipse(0, 0, 80, 80);
            OKButton.Region = new Region(myPath);
        }

        private void ShutDownButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        #region 按钮水印处理
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
            if (NPasswordTextBox1.Text != NPasswordTextBox2.Text)
            {
                MessageBox ib = new MessageBox(10);
                ib.ShowDialog();
                ib.Dispose();
                NPasswordTextBox1.Focus();
                return;
            }

            var v = ClassBackEnd.ChangePassword(OPasswordTextBox.Text, NPasswordTextBox1.Text);

            if (v == 0)
            {
                MessageBox infoBox = new MessageBox(9);
                infoBox.ShowDialog();
                infoBox.Dispose();
                return;
            }
            else if (v == 1)
            {
                MessageBox infoBox = new MessageBox(3);
                infoBox.ShowDialog();
                infoBox.Dispose();
                Close();
            }
            else if (v == 2)
            {
                MessageBox infoBox = new MessageBox(15);
                infoBox.ShowDialog();
                infoBox.Dispose();
                return;
            }
        }


    }
}
