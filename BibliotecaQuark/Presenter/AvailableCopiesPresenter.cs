using BibliotecaQuark.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace BibliotecaQuark.Presenter
{
    public class AvailableCopiesPresenter
    {
        IAvailableCopiesView availableCopiesView;
        Library library;
        public AvailableCopiesPresenter(IAvailableCopiesView availableCopiesView)
        {
            this.availableCopiesView = availableCopiesView;
            library = Library.GetInstance();
            if (availableCopiesView.GetISBN().Length == 13)
            {
                try
                {
                    long isbn = Convert.ToInt64(availableCopiesView.GetISBN());
                    List<Copy> copiesList = library.FindBook(isbn).CopiesList.ToList<Copy>();
                    if(copiesList != null)
                    {
                        availableCopiesView.FillTable(copiesList);    
                    }                    
                }
                catch
                {
                    availableCopiesView.ShowMessage("El ISBN consiste sólo de números");
                }

            }
            else
            {
                availableCopiesView.ShowMessage("El ISBN posee 13 dígitos");
            }


        }

    }
}
