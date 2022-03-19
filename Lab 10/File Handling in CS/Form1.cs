using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Handling_in_CS
{
    public partial class DataBook : Form
    {
        List<Employee> employees = new List<Employee>();

        public DataBook()
        {
          
            InitializeComponent();
            using (var reader = new StreamReader(@"C:\Users\User\Downloads\employees.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var segments = line.Split(',');

                    Employee employee = new Employee();

                    employee.EmployeeID = segments[0];
                    employee.first_name = segments[1];
                    employee.last_name = segments[2];
                    employee.email = segments[3];
                    employee.phone = segments[4];
                    employee.hire_date = segments[5];
                    employee.job_id = segments[6];
                    employee.salary = segments[7];
                    employee.commission_pct = segments[8];
                    employee.manager_id = segments[9];
                    employee.department_id = segments[10];

                    employees.Add(employee);
                }
            }

            for (int i = 0; i < employees.Count; i++)
            {
                CSVFile.Items.Add(employees[i].printTable());
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string checkID = searchIDTextBox.Text;
            string time = DateTime.Now.ToString();
            string path = @"C:\Users\User\Downloads\log.txt";
            
            bool errorExists = true;
            int i;
            for (i = 0;i < employees.Count;i++)
            {
                if(employees[i].checkIfEmployeeHere(checkID))
                {
                    errorExists = false;
                    break;
                }
            }

            if (errorExists)
            {
                MessageBox.Show("Account doesn't exist");
            }    
            else
            {
                queryDataListBox.Items.Clear();

                queryDataListBox.Items.Add(employees[i].EmployeeID);
                queryDataListBox.Items.Add(employees[i].first_name);
                queryDataListBox.Items.Add(employees[i].last_name);
                queryDataListBox.Items.Add(employees[i].email);
                queryDataListBox.Items.Add(employees[i].phone);
            }


            using (StreamWriter sw = File.AppendText(path))
            {
                sw.Write(checkID + " ");
                sw.Write(time + " ");
                
                if (!errorExists)
                {
                    sw.Write("FOUND!" + " ");
                    sw.Write(employees[i].printTable());
                }
                else
                {
                    sw.Write("NOT FOUND!" + " ");
                }
                sw.WriteLine("\n");
            }
        }
    }
}
