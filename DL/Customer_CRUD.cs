using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HMS_App.BL;

namespace HMS_App.DL
{
    class Customer_CRUD
    {
        public static List<Customer> customers = new List<Customer>();

        public static void AddCustomerinList(Customer c)
        {
            customers.Add(c);
        }
        
        public static void add_purchaseMedicineinFile()
        {
            string path = "path\\purchaseMedicine.txt";
            StreamWriter purchasefile = new StreamWriter(path, true);
            purchasefile.Write(customers[customers.Count - 1].getcustomerName() + ":");
            List<Medicine> purchasemed = customers[customers.Count - 1].getPurchasedMedicines();
            for(int i = 0; i < purchasemed.Count - 1; i++)
            {
                purchasefile.Write(purchasemed[i].getMedicinename() + "," + purchasemed[i].getQuantity() + "," + purchasemed[i].getPrice());
                purchasefile.Write("-");
            }
            purchasefile.Write(purchasemed[purchasemed.Count-1].getMedicinename() + "," + purchasemed[purchasemed.Count - 1].getQuantity() + "," + purchasemed[purchasemed.Count - 1].getPrice());
            purchasefile.WriteLine();

            purchasefile.Flush();
            purchasefile.Close();
        }

        public static void load_purchaseMedicine()
        {
            string path = "path\\purchaseMedicine.txt";
            StreamReader purchasefile = new StreamReader(path);
            string line, Customername, purchasemedicine, Quantitypurchase, total_Price;
            string Purchasedmedicines,separatePurchaseMed;
            
            while ((line = purchasefile.ReadLine()) != null)
            {
                Customer customer = new Customer();
                string[] record = line.Split(':');
                Customername = record[0];
                customer.setcustomerName(Customername);
                Purchasedmedicines = record[1];
                string[] record1 = Purchasedmedicines.Split('-');
                for(int i = 0; i < record1.Length; i++)
                {
                    separatePurchaseMed = record1[i];
                    string[] record3 = separatePurchaseMed.Split(',');
                    purchasemedicine = record3[0];
                    Quantitypurchase = record3[1];
                    total_Price = record3[2];
                    Medicine purchase_medicine = new Medicine();
                    purchase_medicine.setMedicinename(purchasemedicine);
                    purchase_medicine.setQuantity(int.Parse(Quantitypurchase));
                    purchase_medicine.setPrice(float.Parse(total_Price));
                    customer.AddMedicineInList(purchase_medicine);
                }
                customers.Add(customer);
            }

            purchasefile.Close();
        }
        
    }
}
