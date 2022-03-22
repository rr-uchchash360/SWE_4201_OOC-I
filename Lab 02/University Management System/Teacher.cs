using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    internal class Teacher
    {
        public string TeachersID, TeachersName, TeachersDepart, TeachersDesignation, TeachersSalary;

        public string getInfo()
        {
            string teachersInfo = TeachersID + "\t" + TeachersName + "\t" + TeachersDepart + "\t" + TeachersDesignation + "\t" + TeachersSalary;
            return teachersInfo;
        }
    }
}
