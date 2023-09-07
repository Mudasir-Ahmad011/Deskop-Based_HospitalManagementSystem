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
    public partial class AddMedicine_Form : Form
    {
        public AddMedicine_Form()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string MedicineName = txtMedicineName.Text;
            DateTime date = dtExpiryDate.Value;
            string Expirydate = Convert.ToDateTime(date).Date.ToString("d");
            int quantity = Convert.ToInt32(Math.Round(numQuantity.Value, 0));
            double price = Convert.ToDouble(Math.Round(numPrice.Value, 0));
            int demandcheck = quantity;
            Medicine med1 = new Medicine(MedicineName, quantity, Expirydate, price, demandcheck);
            Medicine_CRUD.Addmedicine(med1);
            Medicine_CRUD.addMedicineinFile();
            empty();
        }
        private void empty()
        {
            txtMedicineName.Text = null;
            numQuantity.Value = 0;
            numPrice.Value = 0;
            dtExpiryDate.Value = DateTime.Now;
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

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.Black;
            btnAdd.ForeColor = Color.White;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.FromArgb(128, 255, 128);
            btnAdd.ForeColor = Color.Black;
        }
    }
}
