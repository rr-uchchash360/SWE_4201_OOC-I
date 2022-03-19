using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class LibraryManagementSystem : Form
    {
        List<User> users = new List<User>();
        List<Book> books = new List<Book>();

        public LibraryManagementSystem()
        {
            InitializeComponent();
        }

        private void LibraryManagementSystem_Load(object sender, EventArgs e)
        {

        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(UserIDTextbox.Text);
            string userName = UserNameTextbox.Text;
            string userAddress = UserAddressTextbox.Text;

            User dummyUser = new User(userID, userName, userAddress);

            users.Add(dummyUser);

            MessageBox.Show("The User has been added succesfully!");

        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            int bookID = Convert.ToInt32(BookIDTextbox.Text);
            string bookName = BookNameTextbox.Text;
            string bookAuthor = BookAuthorTextbox.Text;
            string bookPublisher = BookPublisherTextbox.Text;
            int bookQuantity = Convert.ToInt32(BookQuantityTextbox.Text);

            if (bookQuantity < 0)
            {
                MessageBox.Show("Quantity can't be negative!");
            }

            Book dummyBook = new Book(bookID, bookName, bookAuthor, bookPublisher, bookQuantity);

            books.Add(dummyBook);

            MessageBox.Show("Book has been added successfully");

        }

        private void UserHistoryShowButton_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(HistoryUserIDTextbox.Text);
            User dummy = new User();
            bool flag = false;
            foreach (User user in users)
            {
                if (user.userID == userid)
                {
                    flag = true;
                    dummy = user;
                    break;
                }
            }

            if (flag == false)
            {
                MessageBox.Show("User could not be found!");
            }

            UserHistoryListbox.Items.Clear();

            for (int i = 0; i < dummy.books.Count; i++)
            {
                int id_book = dummy.books[i];
                for (int j = 0; j < books.Count; j++)
                {
                    if (books[j].bookID == id_book)
                    {
                        UserHistoryListbox.Items.Add(books[j].UserHistory());
                    }
                }
            }
        }

        private void BookHistoryShowButton_Click(object sender, EventArgs e)
        {
            int bookID = Convert.ToInt32(HistoryBookDTextbox.Text);
            bool flag = false;

            foreach (Book book in books)
            {
                if (book.bookID == bookID)
                {
                    flag = true;
                    BookIDHistoryLabel.Text = book.bookID.ToString();
                    BookNameHistoryLabel.Text = book.bookName;
                    BookAuthorHistoryLabel.Text = book.bookAuthor;
                    BookPublisherHistoryLabel.Text = book.bookPublisher;
                    BookQuantityHistoryLabel.Text = book.bookQuantity.ToString();
                }
            }

            if (flag == false)
            {
                MessageBox.Show("Book could not be found!");
            }
        }

        private void BorrowBookButton_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(BorrowUserIDTextbox.Text);
            int bookID = Convert.ToInt32(BorrowBookIDTextbox.Text);

            foreach (Book book in books)
            {
                if (book.bookID == bookID)
                {
                    if (book.bookQuantity < 1)
                    {
                        MessageBox.Show("Out of Stock :(");
                        break;
                    }

                    book.bookQuantity -= 1;

                    foreach (User user in users)
                    {
                        if (user.userID == userID)
                        {
                            user.books.Add(bookID);
                            MessageBox.Show("Book has been added to the user.");
                        }
                    }
                    break;
                }
            }
        }
    }
}
