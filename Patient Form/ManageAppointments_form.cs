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
    public partial class ManageAppointments_form : Form
    {
        private DataTable appointmentTable = new DataTable("AppointmentTable");

        public ManageAppointments_form()
        {
            InitializeComponent();
        }

        private void ManageAppointments_form_Load(object sender, EventArgs e)
        {
            TableColumnsHeading();
            ShowAppointments();
            table_fun();
        }
        public void TableColumnsHeading()
        {
            appointmentTable.Columns.Clear();
            appointmentTable.Rows.Clear();
            appointmentTable.Columns.Add("Patient name", Type.GetType("System.String"));
            appointmentTable.Columns.Add("Appointment Date", Type.GetType("System.String"));
            appointmentTable.Columns.Add("Appointment Doctor", Type.GetType("System.String"));
            appointmentTable.Columns.Add("Appointment Time", Type.GetType("System.String"));
        }
        public void ShowAppointments()
        {
            for (int i = 0; i < Appointment_CRUD.appointments.Count; i++)
            {
                Appointment appointment = Appointment_CRUD.appointments[i];
                appointmentTable.Rows.Add(appointment.getName(), appointment.getDateappoint(), appointment.getDoctor(), appointment.getTimeappoint());
            }

            
        }
        public void table_fun()
        {
            AppointmentsGV.DataSource = appointmentTable;
        }
        public static void t()
        {
            ManageAppointments_form appointments_Form = new ManageAppointments_form();
            appointments_Form.table_fun();
        } 
        private void btnShiftAppointment_Click(object sender, EventArgs e)
        {
            Form newform = new Patient_Form.ShiftAppointment_Form();
            newform.Tag = this;
            newform.Show();
            
        }

        private void btnCancelAppointment_Click(object sender, EventArgs e)
        {
            Form newform = new Patient_Form.CancelAppointment_Form();
            newform.Tag = this;
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

        private void btnShiftAppointment_MouseEnter(object sender, EventArgs e)
        {
            btnShiftAppointment.BackColor = Color.Black;
            btnShiftAppointment.ForeColor = Color.White;
        }

        private void btnShiftAppointment_MouseLeave(object sender, EventArgs e)
        {
            btnShiftAppointment.BackColor = Color.FromArgb(128, 255, 255);
            btnShiftAppointment.ForeColor = Color.Black;
        }

        private void btnCancelAppointment_MouseEnter(object sender, EventArgs e)
        {
            btnCancelAppointment.BackColor = Color.Black;
            btnCancelAppointment.ForeColor = Color.White;
        }

        private void btnCancelAppointment_MouseLeave(object sender, EventArgs e)
        {
            btnCancelAppointment.BackColor = Color.FromArgb(128, 255, 255);
            btnCancelAppointment.ForeColor = Color.Black;
        }
    }
}
