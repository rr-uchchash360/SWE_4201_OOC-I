using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management_System
{
    internal class Savings : Account
    {
        public double transLimit = 5;

        public bool checkLimit()
        {
            if (transLimit == 0)
                return false;
            else return true;
        }
    }
}
