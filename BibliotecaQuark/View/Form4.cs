using BibliotecaQuark.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaQuark.View
{
    public partial class Form4 : Form, INewBookView
    {
        NewBookPresenter newBookPresenter;
        public Form4()
        {
            InitializeComponent();
        }

        public string GetBookISBN()
        {
            return txtBookISBN.Text;
        }
        public string GetAuthorName()
        {
            return txtBookAuthor.Text;
        }
        
        public string GetBookLocation()
        {
            return txtBookLocation.Text;
        }

        public string GetBookName()
        {
            return txtBookTitle.Text;
        }

        private void btnNewBook_Click(object sender, EventArgs e)
        {
            newBookPresenter = new NewBookPresenter(this);
        }

        public string GetIssueYear()
        {
            return txtBookIssueYear.Text;
        }

        public void ShowMessage(bool success, string message)
        {
            if (success)
            {
                MessageBox.Show(message);
            }
            else
            {

                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
