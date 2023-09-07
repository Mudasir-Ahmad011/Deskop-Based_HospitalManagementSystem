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
    public partial class ViewMedicalReportForm : Form
    {
        public ViewMedicalReportForm()
        {
            InitializeComponent();
        }

        private void ViewMedicalReportForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < PatientCRUD.patients.Count; i++)
            {
                if (DetailForm.patientCnic == PatientCRUD.patients[i].getCnic())
                {
                    if (PatientCRUD.patients[i].PatientReport.getLaboratorytest() == "blood test")
                    {
                        ShowLABTest(i);
                    }
                    Show_medical_history(i);
                    Show_Diagnostic_test(i);
                }
            }
        }
        private void ShowLABTest(int i)
        {
            lblCholestrolLevel.Text = ""+PatientCRUD.patients[i].PatientReport.getCholestrolLevel();
            lblCholestrol.Text =  PatientCRUD.patients[i].PatientReport.getCholestrol();
            lbltyphoid.Text = PatientCRUD.patients[i].PatientReport.getTyphoid();
            lblmalaria.Text = PatientCRUD.patients[i].PatientReport.getMalaria();
            lblanemia.Text = PatientCRUD.patients[i].PatientReport.getAnemia();
        }
        private void Show_medical_history(int i)
        {
            lblMedicalHistory.Text = PatientCRUD.patients[i].getMedicalhistory();
        }
        private void Show_Diagnostic_test(int i)
        {
            lbldiagnostic.Text = PatientCRUD.patients[i].PatientReport.getDiagnostictest();
            lblnormal.Text = "normal";
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
