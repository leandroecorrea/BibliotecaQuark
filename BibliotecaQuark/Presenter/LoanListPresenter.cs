using BibliotecaQuark.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaQuark.Presenter
{
    class LoanListPresenter
    {
        ILoanListView loanListView;
        Library library;

        public LoanListPresenter(ILoanListView loanListView)
        {
            this.loanListView = loanListView;
            library = Library.GetInstance();
            loanListView.FillTable(library.LoanList);
        }

    }
}
