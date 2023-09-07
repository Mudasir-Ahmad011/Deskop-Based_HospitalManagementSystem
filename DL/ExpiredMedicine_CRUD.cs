using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_App.BL;

namespace HMS_App.DL
{
    class ExpiredMedicine_CRUD
    {
        public static List<ExpiredMedicine> expiredmed = new List<ExpiredMedicine>();

        public static void addExpiredmedicine()
        {
            string path = "path\\ExpiredMedicine.txt";
            StreamWriter expirefile = new StreamWriter(path);
            for (int x = 0; x < expiredmed.Count; x++)
            {
                expirefile.WriteLine(expiredmed[x].getExpiredmedicine());
            }
            expirefile.Flush();
            expirefile.Close();
        }
    }
}
