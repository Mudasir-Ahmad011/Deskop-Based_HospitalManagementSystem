using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_App.DL;

namespace HMS_App.BL
{
    class Doctor:MUser
    {
        public Doctor(string username, string password, string role,string Scheduledate,string Doctorname,string profession,string startingtime,string endingtime):base(username,password,role)
        {
            this.Scheduledate = Scheduledate;
            this.Doctorname = Doctorname;
            this.profession = profession;
            this.startingtime = startingtime;
            this.endingtime = endingtime;

        }
        public Doctor() { }
        private string Scheduledate, Doctorname, profession, startingtime, endingtime;
        public List<Appointment> myAppointments = new List<Appointment>();
        public string getScheduledate() { return Scheduledate; }
        public string getDoctorname() { return Doctorname; }
        public string getProfession() { return profession; }
        public string getStartingtime() { return startingtime; }
        public string getEndingtime() { return endingtime; }
        public void setScheduledate(string Scheduledate) { this.Scheduledate = Scheduledate; }
        public void setDoctorname(string Doctorname) { this.Doctorname = Doctorname; }
        public void setProfession(string profession) { this.profession = profession; }
        public void setStartingtime(string startingtime) { this.startingtime = startingtime; }
        public void setEndingtime(string endingtime) { this.endingtime = endingtime; }
        
        public void AddData_inAppointmentList(List<Appointment> appointments)
        {
            bool check = false;
            foreach(var appointment in appointments)
            {
                foreach (var Appoinment in myAppointments)
                {
                    if (Appoinment.getName() != appointment.getName() || Appoinment.getDoctor() != appointment.getDoctor())
                    {
                        check = false;
                    }
                    else
                    {
                        check = true;
                        break;
                    }
                    
                }
                if (check == false)
                {
                    if (Doctorname == appointment.getDoctor())
                    {
                        myAppointments.Add(appointment);
                    }
                }
            }
        }
    }
}
