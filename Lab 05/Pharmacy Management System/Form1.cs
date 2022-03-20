using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class PharmacyManagementSystem : Form
    {
        List<Medicine>medicines = new List<Medicine>();
        List<Medicine>sellMedicine = new List<Medicine>();

        public PharmacyManagementSystem()
        {
            InitializeComponent();
        }

        private void stockMedicineButton_Click(object sender, EventArgs e)
        {
            int flag = 0;
            foreach (Medicine medicine in medicines)
            {
                if (Medicne.getid() == )
            }

        }

        private void showAvailibilityButton_Click(object sender, EventArgs e)
        {

        }

        private void medicineSellButton_Click(object sender, EventArgs e)
        {

        }

        private void showTotalSellButton_Click(object sender, EventArgs e)
        {

        }
    }
}
