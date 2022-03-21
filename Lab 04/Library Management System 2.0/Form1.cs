using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Librart
{
    public partial class Form1 : Form
    {
        List<StudyBook> StudyBookClassList = new List<StudyBook>();
        List<ResearchArticle> ReArticleClassList = new List<ResearchArticle>();


        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AddStudyBookButton(object sender, EventArgs e)
        {
            double StudyID = Convert.ToDouble(bIDbox.Text);
            string StudyTitle = bTitleBox.Text;
            string author = bAuthorBox.Text;
            string publisher = BPublisherBox.Text;
            double quantity = Convert.ToDouble(BQuantityBox.Text);

            double ISBN = Convert.ToDouble(ISBNbox.Text);
            string genre = GenreBox.Text;

            StudyBookClass Temp_Book = new StudyBookClass();

            Temp_Book.setterStudyBook(StudyID, StudyTitle, author, publisher, quantity, ISBN, genre);
            StudyBookClassList.Add(Temp_Book);
            MessageBox.Show("Book has been saved!");


        }

        private void AddArticleOnClick(object sender, EventArgs e)
        {
            double ArID = Convert.ToDouble(ArIDBox.Text);
            string Artitle = ArTItleBox.Text;
            string author = ArAuthorBox.Text;
            string publisher = ArPublisherBOx.Text;
            double quantity = Convert.ToDouble(ArQuantity.Text);

            double DOI = Convert.ToDouble(DOIbox.Text);
            string pubdate = ArPubDateBOx.Text;
            string ConORJour = JournalBox.Text;

            ResearchArticleClass Temp_Book = new ResearchArticleClass();

            Temp_Book.settterReArticle(ArID, Artitle, author, publisher, quantity, DOI, pubdate, ConORJour);
            ReArticleClassList.Add(Temp_Book);
            MessageBox.Show("Article has been saved!");
        }

        private void ShowStudyBookonClick(object sender, EventArgs e)
        {
            double StudyCheckID = Convert.ToDouble(bIDbox.Text);
            //double ArCheckID = Convert.ToDouble(ArIDBox.Text);

            bool bookExists = false;
            int i = 0;
            for (i = 0; i < StudyBookClassList.Count; i++)
            {
                if (StudyBookClassList[i].checkStudyBook(StudyCheckID))
                {
                    bookExists = true;
                    break;
                }
            }
            if (bookExists)
            {
                StudyBookListBox.Items.Clear();
                //userHistoryListBox.Items.Add(Book_List[j].bookHistory());
                StudyBookListBox.Items.Add(StudyBookClassList[i].getStudyBOok());
            }
            else
            {
                MessageBox.Show("Invalid Input!");
            }

        }

        private void Borrow_Click(object sender, EventArgs e)
        {
            double StudyCheckID = Convert.ToDouble(bIDbox.Text);
            //double ArCheckID = Convert.ToDouble(ArIDBox.Text);

            bool bookExists = false;
            bool quantityExists = false;
            int i = 0;
            {
                if (StudyBookClassList[i].checkStudyBook(StudyCheckID))
                {
                    bookExists = true;
                    if (StudyBookClassList[i].StudyquantityCheck() == true)
                    {
                        quantityExists = true;
                    }
                    break;
            }


            if (bookExists && quantityExists)
            {
                StudyBookClassList[i].StudyquantityDecrease();
            }
            else
            {
                if (quantityExists == false)
                {
                    MessageBox.Show("Insufficient Books");
                }
                if (bookExists == false)
                    MessageBox.Show("Invalid Input");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //double StudyCheckID = Convert.ToDouble(bIDbox.Text);
            double ArCheckID = Convert.ToDouble(ArIDBox.Text);

            bool bookExists = false;
            bool quantityExists = false;
            int i = 0;
            for (i = 0; i < ReArticleClassList.Count; i++)
            {
                if (ReArticleClassList[i].checkReArticle(ArCheckID))
                {
                    bookExists = true;
                    if (ReArticleClassList[i].ReArquantityCheck() == true)
                    {

                        quantityExists = true;
                    }
                    break;
                }
            }



            if (bookExists && quantityExists)
            {
                ReArticleClassList[i].ReArquantityDecrease();
                MessageBox.Show("Article has been borrowed!!");
            }
            else
            {
                if (quantityExists == false)
                {
                    MessageBox.Show("Insufficient Articles");
                }
                if (bookExists == false)
                    MessageBox.Show("Invalid Input");
            }

        }

        private void ShowReArOnClick(object sender, EventArgs e)
        {
            //double StudyCheckID = Convert.ToDouble(bIDbox.Text);
            double ArCheckID = Convert.ToDouble(ArIDBox.Text);

            bool ArExists = false;
            int i = 0;
            for (i = 0; i < ReArticleClassList.Count; i++)
            {
                if (ReArticleClassList[i].checkReArticle(ArCheckID))
                {
                    ArExists = true;
                    break;
                }
            }
            if (ArExists)
            {
                ResearchArticleListBox.Items.Clear();
                //userHistoryListBox.Items.Add(Book_List[j].bookHistory());
                ResearchArticleListBox.Items.Add(ReArticleClassList[i].getReArticle());
            }
            else
            {
                MessageBox.Show("Invalid Input!");
            }
        }
    }
}
