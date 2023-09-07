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

namespace HMS_App
{
    public partial class SignUp_Form : Form
    {
        public SignUp_Form()
        {
            InitializeComponent();
        }
        private void ClearDataFromForm()
        {
            txtusername.Text = "";
            txtpassword.Text = "";
            txtrole.Text = "";
        }
        private void SignUp_Form_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            string role = txtrole.Text;
            string path = "data.txt";
            MUser user = new MUser(username, password, role);
            MUser_CRUD.addUserIntoList(user);
            MUser_CRUD.storeIntoFile(path, user);
            MessageBox.Show("User Added Successfully");
            ClearDataFromForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form newform = new HMSApplication();
            newform.Show();
            this.Hide();
        }

        private void chkboxshowpasscode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxshowpasscode.Checked)
            {
                txtpassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = false;
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Black;
            button2.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(128, 255, 255);
            button2.ForeColor = Color.Black;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(128, 255, 255);
            button1.ForeColor = Color.Black;
        }
    }
}
