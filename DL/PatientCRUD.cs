using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_App.BL;

namespace HMS_App.DL
{
    class PatientCRUD
    {
        public static int bed = 150;
        public static List<Patient> patients = new List<Patient>();
        public static List<bool> bedAvaiables = new List<bool>();
        
        public static void Add_Patient(Patient p)
        {
            patients.Add(p);
        }
        
        public static bool addPatient_Dl(Patient p)
        {
            bool isbool;
            isbool = true;
            for (int i = 0; i < patients.Count; i++)
            {
                if (patients[i].getCnic() == p.getCnic())
                {
                    isbool = false;
                }
            }
            bed--;
            return isbool;
        }
      
        static string path_patient()
        {
            string path = "path\\Patient.txt";
            return path;
        }
        
        public static void save_patientdata(Patient p)
        {
            string path = path_patient();
            StreamWriter patient_file = new StreamWriter(path, true);
            patient_file.WriteLine(p.getName() + "," + p.getAge() + "," + p.getContactno() + "," + p.getCnic() + "," + p.getAddress() + "," + p.getVisitdate() + "," + p.getMedicalhistory());
            patient_file.Flush();
            patient_file.Close();
        }
        public static void load_patientdata()
        {
            string path = path_patient();
            string line;
            StreamReader patient_file = new StreamReader(path);
            while ((line = patient_file.ReadLine()) != null)
            {
                string[] record = line.Split(',');

                string name = record[0];
                int age = int.Parse(record[1]);
                string contactNo = record[2];
                string cnic = record[3];
                string address = record[4];
                string visit_date = record[5];
                string medicalHistory = record[6];
                Patient p = new Patient();
                p.setName(name);
                p.setAge(age);
                p.setContactno(contactNo);
                p.setCnic(cnic);
                p.setAddress(address);
                p.setVisitdate(visit_date);
                p.setMedicalhistory(medicalHistory);
                patients.Add(p);
            }
            patient_file.Close();
        }
        public static Patient update_patient_Dl(string patient_name, string cnicno)
        {
            for (int i = 0; i < patients.Count; i++)
            {
                if (patients[i].getName() == patient_name && patients[i].getCnic() == cnicno)
                {
                    return patients[i];
                }
                
            }
            return null;
        }
       public static void update_patientdata()
        {
            string path = "path\\Patient.txt";
            StreamWriter patient_file = new StreamWriter(path);
            foreach (var Patient in patients)
            {
                patient_file.WriteLine(Patient.getName() + "," + Patient.getAge() + "," + Patient.getContactno() + "," + Patient.getCnic() + "," + Patient.getAddress() + "," + Patient.getVisitdate() + "," + Patient.getMedicalhistory());
            }
            patient_file.Flush();
            patient_file.Close();
        }
      
        public static void add_medicalReport(Patient p)
        {
            string path = "path\\medicalReport.txt";
            StreamWriter Report_file = new StreamWriter(path,true);
            Report_file.Write(p.getName() + ",");
            Report_file.Write(p.PatientReport.getLaboratorytest() + ",");
            if (p.PatientReport.getLaboratorytest() == "blood test")
            {
                Report_file.Write(p.PatientReport.getCholestrolLevel() + ",");
                Report_file.Write(p.PatientReport.getCholestrol() + ",");
                Report_file.Write(p.PatientReport.getTyphoid() + ",");
                Report_file.Write(p.PatientReport.getMalaria() + ",");
                Report_file.Write(p.PatientReport.getAnemia() + ",");
            }
            Report_file.Write(p.PatientReport.getDiagnostictest());
            Report_file.WriteLine();
            Report_file.Flush();
            Report_file.Close();
        }
        public static void load_medicalReport()
        {
            string Name, laboratory_test, Cholestrol, Typhoid, Malaria, Anemia, diagnostic_test;
            int cholestrol_level;
            string line;
            string path = "path\\medicalReport.txt";
            int i = 0;
            StreamReader patient_file = new StreamReader(path);
            while ((line=patient_file.ReadLine())!=null)
            {
                string[] record = line.Split(',');
                Name = record[0];
                laboratory_test = record[1];
                cholestrol_level = int.Parse(record[2]);
                Cholestrol = record[3];
                Typhoid = record[4];
                Malaria = record[5];
                Anemia = record[6];
                diagnostic_test = record[7];

                patients[i].PatientReport.setLaboratorytest(laboratory_test);
                patients[i].PatientReport.setCholestrolLevel(cholestrol_level);
                patients[i].PatientReport.setCholestrol(Cholestrol);
                patients[i].PatientReport.setTyphoid(Typhoid);
                patients[i].PatientReport.setMalaria(Malaria);
                patients[i].PatientReport.setAnemia(Anemia);
                patients[i].PatientReport.setDiagnostictest(diagnostic_test);
                i++;
            }
            patient_file.Close();
        }
        public static bool dischargePatient(string discharge_patient, string dischargepatient_cnic)
        {
            bool discharge_check = false;
            for (int i = 0; i < patients.Count; i++)
            {
                if (patients[i].getCnic() == dischargepatient_cnic && discharge_patient == patients[i].getName())
                {
                    discharge_check = true;
                    patients.RemoveAt(i);
                    if (bed >= 1)
                    {
                        bed++;
                    }
                    break;
                }
            }
            return discharge_check;
        }
        
