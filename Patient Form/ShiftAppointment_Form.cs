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
    public partial class ShiftAppointment_Form : Form
    {
        public ShiftAppointment_Form()
        {
            InitializeComponent();
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            string ShiftedPatientname = txtname.Text;
            DateTime date = dtDateAppointment.Value;
            string shiftdate = Convert.ToDateTime(date).Date.ToString("d");
            string shiftTime = txttime.Text;
            bool exist = Appointment_CRUD.shiftedappointment(ref ShiftedPatientname, ref shiftdate, ref shiftTime);
            if (exist == true) { MessageBox.Show("Selected Appointment is Shifted Successfully"); }
            else { MessageBox.Show("This Patient has no appointment write correct patient"); }
            Appointment_CRUD.DATAaftershiftedORcancelappointment();
            ManageAppointments_form nform = this.Tag as ManageAppointments_form;
            nform.TableColumnsHeading();
            nform.ShowAppointments();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnShift_MouseEnter(object sender, EventArgs e)
        {
            btnShift.BackColor = Color.Black;
            btnShift.ForeColor = Color.White;
        }

        private void btnShift_MouseLeave(object sender, EventArgs e)
        {
            btnShift.BackColor = Color.FromArgb(128, 255, 255);
            btnShift.ForeColor = Color.Black;
        }
    }
}
