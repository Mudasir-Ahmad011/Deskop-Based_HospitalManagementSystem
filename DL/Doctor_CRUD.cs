using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using HMS_App.BL;

namespace HMS_App.DL
{ 
    class Doctor_CRUD
    {
        public static List<Doctor> doctors = new List<Doctor>();
        
        public static void Add_Doctor(Doctor doctor)
        {
            doctors.Add(doctor);
        }
       
        public static void add_DoctorSchedule(Doctor doctor)
        {
            string path = "path\\doctor_schedule.txt";
            StreamWriter Doctor_schedule_file = new StreamWriter(path, true);
            Doctor_schedule_file.WriteLine(doctor.getScheduledate() + "," + doctor.getDoctorname() + "," + doctor.getProfession() + "," + doctor.getStartingtime() + "," + doctor.getEndingtime());
            Doctor_schedule_file.Flush();
            Doctor_schedule_file.Close();
        }
        public static void load_DoctorScheduleData()
        {
            string path = "path\\doctor_schedule.txt";
            string scheduledate, doctorname, Profession, starting_time, ending_time;
            string line;
            StreamReader file = new StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                string[] record = line.Split(',');
                scheduledate = record[0];
                doctorname = record[1];
                Profession = record[2];
                starting_time = record[3];
                ending_time = record[4];

               string Scheduledate = scheduledate;
               string Doctorname = doctorname;
               string profession = Profession;
               string startingtime = starting_time;
               string endingtime = ending_time;
               Doctor d = new Doctor();
                d.setScheduledate(Scheduledate);
                d.setDoctorname(Doctorname);
                d.setProfession(profession);
                d.setStartingtime(startingtime);
                d.setEndingtime(endingtime);
                doctors.Add(d);
            }
            file.Close();
        }
       
        public static void put_DoctorAppointment_inList(List<Appointment> appointments)
        {
            foreach(var Doctor in doctors)
            {
                Doctor.AddData_inAppointmentList(appointments);
            }
        }
        

    }
}
