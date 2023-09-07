using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_App.BL
{
    class PatientBill
    {
        //private string PatientnameBill;
        private string services;
        private int daysPatientstayed;
        private float bedcharge;
        private float labtest;
        private double total_bill;
        public string getServices() { return services; }
        public int getDaysPatientstayed() { return daysPatientstayed; }
        public float getBedcharge() { return bedcharge; }
        public float getLabtest() { return labtest; }
        public double getTotalbill() { return total_bill; }

        public void setServices(string services) { this.services = services; }
        public void setDayspatientstayed(int daysPatientstayed) { this.daysPatientstayed = daysPatientstayed; }
        public void setBedcharge(float bedcharge) { this.bedcharge = bedcharge; }
        public void setLabtest(float labtest) { this.labtest = labtest; }
        public void setTotalbill(float total_bill) { this.total_bill = total_bill; }
        public int ServiceCheck()
        {
            int hospitalizationcharge = 0;
            int emergency_room_charge = 0;
            int final_charges;

            if (services == "hospitalization")
            {
                hospitalizationcharge = 500;
            }
            if (services == "emergency room service")
            {
                emergency_room_charge = 2000;
            }
            return final_charges = hospitalizationcharge + emergency_room_charge;
        }
        public void calculate_totalBill(int hospitalizationcharge,int emergency_room_charge,float bedcharge,double totalpricemedicine)
        {
           total_bill = (hospitalizationcharge * daysPatientstayed) + (emergency_room_charge * daysPatientstayed) + (bedcharge * daysPatientstayed) + (labtest + totalpricemedicine);
        }
    }
}
