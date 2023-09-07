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
    public partial class Admin_menu_Form : Form
    {
        public Admin_menu_Form()
        {
            InitializeComponent();
        }

       

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form newform = new HMSApplication();
            newform.Show();  
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            Form newForm = new Patient_Form.Add_Patient_Form();
            newForm.Show();
            this.Hide();
        }

        private void btnViewPatient_Click(object sender, EventArgs e)
        {
            Form newForm = new Patient_Form.View_Patient_form();
            newForm.Show();
            this.Hide();
        }

        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            Form newForm = new Patient_Form.Update_Patient_Form();
            newForm.Show();
            this.Hide();
        }

        private void btnIssueBed_Click(object sender, EventArgs e)
        {
            Form newForm = new Patient_Form.Issue_Bed_form();
            newForm.Show();
            this.Hide();
        }

        private void btnSuggestMedicine_Click(object sender, EventArgs e)
        {
            Form newForm = new Patient_Form.Suggest_Medicine_Form();
            newForm.Show();
            this.Hide();
        }

        private void btnManageDoctorSchedule_Click(object sender, EventArgs e)
        {
            Form newForm = new Patient_Form.Manage_DoctorSchedule_Form();
            newForm.Show();
            this.Hide();
        }

        private void btnManageAppointment_Click(object sender, EventArgs e)
        {
            Form newForm = new Patient_Form.ManageAppointments_form();
            newForm.Show();
            this.Hide();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            Form newForm = new Patient_Form.Generate_medical_Report_Form();
            newForm.Show();
            this.Hide();
        }

        private void btnCheckDoctorsAppointment_Click(object sender, EventArgs e)
        {
            Form newForm = new Patient_Form.Check_Doctor_Appointment_Form();
            newForm.Show();
            this.Hide();
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            Form newForm = new Patient_Form.Billing_Form();
            newForm.Show();
            this.Hide();
        }

        private void btnDischargePatient_Click(object sender, EventArgs e)
        {
            Form newForm = new Patient_Form.Discharge_Patient_Form();
            newForm.Show();
            this.Hide();
        }

        private void Admin_menu_Form_Load(object sender, EventArgs e)
        {
            
        }
    }
}
