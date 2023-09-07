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
    public partial class CancelAppointment_Form : Form
    {
        public CancelAppointment_Form()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string cancelpatient = txtCancelAppointmentPatient.Text;
            bool exist = Appointment_CRUD.canceledappointment(ref cancelpatient);
            if (exist == true) { MessageBox.Show("The Appointment of this patient is Canceled"); }
            else { MessageBox.Show("This Patient has no Appointment"); }
            Appointment_CRUD.cleanFile();
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

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.Black;
            btnCancel.ForeColor = Color.White;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.FromArgb(128, 255, 255);
            btnCancel.ForeColor = Color.Black;
        }
    }
}
