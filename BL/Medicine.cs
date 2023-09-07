using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_App.BL
{
    class Medicine
    {
        private string addmedicine;
        private int quantity;
        private string expirydate;
        private double price;
        private int demandcheck;
        public string getMedicinename() { return addmedicine; }
        public int getQuantity() { return quantity; }
        public string getExpirydate() { return expirydate; }
        public double getPrice() { return price; }
        public int getDemandcheck() { return demandcheck; }
        public void setMedicinename(string addmedicine) { this.addmedicine = addmedicine; }
        public void setQuantity(int quantity) { this.quantity = quantity; }
        public void setExpirydate(string expirydate) { this.expirydate = expirydate; }
        public void setPrice(double price) { this.price = price; }
        public void setDemandcheck(int demandcheck) { this.demandcheck = demandcheck; }
        public Medicine()
        {
            addmedicine = "";
            quantity = 0;
            expirydate = "";
            price = 0.0F;
            demandcheck = 0;
        }
        public Medicine(string addmedicine, int quantity, string expirydate, double price, int demandcheck)
        {
            this.addmedicine = addmedicine;
            this.quantity = quantity;
            this.expirydate = expirydate;
            this.price = price;
            this.demandcheck = demandcheck;
        }
       

    }


}