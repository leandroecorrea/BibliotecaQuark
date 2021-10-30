using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaQuark.Presenter
{
    interface IReturnBookView
    {
        public string GetBookISBN();        
        public string GetIssueYear();
        public void ShowMessage(bool success, string message);
    }
}
