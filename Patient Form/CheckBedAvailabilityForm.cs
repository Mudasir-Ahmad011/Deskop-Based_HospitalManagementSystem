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
    public partial class CheckBedAvailabilityForm : Form
    {
        public CheckBedAvailabilityForm()
        {
            InitializeComponent();
        }

        private void CheckBedAvailabilityForm_Load(object sender, EventArgs e)
        {
            bool check = true;
            for (int i = 0; i < PatientCRUD.patients.Count; i++)
            {
                if (check == true)
                {
                    for (int j = 0; j < PatientCRUD.bedAvaiables.Count; j++)
                    {
                        if (DetailForm.patientCnic == PatientCRUD.patients[i].getCnic())
                        {
                            Check_BED_status(j);
                            break;
                            check = false;
                        }
                    }
                }
            }
        }
    
    private void Check_BED_status(int i)
    {
        lblbedAvailability.Text ="" + PatientCRUD.bedAvaiables[i];
    }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
