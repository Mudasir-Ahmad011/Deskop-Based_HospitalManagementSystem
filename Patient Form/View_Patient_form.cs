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
    public partial class View_Patient_form : Form
    {
        private string path = "path\\Patient.txt";
        DataTable table = new DataTable("PatientTable");
        public View_Patient_form()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void View_Patient_form_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Patientname", Type.GetType("System.String"));
            table.Columns.Add("Age", Type.GetType("System.String"));
            table.Columns.Add("Phone no", Type.GetType("System.String"));
            table.Columns.Add("Cnic", Type.GetType("System.String"));
            table.Columns.Add("Address", Type.GetType("System.String"));
            
            for (int i = 0; i < PatientCRUD.patients.Count; i++)
            {
                Patient p = PatientCRUD.patients[i];
                table.Rows.Add(p.getName(),p.getAge(),p.getContactno(),p.getCnic(),p.getAddress());
            }
            PatientGV.DataSource = table;
        }

        private void HometoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form newform = new Admin_menu_Form();
            newform.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            DataView dvPatientTable = table.DefaultView;
            dvPatientTable.RowFilter = "Patientname Like '%" + txtSearchBox.Text + "%'";
        }

        private void txtSearchBox_Enter(object sender, EventArgs e)
        {
            txtCnicSearch.Text = "Search By Cnic";
            txtCnicSearch.ForeColor = Color.DimGray;
            if (txtSearchBox.Text=="Search By Name")
            {
                txtSearchBox.Text = "";
                txtSearchBox.ForeColor =Color.Black;
                
            }
        }

        private void txtSearchBox_Leave(object sender, EventArgs e)
        {
            if (txtSearchBox.Text == "")
            {
                txtSearchBox.Text = "Search By Name";
                txtSearchBox.ForeColor = Color.DimGray;
            }
        }

        private void txtCnicSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dvPatientTable1 = table.DefaultView;
            dvPatientTable1.RowFilter = "Cnic Like '%" + txtCnicSearch.Text + "%'";
        }

        private void txtCnicSearch_Enter(object sender, EventArgs e)
        {
            txtSearchBox.Text = "Search By Name";
            txtSearchBox.ForeColor = Color.DimGray;
            if (txtCnicSearch.Text == "Search By Cnic")
            {
                txtCnicSearch.Text = "";
                txtCnicSearch.ForeColor = Color.Black;

            }
        }

        private void txtCnicSearch_Leave(object sender, EventArgs e)
        {
            if (txtCnicSearch.Text == "")
            {
                txtCnicSearch.Text = "Search By Cnic";
                txtCnicSearch.ForeColor = Color.DimGray;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

