using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_App.BL;

namespace HMS_App.DL
{
    class Medicine_CRUD
    {
        public static List<Medicine> meds = new List<Medicine>();
        public static void Addmedicine(Medicine med1)
        {
            meds.Add(med1);
        }
        
        public static string pathOfMedicineFile()
        {
            string path = "path\\medicine.txt";
            return path;
        }
        public static void addMedicineinFile()
        {
            string path = pathOfMedicineFile();
            StreamWriter medicineFile = new StreamWriter(path, true);
            medicineFile.WriteLine(meds[meds.Count - 1].getMedicinename() + "," + meds[meds.Count - 1].getQuantity() + "," + meds[meds.Count - 1].getDemandcheck() + "," + meds[meds.Count - 1].getExpirydate() + "," + meds[meds.Count - 1].getPrice());
            medicineFile.Flush();
            medicineFile.Close();
        }

        public static void load_medicineFile()
        {
            string Addmedicine, Expirydate;
            int Quantity, Demandcheck;
            double Price;
            string path = pathOfMedicineFile();
            string record;
            StreamReader file = new StreamReader(path);
            while ((record = file.ReadLine()) != null)
            {
                string[] line = record.Split(',');
                Addmedicine = line[0];
                Quantity = int.Parse(line[1]);
                Demandcheck = int.Parse(line[2]);
                Expirydate = line[3];
                Price = double.Parse(line[4]);

                Medicine med1 = new Medicine();


                med1.setMedicinename(Addmedicine);
                med1.setQuantity(Quantity);
                med1.setDemandcheck(Demandcheck);
                med1.setExpirydate(Expirydate);
                med1.setPrice(Price);

                meds.Add(med1);
            }
            file.Close();
        }
       
        public static Medicine Updatemedicine_Check(string updatemedicine)
        {
            foreach (Medicine i in meds)
            {
                if (updatemedicine == i.getMedicinename())
                {
                    return i;
                }
            }
            return null;
            
        }
        public static void SaveChange()
        {
            string path = pathOfMedicineFile();
            StreamWriter medicineFile = new StreamWriter(path);
            foreach (var med in meds)
            {  
                
                medicineFile.WriteLine(med.getMedicinename() + "," + med.getQuantity() + "," + med.getDemandcheck() + "," + med.getExpirydate() + "," + med.getPrice());
            }
            medicineFile.Flush();
            medicineFile.Close();
        }
        public static void saveUpdatedmedicine_data()
        {
            string path = pathOfMedicineFile();
            StreamWriter medicineFile = new StreamWriter(path);
            for (int i = 0; i < meds.Count; i++)
            {
                updatemedicinedata(i,medicineFile);
            }
            medicineFile.Flush();
            medicineFile.Close();
        }
        public static void updatemedicinedata(int num,StreamWriter medicineFile)
        {
           
            medicineFile.WriteLine(meds[num].getMedicinename() + "," + meds[num].getQuantity() + "," + meds[num].getDemandcheck() + "," + meds[num].getExpirydate() + "," + meds[num].getPrice());
           
        }
       
        public static bool deletemedicine(string delmedicine)
        {
            bool delmedicineCheck = false;
            for (int i = 0; i < meds.Count; i++)
            {
                if (delmedicine == meds[i].getMedicinename())
                {

                    delmedicineCheck = true;
                    meds.RemoveAt(i);
                    break;
                }
            }
            return delmedicineCheck;
        }
        
        public static void AFTERDeleteMedicine(int num,StreamWriter medicineFile)
        {
            
            medicineFile.WriteLine(meds[num].getMedicinename() + "," + meds[num].getQuantity() + "," + meds[num].getDemandcheck() + "," + meds[num].getExpirydate() + "," + meds[num].getPrice());
            
        }
        public static void DataAFTERDeleteMedicine()
        {
            string path = pathOfMedicineFile();
            StreamWriter medicineFile = new StreamWriter(path);
            for (int i = 0; i < meds.Count; i++)
            {
                AFTERDeleteMedicine(i,medicineFile);
            }
            medicineFile.Flush();
            medicineFile.Close();
        }


    }
}
