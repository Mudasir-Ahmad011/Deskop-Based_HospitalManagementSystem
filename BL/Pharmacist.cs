using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_App.BL
{
    class Pharmacist:MUser
    {
        public Pharmacist(string username, string password, string role) : base(username, password, role)
        {

        }
        public Pharmacist(string username, string password) : base(username, password)
        {

        }
    }
}
