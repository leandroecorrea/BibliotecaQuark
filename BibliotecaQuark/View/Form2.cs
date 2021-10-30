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
    public partial class Form2 : Form, ILoanView
    {
        LoanPresenter presenter = null;        

        public Form2()
        {
            InitializeComponent();
        }

        public string GetMemberID()
        {
            return txtMemberID.Text;
        }

        public string GetBookISBN()
        {
            return txtBookISBN.Text;
        }        

        public void ShowMessage(bool success, string result)
        {
            if(success)
            {
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            presenter = new LoanPresenter(this);
        }
    }
}
