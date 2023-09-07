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

namespace HMS_App.Pharmacy_Form
{
    public partial class ViewExpiredMedicine_Form : Form
    {
        public ViewExpiredMedicine_Form()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string currentdate;
            int check = 0;
            bool expiredmedicine;
            string expiredMed="";
            DateTime date = dtDateExpired.Value;
            currentdate = Convert.ToDateTime(date).Date.ToString("d");
            foreach (Medicine i in Medicine_CRUD.meds)
            {
                expiredmedicine = ExpiredMedicine.isExpired(currentdate, i.getExpirydate());
                if (expiredmedicine == true)
                {
                    check = 1;
                    string expiredmedicines1 = i.getMedicinename();
                    ExpiredMedicine expiredmedicine1 = new ExpiredMedicine(expiredmedicines1);

                    ExpiredMedicine_CRUD.expiredmed.Add(expiredmedicine1);
                }
            }
            ExpiredMedicine_CRUD.addExpiredmedicine();
            if (check == 1)
            {
                foreach (ExpiredMedicine i in ExpiredMedicine_CRUD.expiredmed)
                {
                    expiredMed = expiredMed + i.getExpiredmedicine() + ",";
                }
                for (int j = 0; j < expiredMed.Length - 1; j++)
                {
                    lblexpiredmed.Text = lblexpiredmed.Text + expiredMed[j];
                }
            }
            else
            {
                MessageBox.Show("No medicine is expired");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newform = new Pharmacy_Menu_Form();
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
            btnCheck.BackColor = Color.FromArgb(128, 255, 128);
            btnCheck.ForeColor = Color.Black;
        }
    }
}
