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
    public partial class Discharge_Patient_Form : Form
    {
        public Discharge_Patient_Form()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string discharge_patient = txtname.Text;
            string dischargepatient_cnic = txtCnic.Text;
            bool discharge_check = PatientCRUD.dischargePatient(discharge_patient, dischargepatient_cnic);
            if (discharge_check == true)
            {
                MessageBox.Show("The Patient is discharge successfully");
                PatientCRUD.dataafter_deletefile();
            }
            else
            {
                MessageBox.Show("The patient does not exist in our database");
            }
            empty();
        }
        private void empty()
        {
            txtname.Text = null;
            txtCnic.Text = null;
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

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.Black;
            btnDelete.ForeColor = Color.White;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.FromArgb(128, 255, 255);
            btnDelete.ForeColor = Color.Black;
        }
    }
}
