using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_App.BL
{
    class Management_Staff:MUser
    {
        public Management_Staff(string username, string password, string role) : base(username, password, role)
        {

        }
        public Management_Staff(string username, string password) : base(username, password)
        {

        }

    }
}
