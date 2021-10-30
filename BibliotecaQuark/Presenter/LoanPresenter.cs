using BibliotecaQuark.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaQuark.Presenter
{
    class LoanPresenter
    {
        ILoanView loanView;
        Library library;

        public LoanPresenter(ILoanView loanView)
        {
            this.loanView = loanView;
            library = Library.GetInstance();
            try
            {
                int memberID = Convert.ToInt32(loanView.GetMemberID());
                long bookISBN = Convert.ToInt64(loanView.GetBookISBN());
                string message = null;
                loanView.ShowMessage(library.AddLoan(memberID, bookISBN, ref message), message);                
            }
            catch(FormatException)
            {
                loanView.ShowMessage(false, "Los campos sólo admiten números");
            }
        }        

    }
}
