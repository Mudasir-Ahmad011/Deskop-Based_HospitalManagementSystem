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
    public partial class CheckDoctorSchedule_Form : Form
    {
        DataTable doctors = new DataTable();
        public CheckDoctorSchedule_Form()
        {
            InitializeComponent();
        }

        private void CheckDoctorSchedule_Form_Load(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            doctors.Columns.Clear();
            doctors.Rows.Clear();
            DateTime date = dtdate.Value;
            string dateavailability = Convert.ToDateTime(date).Date.ToString("d");
            doctors.Columns.Add("Doctor Name", Type.GetType("System.String"));
            doctors.Columns.Add("Doctor Specialty", Type.GetType("System.String"));
            doctors.Columns.Add("Starting Time", Type.GetType("System.String"));
            doctors.Columns.Add("Ending Time", Type.GetType("System.String"));
            foreach (var doctor in Doctor_CRUD.doctors)
            {
                if (dateavailability == doctor.getScheduledate())
                {
                    doctors.Rows.Add(doctor.getDoctorname(), doctor.getProfession(), doctor.getStartingtime(), doctor.getEndingtime());
                }
            }
            doctorGV.DataSource = doctors;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheck_MouseEnter(object sender, EventArgs e)
        {
            btnCheck.BackColor = Color.Black;
            btnCheck.ForeColor = Color.White;
        }

        private void btnCheck_MouseLeave(object sender, EventArgs e)
        {
            btnCheck.BackColor = Color.FromArgb(128, 255, 128);
            btnCheck.ForeColor = Color.Black;
        }
    }
}
