using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS_App.DL;
using HMS_App.BL;

namespace HMS_App.Pharmacy_Form
{
    public partial class UpdateMedicine_Form : Form
    {
        Medicine medicine;
        string change;
        public UpdateMedicine_Form()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string medicineName = txtMedicine.Text;
            medicine = Medicine_CRUD.Updatemedicine_Check(medicineName);
            if (medicine == null)
            {
                MessageBox.Show("This medicine is not in our database");
                txtMedicine.Text = null;
            }
            else { MessageBox.Show("Medicine found"); }
        }

        private void btncontinue_Click(object sender, EventArgs e)
        {
            change = txtchange.Text;
            if (change == "medicine name" || change == "quantity" || change == "Quantity" || change == "expiry date" || change == "price" || change == "Prize")
            {
                lbldepend.Text = change + ":";
            }
            else { MessageBox.Show("Enter valid change"); txtchange.Text = null; }
        }
        private void empty()
        {
            txtchange.Text = null;
            txtMedicine.Text = null;
            txtupdatebox.Text = null;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (change == "medicine name")
            {
                medicine.setMedicinename(txtupdatebox.Text);
            }
            if (change == "quantity" || change == "Quantity")
            {
                medicine.setQuantity(int.Parse(txtupdatebox.Text));
            }
            if (change == "expiry date")
            {
                medicine.setExpirydate(txtupdatebox.Text);
            }
            if (change == "price" || change == "Prize")
            {
                medicine.setPrice(double.Parse(txtupdatebox.Text));
            }
            Medicine_CRUD.saveUpdatedmedicine_data();
            empty();
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

        private void btnCheck_MouseEnter(object sender, EventArgs e)
        {
            btnCheck.BackColor = Color.Black;
            btnCheck.ForeColor = Color.White;
        }

        private void btnCheck_MouseLeave(object sender, EventArgs e)
        {
            btnCheck.BackColor = Color.FromArgb(128, 255, 128);
            btnCheck.ForeColor = Color.Black;
        }

        private void btncontinue_MouseEnter(object sender, EventArgs e)
        {
            btncontinue.BackColor = Color.Black;
            btncontinue.ForeColor = Color.White;
        }

        private void btncontinue_MouseLeave(object sender, EventArgs e)
        {
            btncontinue.BackColor = Color.FromArgb(128, 255, 128);
            btncontinue.ForeColor = Color.Black;
        }

        private void btnUpdate_MouseEnter(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.Black;
            btnUpdate.ForeColor = Color.White;
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.FromArgb(128, 255, 128);
            btnUpdate.ForeColor = Color.Black;
        }
    }
}
