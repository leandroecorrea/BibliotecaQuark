using BibliotecaQuark.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaQuark.Presenter
{
    class NewBookPresenter
    {
        INewBookView newBookView;
        Library library;

        public NewBookPresenter(INewBookView newBookView)
        {
            this.newBookView = newBookView;
            library = Library.GetInstance();
            string message = null;
            string title = newBookView.GetBookName();
            string author = newBookView.GetAuthorName();
            string location = newBookView.GetBookLocation();
            if (ValidateBookData(title, author, location))
            {
                try
                {
                    int issueYear = Convert.ToInt32(newBookView.GetIssueYear());
                    long isbn = Convert.ToInt64(newBookView.GetBookISBN());
                    if (ValidateYear(issueYear))
                    {
                        library.AddBook(title, isbn, author, issueYear, location, ref message);
                        newBookView.ShowMessage(true, message);
                    }
                    else
                    {
                        message = "El año ingresado no es válido.";
                        newBookView.ShowMessage(false, message);
                    }
                }
                catch (FormatException)
                {
                    message = "Los campos Edición e ISBN sólo admiten números";
                    newBookView.ShowMessage(false, message);
                }
                catch (Exception e)
                {
                    message = $"Se ha producido un error. \n Error: {e.Message}";
                    newBookView.ShowMessage(false, message);
                }
            }


        }

        private bool ValidateBookData(string title, string author, string location)
        {
            if (title == "" || title == null || author == "" || author == null || location == "" || location == null || newBookView.GetIssueYear() == "" || newBookView.GetIssueYear() == null || newBookView.GetBookISBN() == "" || newBookView.GetBookISBN() == null)
            {
                newBookView.ShowMessage(false, "Por favor, complete todos los campos.");
                return false;
            }
            else if (newBookView.GetBookISBN().Length != 13)
            {
                newBookView.ShowMessage(false, "El ISBN debe consistir de trece dígitos.");
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool ValidateYear(int issueYear)
        {
            return issueYear <= DateTime.Now.Year;
        }
    }
}
