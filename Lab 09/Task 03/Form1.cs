using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_03
{
    public partial class AnimalManagement : Form
    {
        public AnimalManagement()
        {
            InitializeComponent();
        }

        private void cowDataShowButton_Click(object sender, EventArgs e)
        {
            Cow dummycow = new Cow(cowNameTextBox.Text, cowHabitatTextBox.Text, "", Convert.ToInt32(cowHeightTextBox.Text), Convert.ToInt32(cowWeightTextBox.Text));

            dummycow.Age = Convert.ToInt32(cowAgeTextBox.Text);

            cowListBox.Items.Add(dummycow.getInformation());
        }

        private void catDataShowButton_Click(object sender, EventArgs e)
        {
            Cat dummycow = new Cat(catNameTextBox.Text, catHabitatTextBox.Text, "", Convert.ToInt32(catHeightTextBox.Text), Convert.ToInt32(catWeightTextBox.Text));

            dummycow.Age = Convert.ToInt32(catAgeTextBox.Text);

            catListBox.Items.Add(dummycow.getInformation());
        }

        private void chickenDataShowButton_Click(object sender, EventArgs e)
        {
            Chicken dummycow = new Chicken(chickenNameTextBox.Text, chickenHabitatTextBox.Text, "", Convert.ToInt32(chickenHeightTextBox.Text), Convert.ToInt32(chickenWeightTextBox.Text));

            dummycow.Age = Convert.ToInt32(chickenAgeTextBox.Text);

            chickenListBox.Items.Add(dummycow.getInformation());
        }
    }
}
