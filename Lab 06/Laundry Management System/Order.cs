using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry_Management_System
{
    internal class Order
    {
        public int orderId;
        public USER user;

        public string state;
        public string status = "Pending";

        public void setStatus(string x)
        {
            this.status = x;
        }

        public void setOrderId(int n)
        {
            this.orderId = n;
        }
        public void setUser(USER dummy_user)
        {
            this.user = dummy_user;
        }

        public string listShow()
        {
            return ("Shirt : " + this.user.userShirt + "\t Pant : " + this.user.userPant + "\t Suit : " + this.user.userSuit + "\t Bed Sheet : " + this.user.userBedSheet);
        }
    }
}
