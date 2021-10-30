using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaQuark
{
    public class Loan
    {
        private Copy copy;
        private Member member;
        private DateTime loanDate;
        private DateTime expireDate;
        private bool returned;


        public Loan(Member member, Copy copy)
        {
            this.member = member;
            this.copy = copy;
            loanDate = DateTime.Now;
            ExpireDate = loanDate.AddDays(5);
            returned = false;
        }
        
        public DateTime LoanDate { get => loanDate; set => loanDate = value; }
        public DateTime ExpireDate { get => expireDate; set => expireDate = value; }
        public Copy Copy { get => copy; set => copy = value; }
        public Member Member { get => member; set => member = value; }
        public bool Returned { get => returned; set => returned = value; }
    }
}
