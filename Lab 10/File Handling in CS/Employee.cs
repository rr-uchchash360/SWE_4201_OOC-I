using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling_in_CS
{
    internal class Employee
    {
        public string EmployeeID { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string hire_date { get; set; }
        public string job_id { get; set; }
        public string salary { get; set; }
        public string commission_pct { get; set; }
        public string manager_id { get; set; }
        public string department_id { get; set; }

        public bool checkIfEmployeeHere(string id)
        {
            if (id == EmployeeID)
            {
                return true;
            }
            else
                return false;
        }

        public string printTable()
        {
            string set = EmployeeID.ToString() + " " + first_name + " " + last_name + " " + email + " " + phone + " " + hire_date + " " + job_id.ToString() + " " + salary.ToString() + " " + commission_pct + " " + manager_id.ToString() + " " + department_id.ToString();
            return set;
        }
    }
}
