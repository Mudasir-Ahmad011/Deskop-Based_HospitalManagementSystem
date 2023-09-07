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
    public partial class DeleteMedicine_Form : Form
    {
        public DeleteMedicine_Form()
        {
            InitializeComponent();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string deleteMedicine = txtdeleteMedicine.Text;
            bool delmedicineCheck = Medicine_CRUD.deletemedicine(deleteMedicine);
            if (delmedicineCheck == true)
            {
                MessageBox.Show("Requested medicine is deleted");
                Medicine_CRUD.DataAFTERDeleteMedicine();
            }
            else
            {
                MessageBox.Show("The medicine does not exist in our database");
            }
            txtdeleteMedicine.Text = null;
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

        private void btndelete_MouseEnter(object sender, EventArgs e)
        {
            btndelete.BackColor = Color.Black;
            btndelete.ForeColor = Color.White;
        }

        private void btndelete_MouseLeave(object sender, EventArgs e)
        {
            btndelete.BackColor = Color.FromArgb(128, 255, 128);
            btndelete.ForeColor = Color.Black;
        }
    }
}
