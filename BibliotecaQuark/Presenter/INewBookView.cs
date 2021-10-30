using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaQuark.Presenter
{
    interface INewBookView
    {
        public string GetBookISBN();
        public string GetAuthorName();
        public string GetBookLocation();
        public string GetBookName();
        public string GetIssueYear();
        public void ShowMessage(bool success, string message);
    }
}
