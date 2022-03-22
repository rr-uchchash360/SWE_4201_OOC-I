using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Management_System
{
    public partial class UniversityManagementSystem : Form
    {
        public UniversityManagementSystem()
        {
            InitializeComponent();
        }

        List<Student> studentInfoList = new List<Student>();
        List<Teacher> TeachersInfoList = new List<Teacher>();
        List<Administration> AdminsInfoList = new List<Administration>();
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void StudentInfoSaveButton_Click(object sender, EventArgs e)
        {
            string studentID = StudentIDTextBox.Text;
            string studentName = StudentNameTextBox.Text;
            string studentSemester = StudentSemesterTextBox.Text;
            string studentDepart = StudentDepartTextBox.Text;

            Student dummy_std = new Student
            {
                studentsID = studentID,
                studentsName = studentName,
                studentsSemester = studentSemester,
                studentsDepart = studentDepart
            };


            studentInfoList.Add(dummy_std);

            MessageBox.Show("Info has been added successfully");



        }

        private void StudentInfoClearButton_Click(object sender, EventArgs e)
        {
            StudentIDTextBox.Text = String.Empty;
            StudentNameTextBox.Text = String.Empty;
            StudentSemesterTextBox.Text = String.Empty;
            StudentDepartTextBox.Text = String.Empty;

            MessageBox.Show("Cleared Successfully");

        }

        private void StudentInfoShowButton_Click(object sender, EventArgs e)
        {
            StudentInfoListBox.Items.Clear();

            for (int i = 0; i < studentInfoList.Count; i++)
            {
                StudentInfoListBox.Items.Add(studentInfoList[i].getInfo());
            }
        }


        private void TeachersInfoSaveButton_Click(object sender, EventArgs e)
        {
            string TeachersID = TeachersIDTextBox.Text;
            string TeachersName = TeachersNameTextBox.Text;
            string TeachersDepart = TeachersDepartTextBox.Text;
            string TeachersDesignation = TeachersDesignationTextBox.Text;
            string TeachersSalary = TeachersSalaryTextBox.Text;

            Teacher dummy_tc = new Teacher
            {
                TeachersID = TeachersID,
                TeachersName = TeachersName,
                TeachersDepart = TeachersDepart,
                TeachersDesignation = TeachersDesignation,
                TeachersSalary = TeachersSalary
            };

            TeachersInfoList.Add(dummy_tc);

            MessageBox.Show("Info has been added successfully");

        }

        private void TeachersInfoClearButton_Click(object sender, EventArgs e)
        {
            TeachersIDTextBox.Text = String.Empty;
            TeachersNameTextBox.Text = String.Empty;
            TeachersDepartTextBox.Text = String.Empty;
            TeachersDesignationTextBox.Text = String.Empty;
            TeachersSalaryTextBox.Text = String.Empty;

            MessageBox.Show("Cleared Successfully");


        }

        private void TeachersInfoShowButton_Click(object sender, EventArgs e)
        {
            TeachersInfoListBox.Items.Clear();

            for (int i = 0; i < TeachersInfoList.Count; i++)
            {
                TeachersInfoListBox.Items.Add(TeachersInfoList[i].getInfo());
            }
        }

        private void AdminInfoSaveButton_Click(object sender, EventArgs e)
        {
            string AdminsID = AdminIDTextBox.Text;
            string AdminName = AdminNameTextBox.Text;
            string AdminDesignation = AdminDesignationTextBox.Text;
            string AdminSalary = AdminSalaryTextBox.Text;

            Administration dummy_adm = new Administration
            {
                AdminsID = AdminsID,
                AdminsName = AdminName,
                AdminsDesignation = AdminDesignation,
                AdminsSalary = AdminSalary,
            };

            AdminsInfoList.Add(dummy_adm);

            MessageBox.Show("Info has been added successfully");
        }

        private void AdminInfoClearButton_Click(object sender, EventArgs e)
        {
            AdminIDTextBox.Text = String.Empty;
            AdminNameTextBox.Text = String.Empty;
            AdminDesignationTextBox.Text = String.Empty;
            AdminSalaryTextBox.Text = String.Empty;

            MessageBox.Show("Cleared Successfully");

        }

        private void AdminInfoShowButton_Click(object sender, EventArgs e)
        {
            AdminInfoListBox.Items.Clear();

            for (int i = 0; i < AdminsInfoList.Count; i++)
            {
                AdminInfoListBox.Items.Add(AdminsInfoList[i].getInfo());
            }
        }
    }
}
