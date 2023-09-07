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
    public partial class CheckBill_Form : Form
    {
        public CheckBill_Form()
        {
            InitializeComponent();
        }

        private void CheckBill_Form_Load(object sender, EventArgs e)
        {
            double totalpricemedicine = 0F;
            for (int i = 0; i < PatientCRUD.patients.Count; i++)
            {
                if (DetailForm.Patientname == PatientCRUD.patients[i].getName())
                {
                    ShowRoomCharges(i);
                    for (int j = 0; j < Customer_CRUD.customers.Count; j++)
                    {
                        if (PatientCRUD.patients[i].getName() == Customer_CRUD.customers[j].getcustomerName())
                        {
                            totalpricemedicine = Customer_CRUD.customers[j].Calculate_Bill();
                            break;
                        }
                    }
                    Showbills(totalpricemedicine, i);
                    break;
                }
            }
        }
        private void ShowRoomCharges(int i)
        {
             lblroomcharge.Text=""+PatientCRUD.patients[i].bill.getBedcharge() * PatientCRUD.patients[i].bill.getDaysPatientstayed();
        }
        private void Showbills(double totalpricemedicine, int i)
        {
            lblmedicinebill.Text=""+totalpricemedicine;
            lblLabtestbill.Text =""+PatientCRUD.patients[i].bill.getLabtest();
            lbltotalbill.Text=""+PatientCRUD.patients[i].bill.getTotalbill();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
