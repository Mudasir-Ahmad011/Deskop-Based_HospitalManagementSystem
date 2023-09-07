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

namespace HMS_App.MUserGridViewForm
{
    public partial class EditUserForm : Form
    {
        private MUser previous;
        public EditUserForm(MUser previous)
        {
            InitializeComponent();
            this.previous = previous;
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            txtusername.Text = previous.UserName;
            txtpassword.Text = previous.UserPassword;
            txtrole.Text = previous.UserRole;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MUser updated = new MUser(txtusername.Text, txtpassword.Text, txtrole.Text);
            MUser_CRUD.editUserFromList(previous, updated);
            this.Close();
        }
    }
}
