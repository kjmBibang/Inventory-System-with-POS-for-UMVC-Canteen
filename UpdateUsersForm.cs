using Inventory_System_with_POS_for_UMVC_Canteen.Data;
using Inventory_System_with_POS_for_UMVC_Canteen.Factories;
using Inventory_System_with_POS_for_UMVC_Canteen.Helpers;
using Inventory_System_with_POS_for_UMVC_Canteen.Interfaces;
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
    public partial class UpdateUsersForm : Form
    {
        private IUserRepository userRepository;
        private UserManager userManager;
        private ISecurityHelper securityHelper;
        private Interfaces.UserInfo _userInfo;

        // Single constructor using the UserInfo from Interfaces namespace
        public UpdateUsersForm(Interfaces.UserInfo userInfo)
        {
            InitializeComponent();
            _userInfo = userInfo;
            userRepository = RepositoryFactory.CreateUserRepository();
            userManager = new UserManager(userRepository);
            securityHelper = new BCryptHelper();
        }

        private void UpdateUsersForm_Load(object sender, EventArgs e)
        {
            // Populate role ComboBox
            cmbUpdateRole.Items.Clear();
            cmbUpdateRole.Items.Add(new RoleItem { RoleID = 1, RoleName = "Admin" });
            cmbUpdateRole.Items.Add(new RoleItem { RoleID = 2, RoleName = "Cashier" });
            cmbUpdateRole.DisplayMember = "RoleName";
            cmbUpdateRole.ValueMember = "RoleID";

            // Load existing user data
            txtUpdateUsername.Text = _userInfo.Username;

            // Select the appropriate role
            for (int i = 0; i < cmbUpdateRole.Items.Count; i++)
            {
                RoleItem item = (RoleItem)cmbUpdateRole.Items[i];
                if (item.RoleID == _userInfo.RoleID)
                {
                    cmbUpdateRole.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation
                if (string.IsNullOrWhiteSpace(txtUpdateUsername.Text))
                {
                    MessageBox.Show("Username is required.", "Validation Error");
                    return;
                }

                if (cmbUpdateRole.SelectedItem == null)
                {
                    MessageBox.Show("Please select a role.", "Validation Error");
                    return;
                }

                // Check if password is being changed
                bool changePassword = !string.IsNullOrWhiteSpace(txtUpdatePassword.Text);

                if (changePassword)
                {
                    if (txtUpdatePassword.Text.Length < 6)
                    {
                        MessageBox.Show("Password must be at least 6 characters.", "Validation Error");
                        return;
                    }

                    // Validate password confirmation
                    if (txtUpdatePassword.Text != txtConfirmPassword.Text)
                    {
                        MessageBox.Show("Passwords do not match.", "Validation Error");
                        return;
                    }
                }

                RoleItem selectedRole = (RoleItem)cmbUpdateRole.SelectedItem;

                if (changePassword)
                {
                    // Hash the new password
                    string hashedPassword = securityHelper.HashPassword(txtUpdatePassword.Text);
                    userRepository.UpdateUser(_userInfo.UserID, txtUpdateUsername.Text.Trim(), hashedPassword, selectedRole.RoleID);
                }
                else
                {
                    // Update without changing password
                    userRepository.UpdateUserWithoutPassword(_userInfo.UserID, txtUpdateUsername.Text.Trim(), selectedRole.RoleID);
                }

                MessageBox.Show("User updated successfully.", "Success");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Updating User");
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
    }
}