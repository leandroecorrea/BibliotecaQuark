using BibliotecaQuark.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaQuark.Presenter
{
    class MainPresenter
    {
        private IMainView mainView;        

        public MainPresenter(IMainView mainView, Views eView)
        {            
            this.mainView = mainView;
            switch (eView)
            {
                case Views.NewMember:
                    this.mainView.CreateNewMemberView();
                    break;
                case Views.NewBook:
                    this.mainView.CreateNewBookView();
                    break;
                case Views.NewLoan:
                    this.mainView.CreateLoanView();
                    break;
                case Views.LoanList:
                    this.mainView.CreateLoanListView();
                    break;
                case Views.ReturnBook:
                    this.mainView.CreateReturnBookView();
                    break;
                case Views.CopiesList:
                    this.mainView.CreateCopyListView();
                    break;                
                default:
                    break;
            }
        }
    }
}
