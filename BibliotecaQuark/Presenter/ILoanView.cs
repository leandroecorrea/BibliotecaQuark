using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaQuark.Presenter
{
    public interface ILoanView
    {
        public string GetMemberID();
        public string GetBookISBN();
        public void ShowMessage(bool success, string result);
    }
}
