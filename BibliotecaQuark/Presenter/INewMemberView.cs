using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaQuark.Presenter
{
    interface INewMemberView
    {
        public void ShowMessage(bool success, string message);
        public string GetMemberName();
        public string GetMemberSurname();
        public string GetMemberID();
        public bool GetVIPMember();
    }
}
