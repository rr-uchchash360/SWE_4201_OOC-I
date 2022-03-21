using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Course_Enrollment
{
    internal class StudentClass : Participant
    {
        static public List<StudentClass> StudentList = new List<StudentClass>();

        public StudentClass(string name, string reg, string cont, string email, string levell)
        {
            this.name = name;
            this.regNo = reg;
            this.contact = cont;
            this.email = email;
            this.level = levell;
        }
    }
}
