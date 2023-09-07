using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_App.BL
{
    public class MUser
    {
        protected string userName;
        protected string userPassword;
        protected string userRole;
        public MUser() { }
        public MUser(string userName, string userPassword)
        {
            this.UserName = userName;
            this.UserPassword = userPassword;
            this.UserRole = "NA";
        }
        public MUser(string userName, string userPassword, string userRole)
        {
            this.UserName = userName;
            this.UserPassword = userPassword;
            this.UserRole = userRole;
        }

        public string UserName { get => userName; set => userName = value; }
        public string UserPassword { get => userPassword; set { userPassword = value; } }
        public string UserRole { get => userRole; set => userRole = value; }

        public bool isAdmin()
        {
            if (this.UserRole == "Admin" || this.UserRole == "admin")
            {
                return true;
            }
            return false;
        }
        public bool isPatient()
        {
            if (UserRole == "Patient" || UserRole == "patient")
            {
                return true;
            }
            return false;
        }
        public bool isPharmacist()
        {
            if (UserRole == "Pharmacist" || UserRole == "pharmacist")
            {
                return true;
            }
            return false;
        }
    }
}
