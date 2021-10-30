using BibliotecaQuark.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaQuark.Presenter
{
    class NewMemberPresenter
    {
        INewMemberView newMemberView;
        Library library;

        public NewMemberPresenter(INewMemberView newMemberView)
        {
            this.newMemberView = newMemberView;
            library = Library.GetInstance();
            string message = null;
            string memberName;
            string memberSurname;
            int memberID;
            bool vip;            
            memberName = newMemberView.GetMemberName();
            memberSurname = newMemberView.GetMemberSurname();
            vip = newMemberView.GetVIPMember();
            if (ValidateMemberData(memberName, memberSurname))
            {
                try

                {
                    memberID = Convert.ToInt32(newMemberView.GetMemberID());                    
                    newMemberView.ShowMessage(library.AddMember(memberName, memberSurname, memberID, vip, ref message), message);
                }
                catch (FormatException)
                {
                    message = "El campo ID sólo admite números";
                    newMemberView.ShowMessage(false, message);
                }
            }

        }

        private bool ValidateMemberData(string name, string surname)
        {
            if (name == "" || name == null || surname == "" || surname == null || newMemberView.GetMemberID() == "" || newMemberView.GetMemberID() == null)
            {
                newMemberView.ShowMessage(false, "Por favor, complete todos los campos");
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
