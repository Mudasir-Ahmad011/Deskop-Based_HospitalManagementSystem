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
    public partial class Generate_medical_Report_Form : Form
    {
        Patient p = PatientCRUD.patients[PatientCRUD.patients.Count - 1];
        public Generate_medical_Report_Form()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            string LabTestName = txtLabtestName.Text;
            int cholestrolLevel = int.Parse(txtCholestrolLevel.Text);
            string Typhoid = txtTyphoid.Text;
            string Malaria = txtMalaria.Text;
            string Anemia = txtAnemia.Text;
            string DiagnosticTestname = txtDiagnosticTest.Text;
                p.PatientReport.setLaboratorytest(LabTestName);
            if (LabTestName == "blood test")
            { 
                p.PatientReport.setCholestrolLevel(cholestrolLevel);
                p.PatientReport.Generatemedicalreport();
                p.PatientReport.setTyphoid(Typhoid);
                p.PatientReport.setMalaria(Malaria);
                p.PatientReport.setAnemia(Anemia);
            }
            p.PatientReport.setDiagnostictest(DiagnosticTestname);
            PatientCRUD.add_medicalReport(p);
            MessageBox.Show("Report is generated successfully");
            this.Close();
            Form newform = new Admin_menu_Form();
            newform.Show();
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

        private void btnNext_MouseEnter(object sender, EventArgs e)
        {
            btnNext.BackColor = Color.Black;
            btnNext.ForeColor = Color.White;
        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            btnNext.BackColor = Color.FromArgb(128, 255, 255);
            btnNext.ForeColor = Color.Black;
        }
    }
}
