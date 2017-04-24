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
    public partial class BookDetailForm : DMSkin.Main
    {
        private MainForm frmMain;
        public BookDetailForm(MainForm frm)
        {
            frmMain = frm;
            InitializeComponent();
        }

        private void BookDetailForm_Load(object sender, EventArgs e)
        {
            //to do button show or hide
            //search book if it is available to borrow
            BookBorrowButton.Show();
            BookOrderButton.Hide();
            frmMain.ReturnButton.Tag = 2;
        }

        private void BookBorrowButton_Click(object sender, EventArgs e)
        {
            InfoBox infoBox = new InfoBox(1);
            infoBox.ShowDialog();
            infoBox.Dispose();
            BookBorrowButton.DM_NolImage = BookBorrowButton.DM_HoverImage;
            BookBorrowButton.Enabled = false;
        }

        private void BookOrderButton_Click(object sender, EventArgs e)
        {
            InfoBox infoBox = new InfoBox(2);
            infoBox.ShowDialog();
            infoBox.Dispose();
            BookOrderButton.DM_NolImage = BookOrderButton.DM_HoverImage;
            BookOrderButton.Enabled = true;
        }
    }
}
