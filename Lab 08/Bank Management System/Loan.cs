using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management_System
{
    internal class Loan : Account
    {
        public void interest(double amm)
        {
            amm += (amm * (9 / 100));
        }
    }
}
