using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_App.BL;
using System.IO;

namespace HMS_App.DL 
{ 
    class MUser_CRUD
    {
        private static List<MUser> usersList = new List<MUser>();

        internal static List<MUser> UsersList { get => usersList; set => usersList = value; }

        public static void addUserIntoList(MUser user)
        {
            UsersList.Add(user);
        }
        
        public static MUser SignIn(MUser user)
        {
            foreach (MUser storedUser in UsersList)
            {
                if (storedUser.UserName == user.UserName &&
                storedUser.UserPassword == user.UserPassword)
                {
                    return storedUser;
                }
            }
            return null;
        }
        public static void deleteUserFromList(MUser user)
        {
            for (int i = 0; i < UsersList.Count; i++)
            {
                if (usersList[i].UserName == user.UserName && usersList[i].UserPassword == user.UserPassword)
                {
                    usersList.RemoveAt(i);
                }
            }
        }
        public static void editUserFromList(MUser previous, MUser updated)
        {
            foreach (MUser user in UsersList)
            {
                if (user.UserName == previous.UserName && user.UserPassword == previous.UserPassword)
                {
                    user.UserName = updated.UserName;
                    user.UserPassword = updated.UserPassword;
                    user.UserRole = updated.UserRole;
                }
            }
        }
        public static bool loadFromFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string userName = splittedRecord[0];
                    string userPassword = (splittedRecord[1]);
                    string userRole = (splittedRecord[2]);
                    MUser M = new MUser(userName, userPassword, userRole);
                    addUserIntoList(M);

                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storeIntoFile(string path, MUser M)
        {

            StreamWriter f = new StreamWriter(path, true);

            f.WriteLine(M.UserName + "," + M.UserPassword + "," + M.UserRole);
            f.Flush();
            f.Close();
        }
        public static void storeAllUsersIntoFile(string path)
        {

            StreamWriter f = new StreamWriter(path);
            foreach (var M in UsersList)
            {
                f.WriteLine(M.UserName + "," + M.UserPassword + "," + M.UserRole);
            }
            f.Flush();
            f.Close();
        }
    }
}
