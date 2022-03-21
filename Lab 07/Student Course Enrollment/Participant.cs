using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Course_Enrollment
{
    internal class Participant
    {
        public string name;
        public string regNo;
        public string contact;
        public string email;
        public string level;
        public double fee;
        public List<string> Enrolled_courses = new List<string>();

        public virtual double getFee(double feees)
        {
            return feees;
        }

        public bool checkIfPartExists(string Name)
        {
            if (name == Name)
                return true;
            else return false;
        }

        public string getName()
        {
            return name;
        }
        public string getReg()
        {
            return regNo;
        }
        public string getContact()
        {
            return contact;
        }
        public string getEmail()
        {
            return email;
        }
        public string getLevel()
        {
            return level;
        }
        public double getterFee()
        {
            return fee;
        }
    }
}
