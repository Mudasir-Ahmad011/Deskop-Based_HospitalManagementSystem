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
    
    public partial class Update_Patient_Form : Form
    {
        Patient p1;
        DataTable table = new DataTable("UpdatePatient");
        public Update_Patient_Form()
        {
            InitializeComponent();
        }

        private void Update_Patient_Form_Load(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string patientName = txtPatientUpdatename.Text;
            string cnicNO = txtCnicnoUpdate.Text;
            UPDATE_Patient_Check(ref patientName,ref cnicNO);
        }
        private void UPDATE_Patient_Check(ref string patientName,ref string cnicNO)
        {
            p1 = PatientCRUD.update_patient_Dl(patientName, cnicNO);
            ifPatientnotExist(p1);
        }
        private void PatientColumnsHeading()
        {
            table.Columns.Add("Patient name", Type.GetType("System.String"));
            table.Columns.Add("Age", Type.GetType("System.String"));
            table.Columns.Add("Phone no", Type.GetType("System.String"));
            table.Columns.Add("Cnic", Type.GetType("System.String"));
            table.Columns.Add("Address", Type.GetType("System.String"));
        }
        private void ifPatientnotExist(Patient p)
        {
            if (p != null)
            {
                PatientColumnsHeading();
                table.Rows.Add(p.getName(), p.getAge(), p.getContactno(), p.getCnic(), p.getAddress());
                UpdatePatientGV.DataSource = table;
                txtPatientname.Text=p.getName();
                txtage.Text=""+p.getAge();
                txtPhoneno.Text=p.getContactno();
                txtCnicno.Text=p.getCnic();
                string date = p.getVisitdate();
                dtvisitdate.Value=DateTime.Parse(date);
                txtAddress.Text=p.getAddress();
                txtmedicalHistory.Text=p.getMedicalhistory();
                /* Admin_interface.updatepatient_after(p);
                 PatientCRUD.update_patientdata();*/
            }
            if(p == null)
            {
                MessageBox.Show("The patient is not exist in our database");
                empty();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtPatientname.Text;
            int age = int.Parse(txtage.Text);
            string phoneNo = txtPhoneno.Text;
            string cnic = txtCnicno.Text;
            DateTime date = dtvisitdate.Value;
            string datevisit = Convert.ToDateTime(date).Date.ToString("d");
            string Address = txtAddress.Text;
            string MedicalHistory = txtmedicalHistory.Text;
            p1.setName(name);
            p1.setAge(age);
            p1.setContactno(phoneNo);
            p1.setCnic(cnic);
            p1.setVisitdate(datevisit);
            p1.setAddress(Address);
            p1.setMedicalhistory(MedicalHistory);
            UpdateMessage();
            empty();
        }
        private void UpdateMessage()
        {
            MessageBox.Show("Selected Patient data is Updated");
        }
        private void empty()
        {
            txtPatientUpdatename.Text=String.Empty;
            txtCnicnoUpdate.Text=String.Empty;
            txtPatientname.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtage.Text = String.Empty;
            txtCnicno.Text = String.Empty;
            txtmedicalHistory.Text = String.Empty;
            txtPhoneno.Text = String.Empty;
            dtvisitdate.Value = DateTime.Now;
            UpdatePatientGV.DataSource = null;
            table.Columns.Clear();
            table.Rows.Clear();
        }

        private void HometoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form newform = new Admin_menu_Form();
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
            btnCheck.BackColor = Color.FromArgb(128, 255, 255);
            btnCheck.ForeColor = Color.Black;
        }

        private void btnUpdate_MouseEnter(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.Black;
            btnUpdate.ForeColor = Color.White;
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.FromArgb(128, 255, 255);
            btnUpdate.ForeColor = Color.Black;
        }
    }
}
