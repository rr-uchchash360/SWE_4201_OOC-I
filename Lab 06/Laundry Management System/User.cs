using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry_Management_System
{
    internal class User
    {
        public string userName;
        public string userId;
        public string userAdddress;
        public int userShirt = 0, userPant = 0, userSuit = 0, userBedSheet = 0;
        public string shirtToDo, pantToDo, suitToDo, BedSheetToDo;
        public int amount;

        public void addShirt(int shirt)
        {
            this.userShirt += shirt;
        }
        public void addPant(int pant)
        {
            this.userPant += pant;
        }
        public void addSuit(int suit)
        {
            this.userSuit += suit;
        }
        public void addBedSheet(int bedSheet)
        {
            this.userBedSheet += bedSheet;
        }

    }
}
