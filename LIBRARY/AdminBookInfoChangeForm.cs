using System;
using LibrarySystemBackEnd;

namespace LIBRARY
{
    public partial class AdminBookInfoChangeForm : DMSkin.Main
    {
        public AdminBookInfoChangeForm()
        {
            InitializeComponent();
        }

        private void BookInfoChangeForm_Loaf(object sender, EventArgs e)
        {
            BookInfoText.Text = ClassBackEnd.Currentbook.Introduction;
        }

        private void ShutDownButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {           
            ClassBackEnd.ChangeBookIntroduction(BookInfoText.Text);
            Close();
        }
    }
}
