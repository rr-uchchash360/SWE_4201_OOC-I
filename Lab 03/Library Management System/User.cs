using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class User
    {
        public string userName;
        public int userID;
        public string userAddress;
        public List<int> books = new List<int>();

        public User (int userid, string username, string useraddress)
        {
            this.userID = userid;
            this.userName = username;
            this.userAddress = useraddress;
        }
        public void AddBook(int userid)
        {
            books.Add(userid);
        }
    }
}
