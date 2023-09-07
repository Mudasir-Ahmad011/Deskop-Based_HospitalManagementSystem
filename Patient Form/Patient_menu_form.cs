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
    public partial class Patient_menu_form : Form
    {
        public Patient_menu_form()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form newform = new HMSApplication();
            newform.Show();
            this.Hide();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            Form newform = new DetailForm();
            newform.Show();
            this.Hide();
        }

        private void Patient_menu_form_Load(object sender, EventArgs e)
        {
            

           
        }

        private void btnViewPrescription_Click(object sender, EventArgs e)
        {
            Form newform = new ViewPrescriptionForm();
            newform.Show();
        }

        private void btnViewCommonDiseases_Click(object sender, EventArgs e)
        {
            Form newform = new ViewCommonDiseasesForm();
            newform.Show();
        }

        private void btnViewMedicalReport_Click(object sender, EventArgs e)
        {
            Form newform = new ViewMedicalReportForm();
            newform.Show();
        }

        private void btnCheckBill_Click(object sender, EventArgs e)
        {
            Form newform = new CheckBill_Form();
            newform.Show();
        }

        private void btnCheckBedAvailability_Click(object sender, EventArgs e)
        {
            Form newform = new CheckBedAvailabilityForm();
            newform.Show();
        }

        private void btnCheckDoctorSchedule_Click(object sender, EventArgs e)
        {
            Form newform = new CheckDoctorSchedule_Form();
            newform.Show();
        }

        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            Form newform = new BookAppointmentForm();
            newform.Show();
        }

        private void btnSatisfactionSurvey_Click(object sender, EventArgs e)
        {
            Form newform = new PatientSatisfactionSurveyForm();
            newform.Show();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
