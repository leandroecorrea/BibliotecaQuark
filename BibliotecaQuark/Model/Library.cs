using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaQuark.Model
{
    public class Library
    {
        private List<Book> bookList;
        private List<Member> membersList;
        private List<Loan> loanList;
        private static Library instance;

        internal List<Loan> LoanList { get => loanList;}
        public List<Book> BookList { get => bookList;}



        private Library()
        {
            bookList = new List<Book>();
            membersList = new List<Member>();
            loanList = new List<Loan>();
        }

        public static Library GetInstance()
        {
            if (instance == null)
            {
                instance = new Library();
            }
            return instance;
        }

        public Book FindBook(long isbn)
        {
            return bookList.Find(x => x.ISBN == isbn);
        }

        public bool AddLoan(int memberID, long isbn, ref string message)
        {
            Member member = membersList.Find(x => x.IdNumber == memberID);
            if (member == null)
            {
                message = "El número de ID del socio no se encuentra registrado";
                return false;
            }
            else if (!member.CanBorrow())
            {
                message = "El socio excedió la cantidad de préstamos permitidos.";
                return false;
            }
            Book book = bookList.Find(x => x.ISBN == isbn);
            if (book == null)
            {
                message = "El libro no se encuentra registrado en la biblioteca";
                return false;
            }
            else if (!book.AvailableCopies())
            {
                message = "El libro no posee copias disponibles para préstamo";
                return false;
            }
            else
            {
                Copy copy = book.BorrowCopy();
                loanList.Add(new Loan(member, copy));
                member.Borrow(copy);
                message = $"Se generó el préstamo exitosamente del libro: \n Título: {copy.Name} \n Autor: {copy.AuthorName} \n Edición: {copy.IssueYear} \n ISBN: {copy.ISBN}";
                return true;
            }
        }

        public void AddBook(string name, long isbn, string authorName, int issueYear, string location, ref string message)
        {
            Book book = bookList.Find(x => isbn == x.ISBN);
            if (book == null)
            {
                book = new Book(name, isbn, authorName);
                bookList.Add(book);
            }
            book.AddCopy(issueYear, location);
            message = "El ejemplar fue cargado exitosamente.";
        }

        public bool AddMember(string name, string surname, int idNumber, bool vip, ref string message)
        {
            Member member = membersList.Find(x => idNumber == x.IdNumber);
            if (member == null)
            {
                if (vip)
                {
                    membersList.Add(new VipMember(name, surname, idNumber));
                }
                else
                {
                    membersList.Add(new Member(name, surname, idNumber));
                }
                message = "El usuario fue cargado con éxito.";                
                return true;
            }
            else
            {
                message = "El ID de socio ya se encuentra registrado";
                return false;
            }
        }

        public bool ReturnBook(long isbn, int issueYear, ref string message)
        {
            Book book = bookList.Find(x => isbn == x.ISBN);
            if (book == null)
            {                
                message = "El libro no se encuentra registrado en el sistema.";
                return false;
            }
            else
            {
                Loan loan = loanList.Find(x => isbn == x.Copy.ISBN && issueYear == x.Copy.IssueYear);                
                if(loan == null)
                {
                    message = "El ejemplar no se encuentra registrado como prestado.";
                    return false;
                }
                else
                {
                    Copy copy = loan.Copy;
                    Member member = loan.Member;
                    //loanList.Remove(loan);
                    book.ReturnCopy(copy);
                    member.ReturnCopy(copy);
                    loan.Returned = true;
                    message = "El ejemplar fue devuelto exitosamente.";
                    return true;
                }
            }            
        }


    }
}
