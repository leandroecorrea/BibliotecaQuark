using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaQuark.Presenter
{
    public interface IAvailableCopiesView
    {
        public void FillTable(List<Copy> copiesList);
        public string GetISBN();
        public void ShowMessage(string message);
    }
}
