using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS_App.BL;
using HMS_App.DL;

namespace HMS_App.Patient_Form
{
    public partial class Billing_Form : Form
    {
        int count = 1;
        int firstCharge = 0;
        int secondCharge = 0;
        Patient P = PatientCRUD.patients[PatientCRUD.patients.Count - 1];
        PatientBill bill = PatientCRUD.patients[PatientCRUD.patients.Count-1].bill;
        public Billing_Form()
        {
            InitializeComponent();
        }

        private void btnCalculatebill_Click(object sender, EventArgs e)
        {
            double totalpricemedicine = 0F;
            int days = Convert.ToInt32(Math.Round(numpatientdaysinhospital.Value, 0));
            bill.setDayspatientstayed(days);
            for (int i = 0; i < Customer_CRUD.customers.Count; i++)
            {
                if (P.getName() == Customer_CRUD.customers[i].getcustomerName())
                {
                    totalpricemedicine = Customer_CRUD.customers[i].Calculate_Bill();
                    break;
                }
            }
            int bedCharge = Convert.ToInt32(Math.Round(numunitdaycharge.Value, 0));
            bill.setBedcharge(bedCharge);
            int labtest = Convert.ToInt32(Math.Round(numlabbill.Value, 0)); ;
            bill.setLabtest(labtest);
            bill.calculate_totalBill(firstCharge, secondCharge, bill.getBedcharge(), totalpricemedicine);
            double totalbill = bill.getTotalbill();
            txttotalBill.Text = ""+totalbill;
            PatientCRUD.add_billing(P);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string service = txtService.Text;
            if (count < 3)
            {
                if (count == 1)
                {
                    bill.setServices(service);
                    firstCharge = bill.ServiceCheck();
                }
                if (count == 2)
                {
                    if (service != bill.getServices())
                    {
                        bill.setServices(service);
                        secondCharge = bill.ServiceCheck();
                    }
                    else
                    {
                        MessageBox.Show("You Already added this service");
                        count -= 1;
                    }
                }
            }
            else { MessageBox.Show("You have added all available services NO MORE"); }
            count++;
        }


        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newform = new Admin_menu_Form();
            newform.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.Black;
            btnAdd.ForeColor = Color.White;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.FromArgb(128, 255, 255);
            btnAdd.ForeColor = Color.Black;
        }

        private void btnCalculatebill_MouseEnter(object sender, EventArgs e)
        {
            btnCalculatebill.BackColor = Color.Black;
            btnCalculatebill.ForeColor = Color.White;
        }

        private void btnCalculatebill_MouseLeave(object sender, EventArgs e)
        {
            btnCalculatebill.BackColor = Color.FromArgb(128, 255, 255);
            btnCalculatebill.ForeColor = Color.Black;
        }
    }
}
