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
    public partial class Add_Patient_Form : Form
    {
        public Add_Patient_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string patient_name = txtpatient.Text;
            int age = int.Parse(txtage.Text);
            string phoneno = txtphone.Text;
            string cnic = txtcnicno.Text;
            string address = txtaddress.Text;
            DateTime date = dtvisitdate.Value;
            string datevisit = Convert.ToDateTime(date).Date.ToString("d");
            string medicalHistory = txtmedicalhistory.Text;
            Patient p = new Patient();
            p.setName(patient_name);
            p.setAge(age);
            p.setContactno(phoneno);
            p.setCnic(cnic);
            p.setAddress(address);
            p.setVisitdate(datevisit);
            p.setMedicalhistory(medicalHistory);
            ADD_Patient(p);

        }
        private void ADD_Patient(Patient P)
        {
            bool check = PatientCRUD.addPatient_Dl(P);
            if (check == false)
            {
               MessageBox.Show("This patient record is already exist");
                Empty();
            }
            else
            {
                PatientCRUD.Add_Patient(P);
                PatientCRUD.save_patientdata(P);
                MessageBox.Show("The Patient is Added Successfully and Please give proper info by choosing other options for single Patient before adding next Patient");
                this.Close();
                Form newform = new Admin_menu_Form();
                newform.Show();
            }
        }
        private void Empty()
        {
            txtpatient.Text = String.Empty;
            txtage.Text = String.Empty;
            txtcnicno.Text = String.Empty;
            txtphone.Text = String.Empty;
            txtaddress.Text = String.Empty;
            dtvisitdate.Value = DateTime.Now;

        }
        private void Add_Patient_Form_Load(object sender, EventArgs e)
        {

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

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.Black;
            btnAdd.ForeColor = Color.White;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor=Color.FromArgb(128, 255, 255);
            btnAdd.ForeColor=Color.Black;
        }
    }
}
