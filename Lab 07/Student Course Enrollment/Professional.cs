using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Course_Enrollment
{
    internal class Professional : Participant
    {
        static public List<Professional> ProList = new List<Professional>();
        public Professional(string name, string reg, string cont, string email, string levell)
        {
            this.name = name;
            this.regNo = reg;
            this.contact = cont;
            this.email = email;
            this.level = levell;

        }
        public override double getFee(double feees)
        {
            return (feees + (0.1 * feees));
        }

    }
}
