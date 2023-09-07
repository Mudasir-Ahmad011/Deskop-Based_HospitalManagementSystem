using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS_App.Patient_Form;
using HMS_App.Pharmacy_Form;
using HMS_App.DL;
namespace HMS_App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            string path = "data.txt";
            if (MUser_CRUD.loadFromFile(path))
            {
                MessageBox.Show("Data Loaded from the file");
            }
            else
            {
                MessageBox.Show("Data not Loaded");
            }

            PatientCRUD.load_patientdata();
            PatientCRUD.loadBedChecker();
            Doctor_CRUD.load_DoctorScheduleData();
            Appointment_CRUD.load_appointment();

            Doctor_CRUD.put_DoctorAppointment_inList(Appointment_CRUD.appointments);

            PatientCRUD.load_medicalReport();
            PatientCRUD.load_billing();
            Medicine_CRUD.load_medicineFile();
            Customer_CRUD.load_purchaseMedicine();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HMSApplication());
        }
    }
}
