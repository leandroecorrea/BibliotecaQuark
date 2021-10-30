using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaQuark
{
    public class Book
    {
        protected string name;
        protected long isbn;
        protected string authorName;
        private Queue<Copy> copiesList;

        public Book(string name, long isbn, string authorName)
        {
            this.name = name;
            this.isbn = isbn;
            this.authorName = authorName;
            copiesList = new Queue<Copy>();
        }

        public void AddCopy(int issueYear, string location)
        {   
            copiesList.Enqueue(new Copy(name, isbn, authorName, issueYear, location));
        }

        public void AddCopy(Copy copy)
        {
            copiesList.Enqueue(copy);
        }

        public bool AvailableCopies()
        {
            return copiesList != null && copiesList.Count > 0;
        }

        public Copy BorrowCopy()
        {
            return copiesList.Dequeue();
        }

        public void ReturnCopy(Copy c)
        {
            copiesList.Enqueue(c);
        }

        public string Name { get => name; }
        public long ISBN { get => isbn; }
        public string AuthorName { get => authorName; }
        public Queue<Copy> CopiesList { get => copiesList; }
    }
}
