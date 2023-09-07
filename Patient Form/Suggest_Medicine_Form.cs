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
    public partial class Suggest_Medicine_Form : Form
    {
        string[] symptoms = { " ", " ", " ", " ", " ", " " };
        char check1 = ' ', check2 = ' ', check3 = ' ';
        Patient P = PatientCRUD.patients[PatientCRUD.patients.Count - 1];
        int count = 0;
        public Suggest_Medicine_Form()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string Medicine = P.GiveMedicine(check1, check2, check3);
            MessageBox.Show("Suggested medicines for you is "+Medicine);
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

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.Black;
            btnAdd.ForeColor = Color.White;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.FromArgb(128, 255, 255);
            btnAdd.ForeColor = Color.Black;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (count < 6)
            {
                symptoms[count] = txtSymptom.Text;
                P.SymptomsCheck(symptoms, count, ref check1, ref check2, ref check3);
                count++;
                empty();
            }
            else
            {
                MessageBox.Show("You have entered all the symptoms");
            }
        }
        private void empty()
        {
            txtSymptom.Text = String.Empty;
        }
    }
}
