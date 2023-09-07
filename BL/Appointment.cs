using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_App.DL;

namespace HMS_App.BL
{
    class Appointment
    {
        private string name;
        private string dateappoint;
        private string doctor;
        private string timeappoint;
        public string getName() { return name; }
        public string getDateappoint() { return dateappoint; }
        public string getDoctor() { return doctor; }
        public string getTimeappoint() { return timeappoint; }
        public void setName(string name) { this.name = name; }
        public void setDateappoint(string dateappoint) { this.dateappoint = dateappoint; }
        public void setDoctor(string doctor) { this.doctor = doctor; }
        public void setTimeappoint(string timeappoint) { this.timeappoint = timeappoint; }
        public Appointment() { }
        public Appointment(string name, string dateappoint, string doctor)
        {
            this.name = name;
            this.dateappoint = dateappoint;
            this.doctor = doctor;
        }
        public Appointment(string name, string dateappoint, string doctor,string timeappoint)
        {
            this.name = name;
            this.dateappoint = dateappoint;
            this.doctor = doctor;
            this.timeappoint = timeappoint;
        }

        public int Converttime(string timeappoint)
        {
            int time = 0;
            if (timeappoint[0] == '0')
            {
                time = 0;
            }
            if (timeappoint[0] == '1')
            {
                time = 1;
            }
            if (timeappoint[0] == '2')
            {
                time = 2;
            }
            if (timeappoint[0] == '3')
            {
                time = 3;
            }
            if (timeappoint[0] == '4')
            {
                time = 4;
            }
            if (timeappoint[0] == '5')
            {
                time = 5;
            }
            if (timeappoint[0] == '6')
            {
                time = 6;
            }
            if (timeappoint[0] == '7')
            {
                time = 7;
            }
            if (timeappoint[0] == '8')
            {
                time = 8;
            }
            if (timeappoint[0] == '9')
            {
                time = 9;
            }
            if (timeappoint[0] == '1' && timeappoint[1] == '0')
            {
                time = 10;
            }
            if (timeappoint[0] == '1' && timeappoint[1] == '1')
            {
                time = 11;
            }
            if (timeappoint[0] == '1' && timeappoint[1] == '2')
            {
                time = 12;
            }
            return time;
        }
        
    }
}
