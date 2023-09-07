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
    public partial class ViewDemandMedicine_Form : Form
    {
        public ViewDemandMedicine_Form()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewDemandMedicine_Form_Load(object sender, EventArgs e)
        {
            int check;
            string demandmed = "";
            foreach (Medicine j in Medicine_CRUD.meds)
            {
                check = j.getQuantity();
                if (check <= j.getDemandcheck() / 2)
                {
                    demandmed = demandmed + j.getMedicinename()+",";
                }

            }
            for(int j = 0; j < demandmed.Length - 1; j++)
            {
                lblDemandmed.Text = lblDemandmed.Text + demandmed[j];
            }
            
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
    }
}
