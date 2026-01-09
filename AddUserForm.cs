using Inventory_System_with_POS_for_UMVC_Canteen.Factories;
using Inventory_System_with_POS_for_UMVC_Canteen.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System_with_POS_for_UMVC_Canteen
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            cmbRoles.DataSource = new[]
    {
        new { Text = "Admin", Value = 1 },
        new { Text = "Cashier", Value = 2 }
    };

            cmbRoles.DisplayMember = "Text";
            cmbRoles.ValueMember = "Value";
            
            cmbRoles.SelectedIndex = 0; // 🔑 IMPORTANT
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gpAddUserForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//txtUserID ni
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string userId = txtUserID.Text.Trim();
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text;
                int roleId = (int)cmbRoles.SelectedValue;

                if (string.IsNullOrEmpty(userId) ||
                    string.IsNullOrEmpty(username) ||
                    string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("All fields are required.");
                    return;
                }

                UserManager manager = new UserManager(
                    RepositoryFactory.CreateUserRepository()
                );

                manager.AddUser(userId, username, password, roleId);

                MessageBox.Show("User added successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
