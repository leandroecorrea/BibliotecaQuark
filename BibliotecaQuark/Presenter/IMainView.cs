using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaQuark
{
    public interface IMainView
    {
        public void CreateLoanView();
        public void CreateLoanListView();
        public void CreateReturnBookView();
        public void CreateNewMemberView();
        public void CreateNewBookView();
        public void CreateCopyListView();        
    }
}
