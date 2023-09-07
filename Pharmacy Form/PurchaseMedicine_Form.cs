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

namespace HMS_App.Pharmacy_Form
{
    public partial class PurchaseMedicine_Form : Form
    {
        Customer customer;

        public PurchaseMedicine_Form()
        {
            InitializeComponent();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            string textcustomer = txtCustomername.Text;
            customer = new Customer();
            customer.setcustomerName(textcustomer);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Medicine purchasemed = new Medicine();
            string MedicineName = txtmedicinename.Text;
            purchasemed.setMedicinename(MedicineName);

            string quantityPurchaseInString = txtquantity.Text;
            purchasemed.setQuantity(int.Parse(quantityPurchaseInString));
            purchasemed = customer.purchasemedicine(Medicine_CRUD.meds, purchasemed);

            if (purchasemed != null)
            {
                customer.AddMedicineInList(purchasemed);
                MessageBox.Show("Added");
            }
            else
            {
                MessageBox.Show("This medicine is out of stock");
            }
            txtmedicinename.Text = null;
            txtquantity.Text = null;
        }

        private void btnpurchase_Click(object sender, EventArgs e)
        {
            Customer_CRUD.AddCustomerinList(customer);
            double totalMedicine_Bill = customer.Calculate_Bill();
            lblmedicineExpense.Text = ""+totalMedicine_Bill;
            Customer_CRUD.add_purchaseMedicineinFile();
            Medicine_CRUD.SaveChange();
            MessageBox.Show("Purchased");
            empty();
        }
        private void empty()
        {
            txtCustomername.Text = null;
            txtmedicinename.Text = null;
            txtquantity.Text = null;
            lblmedicineExpense.Text = null;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newform = new Pharmacy_Menu_Form();
            newform.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnnext_MouseEnter(object sender, EventArgs e)
        {
            btnnext.BackColor = Color.Black;
            btnnext.ForeColor = Color.White;
        }

        private void btnnext_MouseLeave(object sender, EventArgs e)
        {
            btnnext.BackColor = Color.FromArgb(128, 255, 128);
            btnnext.ForeColor = Color.Black;
        }

        private void btnadd_MouseEnter(object sender, EventArgs e)
        {
            btnadd.BackColor = Color.Black;
            btnadd.ForeColor = Color.White;
        }

        private void btnadd_MouseLeave(object sender, EventArgs e)
        {
            btnadd.BackColor = Color.FromArgb(128, 255, 128);
            btnadd.ForeColor = Color.Black;
        }

        private void btnpurchase_MouseEnter(object sender, EventArgs e)
        {
            btnpurchase.BackColor = Color.Black;
            btnpurchase.ForeColor = Color.White;
        }

        private void btnpurchase_MouseLeave(object sender, EventArgs e)
        {
            btnpurchase.BackColor = Color.FromArgb(128, 255, 128);
            btnpurchase.ForeColor = Color.Black;
        }
    }
}
