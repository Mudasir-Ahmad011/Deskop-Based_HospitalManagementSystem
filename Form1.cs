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
    public partial class HMSApplication : Form
    {
        public HMSApplication()
        {
            InitializeComponent();
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form newform = new SignUp_Form();
            newform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form newForm = new SignIn_Form();
            newForm.Show();
            this.Hide();
        }

        private void HMSApplication_Load(object sender, EventArgs e)
        {

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
    }
}
