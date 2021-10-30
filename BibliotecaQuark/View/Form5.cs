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
    public partial class Form5 : Form, IReturnBookView
    {
        ReturnBookPresenter returnBookPresenter;
        public Form5()
        {
            InitializeComponent();
        }

        public string GetBookISBN()
        {
            return txtBookISBN.Text;
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

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            returnBookPresenter = new ReturnBookPresenter(this);
        }
    }
}
