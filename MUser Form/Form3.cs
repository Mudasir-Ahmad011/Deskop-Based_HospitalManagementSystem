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
using HMS_App.Patient_Form;
using HMS_App.Pharmacy_Form;

namespace HMS_App
{
    public partial class SignIn_Form : Form
    {
        public SignIn_Form()
        {
            InitializeComponent();
        }
        private void ClearDataFromForm()
        {
            txtusername.Text = "";
            txtpassword.Text = "";
        }
        private void SignIn_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void SignInbtn_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            MUser user = new MUser(username, password);
            MUser validUser = MUser_CRUD.SignIn(user);
            if (validUser != null)
            {
                if (validUser.UserRole == "Admin" || validUser.UserRole == "admin")
                {
                    Form newform = new Admin_menu_Form();
                    newform.Show();
                    
                }else if (validUser.UserRole == "patient" || validUser.UserRole == "Patient")
                {
                    Form newform = new Patient_menu_form();
                    newform.Show();
                }else if(validUser.UserRole == "Pharmacist" || validUser.UserRole == "pharmacist") {
                    Form newform = new Pharmacy_Menu_Form();
                    newform.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("User is Invalid");
            }
            ClearDataFromForm();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form newform = new HMSApplication();
            newform.Show();
            this.Hide();
        }

        private void chkboxShowPasscode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxShowPasscode.Checked)
            {
                txtpassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = false;
            }
        }

        private void Back_MouseEnter(object sender, EventArgs e)
        {
            Back.BackColor = Color.Black;
            Back.ForeColor = Color.White;
        }

        private void Back_MouseLeave(object sender, EventArgs e)
        {
            Back.BackColor = Color.FromArgb(128, 255, 255);
            Back.ForeColor = Color.Black;
        }

        private void SignInbtn_MouseEnter(object sender, EventArgs e)
        {
            SignInbtn.BackColor = Color.Black;
            SignInbtn.ForeColor = Color.White;
        }

        private void SignInbtn_MouseLeave(object sender, EventArgs e)
        {
            SignInbtn.BackColor = Color.FromArgb(128, 255, 255);
            SignInbtn.ForeColor = Color.Black;
        }
    }
}
