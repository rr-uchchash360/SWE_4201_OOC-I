using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUT_Result_Processing_System
{
    public partial class IUTResultProcessingSystem : Form
    {
        List<Student> studentList = new List<Student>();

        public IUTResultProcessingSystem()
        {
            InitializeComponent();

            using (var reader = new StreamReader(@"C:\Users\uchch\Downloads\SWE4201MarkSheet.csv"))
            {
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var segments = line.Split(',');


                    Student student = new Student();

                    student.id = segments[0];
                    student.name = segments[1];
                    student.attendance = segments[2];
                    student.quiz1 = segments[3];
                    student.quiz2 = segments[4];
                    student.quiz3 = segments[5];
                    student.quiz4 = segments[6];
                    student.mid = segments[7];
                    student.final = segments[8];
                    student.viva = segments[9];

                    double attendance;
                    double quiz1;
                    double quiz2;
                    double quiz3;
                    double quiz4;
                    double mid;
                    double final;
                    double viva;

                    if (student.attendance != "")
                    {
                        attendance = Convert.ToDouble(student.attendance);
                    }
                    else
                    {
                        attendance = 0;
                    }
                    if (student.quiz1 != "")
                    {
                        quiz1 = Convert.ToDouble(student.quiz1);
                    }
                    else
                    {
                        quiz1 = 0;
                    }
                    if (student.quiz2 != "")
                    {
                        quiz2 = Convert.ToDouble(student.quiz2);
                    }
                    else
                    {
                        quiz2 = 0;
                    }
                    if (student.quiz3 != "")
                    {
                        quiz3 = Convert.ToDouble(student.quiz3);
                    }
                    else
                    {
                        quiz3 = 0;
                    }
                    if (student.quiz4 != "")
                    {
                        quiz4 = Convert.ToDouble(student.quiz4);
                    }
                    else
                    {
                        quiz4 = 0;
                    }

                    if (student.mid != "")
                    {
                        mid = Convert.ToDouble(student.mid);
                    }
                    else
                    {
                        mid = 0;
                    }
                    if (student.final != "")
                    {
                        final = Convert.ToDouble(student.final);
                    }
                    else
                    {
                        final = 0;
                    }
                    if (student.viva != "")
                    {
                        viva = Convert.ToDouble(student.viva);
                    }
                    else
                    {
                        viva = 0;
                    }

                    double quizTotal;
                    double totalMarks;
                    double percentage;
                    string grade;

                    if (quiz4 <= quiz1 && quiz4 <= quiz2 && quiz4 <= quiz3)
                    {
                        quizTotal = quiz1 + quiz2 + quiz3;
                    }
                    else if (quiz3 <= quiz1 && quiz3 <= quiz2 && quiz3 <= quiz4)
                    {
                        quizTotal = quiz1 + quiz2 + quiz4;
                    }
                    else if (quiz2 <= quiz1 && quiz2 <= quiz3 && quiz2 <= quiz4)
                    {
                        quizTotal = quiz1 + quiz4 + quiz3;
                    }
                    else
                    {
                        quizTotal = quiz4 + quiz2 + quiz3;
                    }

                    totalMarks = attendance + quizTotal + mid + final + viva;

                    percentage = (totalMarks / 300.0) * 100;

                    if (percentage >= 80 && percentage <= 100)
                    {
                        grade = "A+";
                    }
                    else if (percentage >= 75 && percentage <= 79)
                    {
                        grade = "A";
                    }
                    else if (percentage >= 70 && percentage <= 74)
                    {
                        grade = "A-";
                    }
                    else if (percentage >= 65 && percentage <= 69)
                    {
                        grade = "B+";
                    }
                    else if (percentage >= 60 && percentage <= 64)
                    {
                        grade = "B";
                    }
                    else if (percentage >= 55 && percentage <= 59)
                    {
                        grade = "B-";
                    }
                    else if (percentage >= 50 && percentage <= 54)
                    {
                        grade = "C+";
                    }
                    else if (percentage >= 45 && percentage <= 49)
                    {
                        grade = "C";
                    }
                    else if (percentage >= 40 && percentage <= 44)
                    {
                        grade = "D";
                    }
                    else
                    {
                        grade = "F";
                    }

                    student.total = Convert.ToString(totalMarks);
                    student.grade = grade;
                    percentage = Math.Round(percentage, 2);
                    student.percentage = Convert.ToString(percentage);

                    student.quizTotal = Convert.ToString(quizTotal);

                    studentList.Add(student);
                }
            }

            for (int i = 0; i < studentList.Count; i++)
            {
                CSVFile.Items.Add("Student ID : " + studentList[i].printid()); ;
                CSVFile.Items.Add("Student Name : " + studentList[i].printname());
                CSVFile.Items.Add("Percentage : " + studentList[i].printPercent() + "%");
                CSVFile.Items.Add("Grade : " + studentList[i].printGrade());
                CSVFile.Items.Add("");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string checkID = studentIdBox.Text;
            bool errorExists = true;


            var student = from std in studentList
                          where std.id == checkID
                          select std;

            foreach (var stdnt in student)
            {
                attendanceLabel.Text = stdnt.attendance.ToString();
                quiz1label.Text = stdnt.quiz1.ToString();
                quiz2label.Text = stdnt.quiz2.ToString();
                quiz3label.Text = stdnt.quiz3.ToString();
                quiz4label.Text = stdnt.quiz4.ToString();
                quizTotal.Text = stdnt.quizTotal.ToString();
                midLabel.Text = stdnt.mid.ToString();
                finalLabel.Text = stdnt.final.ToString();
                vivaLabel.Text = stdnt.viva.ToString();
                TotalLabel.Text = stdnt.total.ToString();
                percentLabel.Text = stdnt.percentage.ToString() + " %";
                gradeLabel.Text = stdnt.grade;
                errorExists = false;
            }
            if (errorExists)
            {
                MessageBox.Show("Student doesn't exist!");
            }
        }

        private void IUTResultProcessingSystem_Load(object sender, EventArgs e)
        {

        }

        
    }
}
