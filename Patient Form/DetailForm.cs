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
    public partial class DetailForm : Form
    {
       public static string Patientname;
       public static string patientCnic;
        public DetailForm()
        {
            InitializeComponent();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            Patientname = txtpatient.Text;
            patientCnic = txtcnicno.Text;
            bool checkPatient = false;
            for (int i = 0; i < PatientCRUD.patients.Count; i++)
            {
                if (patientCnic == PatientCRUD.patients[i].getCnic())
                {
                    checkPatient = true;
                    break;
                }
                else { checkPatient = false; }
            }
            if(checkPatient == true) { this.Close(); Form newform = new Patient_menu_form();  newform.Show();}
            if(checkPatient == false) { MessageBox.Show("This patient is not store in our database"); empty(); }
        }
        private void empty()
        {
            txtcnicno.Text = null;
            txtpatient.Text = null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form newform = new Patient_Form.Patient_menu_form();
            newform.Show();
            this.Hide();
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newform = new Patient_menu_form();
            newform.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnnext_MouseEnter(object sender, EventArgs e)
        {
            btnnext.BackColor = Color.Black;
            btnnext.ForeColor = Color.White;
        }

        private void btnnext_MouseLeave(object sender, EventArgs e)
        {
            btnnext.BackColor = Color.FromArgb(128, 255, 128);
            btnnext.ForeColor = Color.Black;
        }
    }
}
