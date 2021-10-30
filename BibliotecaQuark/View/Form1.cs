using BibliotecaQuark.Presenter;
using BibliotecaQuark.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaQuark
{
    public partial class Form1 : Form, IMainView
    {
        MainPresenter mainPresenter;
        public Form1()
        {
            InitializeComponent();
        }       

    

        
        public void CreateNewBookView()
        {
            new Form4().Show();
        }

        public void CreateNewMemberView()
        {
            new Form3().Show();
        }
        public void CreateReturnBookView()
        {
            new Form5().Show();
        }

        public void CreateLoanView()
        {
            new Form2().Show();
        }
        public void CreateLoanListView()
        {
            new Form6().Show();
        }

        public void CreateCopyListView()
        {
            new Form7().Show();
        }
        

        private void btnCreateMember_Click(object sender, EventArgs e)
        {
            mainPresenter = new MainPresenter(this, Views.NewMember);
        }

        private void btnLoadBook_Click(object sender, EventArgs e)
        {
            mainPresenter = new MainPresenter(this, Views.NewBook);
        }
        private void btnNewLoan_Click(object sender, EventArgs e)
        {
            mainPresenter = new MainPresenter(this, Views.NewLoan);
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            mainPresenter = new MainPresenter(this, Views.ReturnBook);
        }

        private void btnSeeLoans_Click(object sender, EventArgs e)
        {
            mainPresenter = new MainPresenter(this, Views.LoanList);
        }

        private void btnSeeCopies_Click(object sender, EventArgs e)
        {
            mainPresenter = new MainPresenter(this, Views.CopiesList);
        }

       
    }
}