        public static void dataPatient_afterDelete()
        {
            string path = "path\\Patient.txt";
            StreamWriter patient_file = new StreamWriter(path);
            foreach (var Patient in patients)
            {
                patient_file.WriteLine(Patient.getName() + "," + Patient.getAge() + "," + Patient.getContactno() + "," + Patient.getCnic() + "," + Patient.getAddress() + "," + Patient.getVisitdate() + "," + Patient.getMedicalhistory());
            }
            patient_file.Flush();
            patient_file.Close();

        }
        public static void DataPatientReport_afterdelete()
        {
            string path = "path\\medicalReport.txt";
            StreamWriter Report_file = new StreamWriter(path);
            foreach (var Patient in patients)
            {
                Report_file.Write(Patient.getName() + ",");
                Report_file.Write(Patient.PatientReport.getLaboratorytest() + ",");
                if (Patient.PatientReport.getLaboratorytest() == "blood test")
                {
                    Report_file.Write(Patient.PatientReport.getCholestrolLevel() + ",");
                    Report_file.Write(Patient.PatientReport.getCholestrol() + ",");
                    Report_file.Write(Patient.PatientReport.getTyphoid() + ",");
                    Report_file.Write(Patient.PatientReport.getMalaria() + ",");
                    Report_file.Write(Patient.PatientReport.getAnemia() + ",");
                }
                Report_file.Write(Patient.PatientReport.getDiagnostictest());
                Report_file.WriteLine();
            }
            Report_file.Flush();
            Report_file.Close();
        }
        public static void dataPatientBill_afterdelete()
        {
            string path = "path\\Patient_bill.txt";
            StreamWriter billfile = new StreamWriter(path);
            foreach (var Patient in patients)
            {
                billfile.WriteLine(Patient.getName() + "," + Patient.bill.getDaysPatientstayed() + "," + Patient.bill.getBedcharge() + "," + Patient.bill.getLabtest() + "," + Patient.bill.getTotalbill());
            }
            billfile.Flush();
            billfile.Close();
        }
        public static void dataafter_deletefile()
        {
                dataPatient_afterDelete();
                dataPatientBill_afterdelete();
                DataPatientReport_afterdelete();
        }
       
        public static void add_billing(Patient p)
        {
            string path = "path\\Patient_bill.txt";
            StreamWriter billfile = new StreamWriter(path,true);
            billfile.WriteLine(p.getName() + "," + p.bill.getDaysPatientstayed() + "," + p.bill.getBedcharge() + "," + p.bill.getLabtest() + "," + p.bill.getTotalbill());
            billfile.Flush();
            billfile.Close();
        }
        public static void load_billing()
        {
            string patientnamebill;
            int dayspatientstayed;
            float bedCharge, lab_test, total_Bill;
            string line;
            string path = "path\\Patient_bill.txt";
            int countbill = 0;
            StreamReader file = new StreamReader(path);
            while ((line=file.ReadLine())!=null)
            {
                string[] record = line.Split(',');
                patientnamebill = record[0];
                dayspatientstayed = int.Parse(record[1]);
                bedCharge = float.Parse(record[2]);
                lab_test = float.Parse(record[3]);
                total_Bill = float.Parse(record[4]);

                //patients[countbill].PatientnameBill = patientnamebill;
                patients[countbill].bill.setDayspatientstayed(dayspatientstayed);
                patients[countbill].bill.setBedcharge(bedCharge);
                patients[countbill].bill.setLabtest(lab_test);
                patients[countbill].bill.setTotalbill(total_Bill);
                countbill++;
            }
            file.Close();
        }
       
        public static void saveBedChecker()
        {
            string path = "path\\BedAvailability.txt";
            StreamWriter file = new StreamWriter(path);
            for (int i = 0; i < bedAvaiables.Count; i++) {
                file.WriteLine(bedAvaiables[i]);
        }
            file.Flush();
            file.Close();
        }
        public static void loadBedChecker()
        {
            string path = "path\\BedAvailability.txt";
            string line;
            StreamReader file = new StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                bool record = bool.Parse(line);
                bedAvaiables.Add(record);
            }
            file.Close();
        }
    }
}
