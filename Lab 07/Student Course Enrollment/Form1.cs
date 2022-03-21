using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Course_Enrollment
{
    public partial class StudentCourseEnrollment : Form
    {
        public StudentCourseEnrollment()
        {
            InitializeComponent();
        }

        private void ParticiantInfoAddButton_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            string regno = RegBox.Text;
            string contact = ConInfoBox.Text;
            string email = Emailox.Text;

            string level;


            bool errorExists = false;
            if (BegradioButton1.Checked)
            {
                level = BegradioButton1.Text;
            }
            else if (InterradioButton1.Checked)
            {
                level = InterradioButton1.Text;
            }
            else
            {
                level = AdvradioButton1.Text;
            }

            if (StudentradioButton1.Checked)
            {

                for (int i = 0; i < StudentClass.StudentList.Count; i++)
                {
                    if (StudentClass.StudentList[i].checkIfPartExists(name))
                    {
                        errorExists = true;
                        break;
                    }
                }
                if (errorExists)
                {
                    MessageBox.Show("Student Already Exists!");
                }
                else
                {
                    StudentClass dumbStudent = new StudentClass(name, regno, contact, email, level);
                    StudentClass.StudentList.Add(dumbStudent);
                    StudentSelectComboBox.Items.Add(name);
                    SelectStudetComboBox.Items.Add(name);
                    MessageBox.Show("Student has been added!!!");
                }

            }

            if (ProradioButton1.Checked)
            {
                for (int i = 0; i < Professional.ProList.Count; i++)
                {
                    if (Professional.ProList[i].checkIfPartExists(name))
                    {
                        errorExists = true;
                        break;
                    }
                }
                if (errorExists)
                {
                    MessageBox.Show("Professional Already Exists!");
                }
                else
                {
                    Professional dumbPro = new Professional(name, regno, contact, email, level);
                    Professional.ProList.Add(dumbPro);
                    StudentSelectComboBox.Items.Add(name);
                    SelectStudetComboBox.Items.Add(name);
                    MessageBox.Show("Professional has been added!!!");
                }
            }
        }

        private void CourseInfoAddButton_Click(object sender, EventArgs e)
        {
            string courseName = TitleBox.Text;
            string level;
            double coursefee = Convert.ToDouble(CourseFeeBox.Text);
            bool errorExists = false;
            if (BeginerRadioBox2.Checked)
            {
                level = BeginerRadioBox2.Text;
            }
            else if (IntermediateRadioBox2.Checked)
            {

                level = IntermediateRadioBox2.Text;
            }
            else
            {
                level = advancedRadinBox2.Text;
            }

            for (int i = 0; i < Course.CourseList.Count; i++)
            {
                if (Course.CourseList[i].checkIfCourseExist(courseName))
                {
                    errorExists = true;
                    break;
                }
            }

            if (errorExists)
            {
                MessageBox.Show("Course Already Exists!");
            }
            else
            {
                Course dumbCourse = new Course(courseName, level, coursefee);
                Course.CourseList.Add(dumbCourse);
                SelectCourseComboBox.Items.Add(courseName);
                MessageBox.Show("Course Has Been Added!");

            }
        }

        private void CourseEnrollmentButton_Click(object sender, EventArgs e)
        {
            string partName = StudentSelectComboBox.Text;
            string courseName = SelectCourseComboBox.Text;


            foreach (StudentClass student in StudentClass.StudentList)
            {
                if (partName == student.getName())
                {
                    foreach (Course course in Course.CourseList)
                    {
                        if (courseName == course.Name)
                        {
                            if (student.getLevel() == course.Level)
                            {
                                student.Enrolled_courses.Add(courseName);
                                courseFeeLabel.Text = "Course Fee : " + student.getFee(course.CourseFee).ToString();

                                MessageBox.Show("Student Has Been Enrolled!");

                            }
                            else
                            {
                                MessageBox.Show("Levels Do Not Match!");
                            }
                        }
                    }

                }
            }

            foreach (Professional pro in Professional.ProList)
            {
                if (partName == pro.getName())
                {
                    foreach (Course course in Course.CourseList)
                    {
                        if (courseName == course.Name)
                        {
                            if (pro.getLevel() == course.Level)
                            {
                                pro.Enrolled_courses.Add(courseName);
                                courseFeeLabel.Text = "Course Fee : " + pro.getFee(course.CourseFee).ToString();

                                MessageBox.Show("Pro Has Been Enrolled!");

                            }
                            else
                            {
                                MessageBox.Show("Levels Do Not Match!");
                            }
                        }
                    }

                }
            }
        }

        private void ShowEnrollmentButton_Click(object sender, EventArgs e)
        {
            string name = SelectStudetComboBox.Text;

            foreach (Professional pro in Professional.ProList)
            {
                if (name == pro.getName())
                {
                    listBox1.Items.Clear();
                    for (int i = 0; i < pro.Enrolled_courses.Count; i++)
                    {
                        listBox1.Items.Add(pro.getName() + "\t" + pro.getReg() + "\t" + pro.Enrolled_courses[i]);
                    }
                }
            }
            foreach (StudentClass stu in StudentClass.StudentList)
            {
                if (name == stu.getName())
                {
                    listBox1.Items.Clear();
                    for (int i = 0; i < stu.Enrolled_courses.Count; i++)
                    {
                        listBox1.Items.Add(stu.getName() + "\t" + stu.getReg() + stu.Enrolled_courses[i]);
                    }
                }
            }
        }
    }
}
