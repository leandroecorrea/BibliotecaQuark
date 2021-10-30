using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaQuark.Presenter
{
    public interface ILoanListView
    {
        void FillTable(List<Loan> loanList);
    }
}
