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
    public partial class Pharmacy_Menu_Form : Form
    {
        public Pharmacy_Menu_Form()
        {
            InitializeComponent();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            Form newform = new AddMedicine_Form();
            newform.Show();
            this.Hide();
        }

        private void btnViewMedicine_Click(object sender, EventArgs e)
        {
            Form newform = new ViewMedicine_Form();
            newform.Show();
            this.Hide();
        }

        private void btnUpdateMedicine_Click(object sender, EventArgs e)
        {
            Form newform = new UpdateMedicine_Form();
            newform.Show();
            this.Hide();
        }

        private void btnPurchaseMedicine_Click(object sender, EventArgs e)
        {
            Form newform = new PurchaseMedicine_Form();
            newform.Show();
            this.Hide();
        }

        private void btnViewExpiredMed_Click(object sender, EventArgs e)
        {
            Form newform = new ViewExpiredMedicine_Form();
            newform.Show();
            this.Hide();
        }

        private void btnViewMedDemand_Click(object sender, EventArgs e)
        {
            Form newform = new ViewDemandMedicine_Form();
            newform.Show();
            this.Hide();
        }

        private void btnDeleteMed_Click(object sender, EventArgs e)
        {
            Form newform = new DeleteMedicine_Form();
            newform.Show();
            this.Hide();
        }

        private void Pharmacy_Menu_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form newform = new HMSApplication();
            newform.Show();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
