using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_App.DL;

namespace HMS_App.BL
{
    class Patient : MUser
    {

        public Patient(string username, string password, string role, string name, int age, string contactNo, string cnic, string address, string visit_date, string medicalHistory) : base(username, password, role)
        {
            this.name = name;
            this.age = age;
            this.contactNo = contactNo;
            this.cnic = cnic;
            this.address = address;
            this.visit_date = visit_date;
            this.medicalHistory = medicalHistory;
        }
        public Patient(string username, string password, string role) : base(username, password, role)
        {

        }
        public Patient()
        {

        }
        private string name;
        private int age;
        private string contactNo;
        private string cnic;
        private string address;
        private string visit_date;
        private string medicalHistory;
        public Report PatientReport = new Report();
        public PatientBill bill = new PatientBill();

        public string getName() { return name; }
        public int getAge() { return age; }
        public string getContactno() { return contactNo; }
        public string getCnic() { return cnic; }
        public string getAddress() { return address; }
        public string getVisitdate() { return visit_date; }
        public string getMedicalhistory() { return medicalHistory; }

        public void setName(string name) { this.name = name; }
        public void setAge(int age) { this.age = age; }
        public void setContactno(string contactNo) { this.contactNo = contactNo; }
        public void setCnic(string cnic) { this.cnic = cnic; }
        public void setAddress(string address) { this.address = address; }
        public void setVisitdate(string visit_date) { this.visit_date = visit_date; }
        public void setMedicalhistory(string medicalHistory) { this.medicalHistory = medicalHistory; }



        private string medicine;
        public string getMedicine() { return medicine; }
        public  void SymptomsCheck(string[] symptoms,int i,ref char check1,ref char check2,ref char check3)
        {
            if (symptoms[i] == "fever" || symptoms[i] == "pain" || symptoms[i] == "headache")
            {
                check1 = 'p';
            }
            if (symptoms[i] == "cold" || symptoms[i] == "flu")
            {
                check2 = 'c';
            }
            if (symptoms[i] == "cough")
            {
                check3 = 'h';
            }
        }
        public string GiveMedicine(char check1,char check2,char check3)
        {
            string medicine1 = "",medicine2="",medicine3="";
            if (check1 == 'p')
            {
                medicine1 = " Panadol";
            }
            else
            {
                medicine1 = "";
            }
            if (check2 == 'c')
            {
                medicine2 = " Crocin C&F max";
            }
            else
            {
                medicine2 = "";
            }
            if (check3 == 'h')
            {
                medicine3 = " Hydryllin";
            }
            else
            {
                medicine3 = "";
            }
           return medicine = medicine1 + medicine2 + medicine3;
            
        }
        
        
    }
}
