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
    public partial class BookAppointmentForm : Form
    {
        Appointment appointment;
        bool check = false;
        int timeSt = 0;
        int timeEnd = 0;
        public BookAppointmentForm()
        {
            InitializeComponent();
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            DateTime dateAppoint = dtDate.Value;
            string date = Convert.ToDateTime(dateAppoint).Date.ToString("d");
            string doctorname = txtdoctorName.Text;
            string name = txtname.Text;
            appointment = new Appointment(name,date,doctorname);

            for (int i = 0; i < Doctor_CRUD.doctors.Count; i++)
            {
                if (appointment.getDateappoint() == Doctor_CRUD.doctors[i].getScheduledate() && appointment.getDoctor() == Doctor_CRUD.doctors[i].getDoctorname())
                {
                    lblavailableTime.Text = "This doctor is available from: " + Doctor_CRUD.doctors[i].getStartingtime() + " to " + Doctor_CRUD.doctors[i].getEndingtime();
                    string startingtime_final = Doctor_CRUD.doctors[i].getStartingtime();
                    string endingtime_final = Doctor_CRUD.doctors[i].getEndingtime();
                    timeSt = appointment.Converttime(startingtime_final);
                    timeEnd = appointment.Converttime(endingtime_final);
                    check = true;
                    break;
                }
                else
                {
                    check = false;
                }
            }
            bookAppointment_DoctorAvailable(check);
        }
        private void bookAppointment_DoctorAvailable(bool check)
        {
            if (check == false)
            {
                MessageBox.Show("This doctor is not available");
                empty();
            }
        }
        private void empty()
        {
            txtdoctorName.Text = null;
            txtname.Text = null;
            dtDate.Value = DateTime.Now;
        }
        private void Fullclean()
        {
            empty();
            lblavailableTime.Text = null;
            txttimetakeAppointment.Text = null;
        }
        private void btnbookappointment_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                string takeAppointment = txttimetakeAppointment.Text;
                appointment.setTimeappoint(takeAppointment);
                int time = appointment.Converttime(appointment.getTimeappoint());

                if (time >= timeSt && time <= timeEnd)
                {
                    MessageBox.Show("Appointment set");
                    Appointment_CRUD.add_appointmentinFile(appointment);
                    Appointment_CRUD.Add_Appointment(appointment);
                    Doctor_CRUD.put_DoctorAppointment_inList(Appointment_CRUD.appointments);
                }
                else
                {
                    MessageBox.Show("This doctor is not available");
                }
            }
            else { MessageBox.Show("We can't book this Appointment"); }
            this.Close();
        }

        private void btncheck_MouseEnter(object sender, EventArgs e)
        {
            btncheck.BackColor = Color.Black;
            btncheck.ForeColor = Color.White;
        }

        private void btncheck_MouseLeave(object sender, EventArgs e)
        {
            btncheck.BackColor = Color.FromArgb(128, 255, 128);
            btncheck.ForeColor = Color.Black;
        }

        private void btnbookappointment_MouseEnter(object sender, EventArgs e)
        {
            btnbookappointment.BackColor = Color.Black;
            btnbookappointment.ForeColor = Color.White;
        }

        private void btnbookappointment_MouseLeave(object sender, EventArgs e)
        {
            btnbookappointment.BackColor = Color.FromArgb(128, 255, 128);
            btnbookappointment.ForeColor = Color.Black;
        }
    }
}
