using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class ReservationTest
    {
        public User reservedUser { get; set; }
        public bool canBeCanceledBy(User user)
        {
            if (user.isAdmin == true)
                return true;
            if (user == reservedUser)
                return true;
            return false;
        }
    }

    public class User
    {
        public bool isAdmin;
        public User(bool isAdmin)
        {
            this.isAdmin = isAdmin;
        }
    }
}
