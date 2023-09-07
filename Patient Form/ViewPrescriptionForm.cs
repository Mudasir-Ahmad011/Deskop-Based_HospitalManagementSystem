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

namespace HMS_App.Patient_Form
{
    public partial class ViewPrescriptionForm : Form
    {
        public ViewPrescriptionForm()
        {
            InitializeComponent();
        }

        private void ViewPrescriptionForm_Load(object sender, EventArgs e)
        {

        }

        private void ViewPrescriptionForm_Load_1(object sender, EventArgs e)
        {
            for (int i = 0; i < PatientCRUD.patients.Count; i++)
            {
                if (DetailForm.patientCnic == PatientCRUD.patients[i].getCnic())
                {
                    lblprescription.Text = PatientCRUD.patients[i].getMedicine();
                    break;
                }
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
