using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_App.BL;
namespace HMS_App.DL
{
    class Appointment_CRUD
    {
        public static List<Appointment> appointments = new List<Appointment>();

        public static void Add_Appointment(Appointment appointment)
        {
            appointments.Add(appointment);
        }
        
        public static bool canceledappointment(ref string cancelpatient)
        {
            bool exist = false;
            for (int i = 0; i < appointments.Count; i++)
            {
                if (cancelpatient == appointments[i].getName())
                {
                    exist = true;
                    appointments.RemoveAt(i);
                    break;
                }

            }
            return exist;
        }
        public static bool shiftedappointment(ref string ShiftedPatientname, ref string shiftdate, ref string shifttime)
        {
            bool exist = false;
            for (int i = 0; i < appointments.Count; i++)
            {
                if (ShiftedPatientname == appointments[i].getName())
                {
                    appointments[i].setDateappoint(shiftdate);
                    appointments[i].setTimeappoint(shifttime);
                    exist = true;
                }
            }
            return exist;
        }
        public static void aftershiftedORcancelappointment(int num)
        {

        }
        public static void cleanFile()
        {
            string path = "path\\appointment.txt";
            StreamWriter appointmentFile = new StreamWriter(path);
            appointmentFile.Flush();
            appointmentFile.Close();
        }
        public static void DATAaftershiftedORcancelappointment()
        {
            string path = "path\\appointment.txt";
            StreamWriter appointmentFile = new StreamWriter(path);
            for (int i = 0; i < appointments.Count; i++)
            {
                appointmentFile.WriteLine(appointments[i].getName() + "," + appointments[i].getDateappoint() + "," + appointments[i].getDoctor() + "," + appointments[i].getTimeappoint());
            }
            appointmentFile.Flush();
            appointmentFile.Close();
        }
        public static void add_appointmentinFile(Appointment appointment)
        {
            string path = "path\\appointment.txt";
            StreamWriter appointmentFile = new StreamWriter(path, true);
            appointmentFile.WriteLine(appointment.getName() + "," + appointment.getDateappoint() + "," + appointment.getDoctor() + "," + appointment.getTimeappoint());
            appointmentFile.Flush();
            appointmentFile.Close();
        }
        public static void load_appointment()
        {
            string appointmentDoctor, appointmentPatientname, Dateappoint, Timeappoint;
            string line;
            string path = "path\\appointment.txt";
            StreamReader appointmentFile = new StreamReader(path);
            while ((line = appointmentFile.ReadLine()) != null)
            {
                string[] record = line.Split(',');
                appointmentPatientname = record[0];
                Dateappoint = record[1];
                appointmentDoctor = record[2];
                Timeappoint = record[3];

                string name = appointmentPatientname;
                string dateappoint = Dateappoint;
                string doctor = appointmentDoctor;
                string timeappoint = Timeappoint;
                Appointment ap = new Appointment(name, dateappoint, doctor, timeappoint);
                appointments.Add(ap);
                Doctor_CRUD.put_DoctorAppointment_inList(appointments);
            }
            appointmentFile.Close();
        }



    }
}
