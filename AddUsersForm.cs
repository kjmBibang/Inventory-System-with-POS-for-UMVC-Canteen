using Inventory_System_with_POS_for_UMVC_Canteen.Data;
using Inventory_System_with_POS_for_UMVC_Canteen.Interfaces;
using Inventory_System_with_POS_for_UMVC_Canteen.Models;
using Inventory_System_with_POS_for_UMVC_Canteen.Helpers;
using Inventory_System_with_POS_for_UMVC_Canteen.Factories;
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
    public partial class AddUsersForm : Form
    {
        private IUserRepository userRepository;
        private UserManager userManager;
        private ISecurityHelper securityHelper;

        public AddUsersForm()
        {
            InitializeComponent();
            userRepository = RepositoryFactory.CreateUserRepository();
            userManager = new UserManager(userRepository);
            securityHelper = new BCryptHelper();
        }
        private void AddUsersForm_Load(object sender, EventArgs e)
        {
            // Populate role ComboBox
            cmbUserRole.Items.Clear();
            cmbUserRole.Items.Add(new RoleItem { RoleID = 1, RoleName = "Admin" });
            cmbUserRole.Items.Add(new RoleItem { RoleID = 2, RoleName = "Cashier" });
            cmbUserRole.DisplayMember = "RoleName";
            cmbUserRole.ValueMember = "RoleID";
            cmbUserRole.SelectedIndex = 1; // Default to Cashier
        }
        

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation
                if (string.IsNullOrWhiteSpace(txtUserUsername.Text))
                {
                    MessageBox.Show("Username is required.", "Validation Error");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtUserPassword.Text))
                {
                    MessageBox.Show("Password is required.", "Validation Error");
                    return;
                }

                if (txtUserPassword.Text.Length < 6)
                {
                    MessageBox.Show("Password must be at least 6 characters.", "Validation Error");
                    return;
                }

                if (cmbUserRole.SelectedItem == null)
                {
                    MessageBox.Show("Please select a role.", "Validation Error");
                    return;
                }

                RoleItem selectedRole = (RoleItem)cmbUserRole.SelectedItem;

                // Hash the password
                string hashedPassword = securityHelper.HashPassword(txtUserPassword.Text);

                // Add user to database
                userRepository.AddUser(txtUserUsername.Text.Trim(), hashedPassword, selectedRole.RoleID);

                MessageBox.Show("User added successfully.", "Success");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Adding User");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private class RoleItem
        {
            public int RoleID { get; set; }
            public string RoleName { get; set; }
        }

        private void txtUserUsername_TextChanged(object sender, EventArgs e){ }
        private void cmbUserRole_SelectedIndexChanged(object sender, EventArgs e){ }
    }
}
