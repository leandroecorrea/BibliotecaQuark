using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaQuark
{
    class VipMember : Member
    {
        private int monthlyPremium;

        public VipMember(string name, string surname, int idNumber) : base(name, surname, idNumber)
        {
            this.borrowMax = 3;
        }


        public int MonthlyPremium { get => monthlyPremium; set => monthlyPremium = value; }
    }
}
