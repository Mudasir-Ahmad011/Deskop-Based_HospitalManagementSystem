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
    public partial class UsersViewForm : Form
    {
        private string path = "data.txt";
        public UsersViewForm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MUser user = (MUser)usersGV.CurrentRow.DataBoundItem;
            if (usersGV.Columns["Delete"].Index == e.ColumnIndex)
            {
                MUser_CRUD.deleteUserFromList(user);
                MUser_CRUD.storeAllUsersIntoFile(path);
                dataBind();
            }
            else if (usersGV.Columns["Edit"].Index == e.ColumnIndex)
            {
                EditUserForm myform = new EditUserForm(user);
                myform.ShowDialog();
                MUser_CRUD.storeAllUsersIntoFile(path);
                dataBind();
            }
        }

        private void UsersViewForm_Load(object sender, EventArgs e)
        {
            MUser_CRUD.loadFromFile("data.txt");
            usersGV.DataSource = MUser_CRUD.UsersList;
        }
        public void dataBind()
        {
            usersGV.DataSource = null;
            usersGV.DataSource = MUser_CRUD.UsersList;
            usersGV.Refresh();
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            AddUserForm myform = new AddUserForm();
            myform.ShowDialog();
            MUser_CRUD.storeAllUsersIntoFile(path);
            dataBind();
        }

    }
}
