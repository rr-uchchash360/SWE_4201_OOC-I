using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry_Management_System
{
    public partial class LaundryManagementSystem : Form
    {
        LMS lms = new LMS();

        public LaundryManagementSystem()
        {            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UserCreateButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.userName = CreateUserNameTextbox.Text;
            user.userId = CreateUserIDTextbox.Text;
            user.userAdddress = CreateUserAddressTextbox.Text;
            lms.users.Add(user);
            MessageBox.Show("User Added!");
            MessageBox.Show("User Added!");
        }

        private void UserOrderPlaceTextbox_Click(object sender, EventArgs e)
        {
            string id = OrderUserIDTextbox.Text;
            for (int i = 0; i < lms.users.Count; i++)
            {
                if (id == lms.users[i].userId)
                {
                    lms.users[i].userShirt = Convert.ToInt32(OrderUserShirtTextbox.Text);
                    lms.users[i].userPant = Convert.ToInt32(OrderUserPantTextbox.Text);
                    lms.users[i].userSuit = Convert.ToInt32(OrderUserSuitTextbox.Text);
                    lms.users[i].userBedSheet = Convert.ToInt32(OrderUserBedsheetTextbox.Text);
                    lms.users[i].shirtToDo = OrderUserShirtCombobox.Text;
                    lms.users[i].pantToDo = OrderUserPantCombobox.Text;
                    lms.users[i].suitToDo = OrderUserSuitCombobox.Text;
                    lms.users[i].BedSheetToDo = OrderUserBedsheetCombobox.Text;
                    string temp = Convert.ToString(Accounts.orderID);
                    MessageBox.Show("Order Placed.Order ID - " + temp);
                    int price = 0;
                    if (OrderUserShirtCombobox.Text != "")
                    {
                        if (OrderUserShirtCombobox.Text == "Both")
                        {
                            price += 60 * Convert.ToInt32(OrderUserShirtTextbox.Text);
                        }
                        else if (OrderUserShirtCombobox.Text == "Wash")
                        {
                            price += 50 * Convert.ToInt32(OrderUserShirtTextbox.Text);
                        }
                        else
                        {
                            price += 10 * Convert.ToInt32(OrderUserShirtTextbox.Text);
                        }
                    }
                    if (OrderUserPantCombobox.Text != "")

                    {
                        if (OrderUserPantCombobox.Text == "Both")
                        {
                            price += 60 * Convert.ToInt32(OrderUserPantTextbox.Text);
                        }
                        else if (OrderUserPantCombobox.Text == "Wash")
                        {
                            price += 50 * Convert.ToInt32(OrderUserPantTextbox.Text);
                        }
                        else
                        {
                            price += 10 * Convert.ToInt32(OrderUserPantTextbox.Text);
                        }
                    }
                    if (OrderUserSuitCombobox.Text != "")
                    {
                        if (OrderUserSuitCombobox.Text == "Both")
                        {
                            price += 60 * Convert.ToInt32(OrderUserSuitTextbox.Text);
                        }
                        else if (OrderUserSuitCombobox.Text == "Wash")
                        {
                            price += 50 * Convert.ToInt32(OrderUserSuitTextbox.Text);
                        }
                        else
                        {
                            price += 10 * Convert.ToInt32(OrderUserSuitTextbox.Text);
                        }
                    }
                    if (OrderUserBedsheetCombobox.Text != "")
                    {
                        if (OrderUserBedsheetCombobox.Text == "Both")
                        {
                            price += 60 * Convert.ToInt32(OrderUserBedsheetTextbox.Text);
                        }
                        else if (OrderUserBedsheetCombobox.Text == "Wash")
                        {
                            price += 50 * Convert.ToInt32(OrderUserBedsheetTextbox.Text);
                        }
                        else
                        {
                            price += 10 * Convert.ToInt32(OrderUserBedsheetTextbox.Text);
                        }
                    }
                    lms.users[i].amount += price;
                    Accounts.fund += price;

                    Order order = new Order();
                    order.setUser(lms.users[i]);
                    order.setOrderId(Accounts.orderID);
                    lms.orders.Add(order);

                    Accounts.orderID++;
                    break;


                }
                else
                {
                    MessageBox.Show("User Not Registered.");
                }
            }
        }

        private void SeeOrderDetailsButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(CheckOrderIDTextbox.Text);
            CheckDetailsListbox.Items.Clear();
            for (int i = 0; i < lms.orders.Count; i++)
            {
                if (id == lms.orders[i].orderId)
                {

                    CheckDetailsListbox.Items.Add(lms.orders[i].listShow());
                    CheckAmountTextbox.Text = " Amount : " + Convert.ToString(lms.orders[i].user.amount);
                    UserStatusTextbox.Text = "Status : " + lms.orders[i].status;
                    ShowUserNameTextbox.Text = "Name : " + lms.orders[i].user.userName;
                    ShowUserAddressTextbox.Text = "Address : " + lms.orders[i].user.userAdddress;
                }
            }
        }

        private void OwnerUserIDCheckButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(OwnerUserIDCheckTextbox.Text);

            for (int i = 0; i < lms.orders.Count; i++)
            {
                if (id == lms.orders[i].orderId)
                {
                    lms.orders[i].setStatus(OwnerUserIDCheckCombobox.Text);
                }
            }
            OwnerUserBalanceCheckTextbox.Text = Convert.ToString(Accounts.fund);
        }
    }
}
