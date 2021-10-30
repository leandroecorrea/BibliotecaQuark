using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaQuark
{
    public class Copy : Book
    {
        private int issueYear;
        private string location;

        public Copy (string name, long isbn, string authorName, int issueYear, string location) : base(name, isbn, authorName)
        {
            this.issueYear = issueYear;
            this.location = location;
        }

        public string Location { get => location; set => location = value; }
        public int IssueYear { get => issueYear; set => issueYear = value; }
    }
}
