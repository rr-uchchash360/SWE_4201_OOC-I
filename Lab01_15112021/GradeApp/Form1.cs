using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeApp
{
    public partial class GradeApp : Form
    {
        public GradeApp()
        {
            InitializeComponent();
        }

        private void CalculateGradeButton_Click(object sender, EventArgs e)
        {
            var name = Convert.ToString(NameTextBox.Text);
            double attendance = Convert.ToDouble(AttendanceInputTextBox.Text);
            double mid = Convert.ToDouble(MidInputTextBox.Text);
            double final = Convert.ToDouble(FinalInputTextBox.Text);

            double[] quiz = new double[4];
            quiz[0] = Convert.ToDouble(Quiz1InputTextBox.Text);
            quiz[1] = Convert.ToDouble(Quiz2InputTextBox.Text);
            quiz[2] = Convert.ToDouble(Quiz3InputTextBox.Text);
            quiz[3] = Convert.ToDouble(Quiz4InputTextBox.Text);

            double attendanceperc;
            double attendancemarks;
            double total;
            double result;

            attendanceperc = (attendance * 100) / 28;
            attendancemarks = (30 * attendanceperc) / 100;

            Array.Sort(quiz);
            double quizmarks = quiz[1] + quiz[2] + quiz[3];


            total = final + mid + attendancemarks + quizmarks;

            result = (total * 100) / 300;

            AttendanceOutputTextBox.Text = attendancemarks.ToString("#") + "/30";
            MidOutputTextBox.Text = mid.ToString() + "/75";
            QuizOutputTextBox.Text = quizmarks.ToString() + "/45";
            FinalOutputTextBox.Text = final.ToString() + "/150";
            TotalTextBox.Text = total.ToString("#") + "/300";




            if (result >= 80 && result <= 100)
            {
                GradeOutputLabel.Text = "A+";

            }

            else if (result <= 79 && result >= 75)
            {
                GradeOutputLabel.Text = "A";
            }

            else if (result <= 74 && result >= 70)
            {
                GradeOutputLabel.Text = "A-";
            }

            else if (result <= 69 && result >= 65)
            {
                GradeOutputLabel.Text = "B+";
            }

            else if (result <= 64 && result >= 60)
            {
                GradeOutputLabel.Text = "B";
            }

            else if (result <= 59 && result >= 55)
            {
                GradeOutputLabel.Text = "B-";
            }

            else if (result <= 54 && result >= 50)
            {
                GradeOutputLabel.Text = "C+";
            }

            else if (result <= 49 && result >= 45)
            {
                GradeOutputLabel.Text = "C";
            }

            else if (result <= 44 && result >= 40)
            {
                GradeOutputLabel.Text = "D";
            }

            else
            {
                GradeOutputLabel.Text = "F";
            }


            Comment.Text = name + " obtained " + result.ToString("#") + "% marks.";
        }
    }
}
