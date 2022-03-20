using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System
{
    internal class Medicine
    {
        public string medicineName;
        public int medicineQuantity = 0;
        private int medicineUnitPrice;

        public int getMedicineUnitPrice()
        { 
            return medicineUnitPrice; 
        }

        public int setMedicineUnitPrice(int medPrice)
        {
            medicineUnitPrice = medicineUnitPrice;
        }

    }
}
