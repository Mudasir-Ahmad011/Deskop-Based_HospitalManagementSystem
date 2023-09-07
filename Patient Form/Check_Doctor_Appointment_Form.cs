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
    public partial class Check_Doctor_Appointment_Form : Form
    {
        DataTable Doctors = new DataTable("DoctorTable");
        public Check_Doctor_Appointment_Form()
        {
            
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            
            DateTime date = dtDate.Value;
            string Date = Convert.ToDateTime(date).Date.ToString("d");
            string Doctorname = txtDoctorname.Text;
            TablecolumnsHeading();
            foreach (var doctor in Doctor_CRUD.doctors)
            {
                if (Doctorname == doctor.getDoctorname() && Date == doctor.getScheduledate())
                {
                    
                    for (int i = 0; i < doctor.myAppointments.Count; i++)
                    {
                        Appointment a = doctor.myAppointments[i];
                        Doctors.Rows.Add(a.getName(), a.getTimeappoint());
                    }
                    break;
                }
            }
            DoctorsGV.DataSource = Doctors;
        }
        private void TablecolumnsHeading()
        {
            Doctors.Columns.Add("Patient name", Type.GetType("System.String"));
            Doctors.Columns.Add("Appointment Time", Type.GetType("System.String"));
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
    }
}
