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
    public partial class ViewMedicine_Form : Form
    {
        DataTable medicines = new DataTable();
        public ViewMedicine_Form()
        {
            InitializeComponent();
        }

        private void ViewMedicine_Form_Load(object sender, EventArgs e)
        {
            medicines.Columns.Add("Medicinename", Type.GetType("System.String"));
            medicines.Columns.Add("Quantity", Type.GetType("System.String"));
            medicines.Columns.Add("Expiry Date", Type.GetType("System.String"));
            medicines.Columns.Add("Price", Type.GetType("System.String"));

            for(int i = 0; i < Medicine_CRUD.meds.Count; i++)
            {
                Medicine med = Medicine_CRUD.meds[i];
                medicines.Rows.Add(med.getMedicinename(), med.getQuantity(), med.getExpirydate(), med.getPrice());
            }
            medicinesGV.DataSource = medicines;
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

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            DataView dvPatientTable = medicines.DefaultView;
            dvPatientTable.RowFilter = "Medicinename Like '%" + txtSearchBox.Text + "%'";
        }
        

        private void txtSearchBox_Enter_1(object sender, EventArgs e)
        {
            if (txtSearchBox.Text == "Medicine Name")
            {
                txtSearchBox.Text = "";
                txtSearchBox.ForeColor = Color.Black;

            }
        }

        private void txtSearchBox_Leave_1(object sender, EventArgs e)
        {
            if (txtSearchBox.Text == "")
            {
                txtSearchBox.Text = "Medicine Name";
                txtSearchBox.ForeColor = Color.DimGray;
            }
        }
    }
}
