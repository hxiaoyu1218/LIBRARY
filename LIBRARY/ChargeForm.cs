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
    public partial class ChargeForm : DMSkin.Main
    {
        public ChargeForm()
        {
            InitializeComponent();
        }

        private void ChargeForm_Load(object sender, EventArgs e)
        {
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddEllipse(0, 0, 80, 80);
            OKButton.Region = new Region(myPath);            
        }

        private void ShutDownButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MoneyTextBox_Enter(object sender, EventArgs e)
        {
            if (MoneyTextBox.Text == "")
            {
                MoneyCueText.Hide();
            }
        }

        private void MoneyTextBox_Leave(object sender, EventArgs e)
        {
            if (MoneyTextBox.Text == "")
            {
                MoneyCueText.Show();
            }
        }

        private void MoneyCueText_Click(object sender, EventArgs e)
        {
            if (MoneyTextBox.Text == "")
            {
                MoneyCueText.Hide();
                MoneyTextBox.Focus();
            }
        }

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
            try
            {
                var num = Convert.ToInt32(MoneyTextBox.Text);
                if(!ClassBackEnd.ChargeCredit(num))
                {
                    InfoBox ib = new InfoBox(9);
                    ib.ShowDialog();
                    ib.Dispose();
                    return;
                }

                InfoBox infoBox = new InfoBox(14);
                infoBox.ShowDialog();
                infoBox.Dispose();
                Close();
            }
            catch
            {
                InfoBox infoBox = new InfoBox(13);
                infoBox.ShowDialog();
                infoBox.Dispose();
                MoneyTextBox.Focus();
            }
        }
    }
}
