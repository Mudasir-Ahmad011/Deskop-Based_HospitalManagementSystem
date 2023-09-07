using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_App.BL
{
    class Customer
    {
       private string customerName;
       private List<Medicine> PurchaseMedicines = new List<Medicine>();
        public Customer(string customerName)
        {
            this.customerName = customerName;
        }
        public Customer()
        {

        }
        public string getcustomerName()
        {
            return customerName;
        }
        public void setcustomerName(string customerName)
        {
            this.customerName = customerName;
        }
        public List<Medicine> getPurchasedMedicines()
        {
            return PurchaseMedicines;
        }
        public void setPurchasedMedicines(List<Medicine> PurchaseMedicines)
        {
            this.PurchaseMedicines = PurchaseMedicines;
        }
        public void AddMedicineInList(Medicine PurchaseMed)
        {
            PurchaseMedicines.Add(PurchaseMed);
        }
        public Medicine purchasemedicine(List<Medicine> med, Medicine purchasemed1)
        {
            foreach (Medicine i in med)
            {
                if (purchasemed1.getMedicinename() == i.getMedicinename())
                {
                    if (purchasemed1.getQuantity() <= i.getQuantity())
                    {
                        int final_quantity = i.getQuantity() - purchasemed1.getQuantity();
                        i.setQuantity(final_quantity);
                        purchasemed1.setExpirydate(i.getExpirydate());
                        purchasemed1.setPrice(i.getPrice());
                        purchasemed1.setDemandcheck(i.getDemandcheck());
                        return i;
                    }
                }
            }
            return null;
        }
        public double Calculate_Bill()
        {
            double total_price = 0F;
            foreach(var med in PurchaseMedicines)
            {
                double perPrice = med.getPrice() * med.getQuantity();
                total_price = total_price + perPrice;
            }
            return total_price;
        }
        
    }
}
