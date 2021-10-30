using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaQuark
{
    public class Member
    {
        protected string name;
        protected string surname;
        protected int idNumber;
        protected List<Copy> borrowedCopies;
        protected int borrowMax = 1;

        public Member(string name, string surname, int idNumber)
        {
            this.name = name;
            this.surname = surname;
            this.idNumber = idNumber;
            borrowedCopies = new List<Copy>();
        }
        
        public bool CanBorrow()
        {
            return borrowedCopies.Count < borrowMax;
        }

        public void Borrow(Copy copy)
        {
            borrowedCopies.Add(copy);
        }

        public Copy ReturnCopy(Copy copy)
        {
            Copy aux = borrowedCopies.Find(x => x.ISBN == copy.ISBN && x.IssueYear == copy.IssueYear);
            borrowedCopies.Remove(aux);
            return aux;
        }
        
        //public void ReturnCopy(Copy c)
        //{
        //    borrowedCopies.Remove(borrowedCopies.Find(x => x.ISBN == c.ISBN && x.IssueYear == c.IssueYear););
        //}

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int IdNumber { get => idNumber; set => idNumber = value; }
    }
}
