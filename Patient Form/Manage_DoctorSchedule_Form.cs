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
    public partial class Manage_DoctorSchedule_Form : Form
    {
        public Manage_DoctorSchedule_Form()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime date = dtDoctordate.Value;
            string Doctordate= Convert.ToDateTime(date).Date.ToString("d");
            string DoctorName = txtDoctorname.Text;
            string profession = txtDoctorSpecialty.Text;
            string startingTime = txtStartingTime.Text;
            string endingTime = txtEndingTime.Text;
            Doctor d = new Doctor();
            d.setScheduledate(Doctordate);
            d.setDoctorname(DoctorName);
            d.setProfession(profession);
            d.setStartingtime(startingTime);
            d.setEndingtime(endingTime);
            Doctor_CRUD.Add_Doctor(d);
            Doctor_CRUD.add_DoctorSchedule(d);
            ShowDialogbox();
        }
        private void ShowDialogbox()
        {
            DialogResult res = MessageBox.Show("Do you want to add another Doctor Schedule", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                empty();
            }
            else
            {
                this.Close();
            }
        }
        private void empty()
        {
            txtDoctorname.Text = String.Empty;
            txtDoctorSpecialty.Text = String.Empty;
            txtEndingTime.Text = String.Empty;
            txtStartingTime.Text = String.Empty;
            dtDoctordate.Value = DateTime.Now;
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
    }
}
