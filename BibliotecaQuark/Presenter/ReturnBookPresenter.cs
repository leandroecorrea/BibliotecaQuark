using BibliotecaQuark.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaQuark.Presenter
{
    class ReturnBookPresenter
    {
        IReturnBookView returnBookView;
        Library library;

        public ReturnBookPresenter(IReturnBookView returnBookView)
        {
            this.returnBookView = returnBookView;
            library = Library.GetInstance();
            string message = null;
            if (ValidateBookData())
            {
                try
                {
                    int issueYear = Convert.ToInt32(returnBookView.GetIssueYear());
                    long isbn = Convert.ToInt64(returnBookView.GetBookISBN());
                    if (ValidateYear(issueYear))
                    {
                        library.ReturnBook(isbn, issueYear, ref message);
                        returnBookView.ShowMessage(true, message);
                    }
                    else
                    {
                        message = "El año ingresado no es válido.";
                        returnBookView.ShowMessage(false, message);
                    }
                }
                catch (FormatException)
                {
                    message = "Los campos Edición e ISBN sólo admiten números";
                    returnBookView.ShowMessage(false, message);
                }
                catch (Exception e)
                {
                    message = $"Se ha producido un error. \n Error: {e.Message}";
                    returnBookView.ShowMessage(false, message);
                }
            }
        }

        private bool ValidateBookData()
        {
            if (returnBookView.GetIssueYear() == "" || returnBookView.GetIssueYear() == null || returnBookView.GetBookISBN() == "" || returnBookView.GetBookISBN() == null)
            {
                returnBookView.ShowMessage(false, "Por favor, complete todos los campos.");
                return false;
            }
            else if (returnBookView.GetBookISBN().Length != 13)
            {
                returnBookView.ShowMessage(false, "El ISBN debe consistir de trece dígitos.");
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
