using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Book
    {
        public int bookID;
        public string title;
        public string author;
        public string publisher;
        public DateTime datePublished;

        public Book(int _bookID, string _title, string _author, string _publisher, DateTime _datePublished)
        {
            bookID = _bookID;
            title = _title;
            author = _author;
            publisher = _publisher;
            datePublished = _datePublished;
        }
    }
}
