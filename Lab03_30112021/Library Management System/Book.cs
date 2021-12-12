using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class Book
    {
        public int bookID;
        public string bookName;
        public string bookAuthor;
        public string bookPublisher;
        public int bookQuantity;

        public int getId()
        {
            return bookID;
        }

        public string getBook()
        {
            string bookInfo = Convert.ToString(bookID) + "\t" + bookName;
            return bookInfo;
        }

        public void addBook()
        {
            bookQuantity++;
        }

        public void borrowBook()
        {
            bookQuantity--;
        }
    }
}
