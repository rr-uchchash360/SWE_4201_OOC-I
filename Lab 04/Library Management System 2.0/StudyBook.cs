using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System_2._0
{
    internal class StudyBook : ParentBook
    {
        private double ISBN;
        private string Genre;

        public void setterStudyBook(double id, string title, string author, string publisher, double quanitity, double ISBN, string Genre)
        {
            this.ID = id;
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.quantity = quanitity;
            this.ISBN = ISBN;
            this.Genre = Genre;

        }


        public bool checkStudyBook(double bookID)
        {
            if (bookID == ID)
                return true;
            else return false;

        }

        public string getStudyBOok()
        {
            string setbook = ID.ToString() + "\t" + Title + "\t" + Author + "\t" + ISBN.ToString() + "\t" + quantity.ToString();
            return setbook;
        }

        public bool StudyquantityCheck()
        {
            if (quantity == 0)
                return false;
            else return true;
        }
        public void StudyquantityDecrease()
        {
            quantity = quantity - 1;
        }

    }
}
}
