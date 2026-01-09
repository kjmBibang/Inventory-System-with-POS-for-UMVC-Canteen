using Inventory_System_with_POS_for_UMVC_Canteen.Data;
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
    public partial class UpdateUserForm : Form
    {
        private User _user;
        private UserManager _userManager;

        public UpdateUserForm(User user)
        {
            InitializeComponent();
            _user = user;
            _userManager = new UserManager(RepositoryFactory.CreateUserRepository());
            this.Load += UpdateUserForm_Load;
        }
        
        private void gpUpdateUserform_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            int roleId = (int)cmbRole.SelectedValue;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username cannot be empty.");
                return;
            }

            string newPassword = null;

            if (chkEditPassword.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text) ||
                    string.IsNullOrWhiteSpace(txtNewPassword.Text))
                {
                    MessageBox.Show("Both password fields are required.");
                    return;
                }

                // 🔐 verify via MANAGER
                bool valid = _userManager.VerifyCurrentPassword(
                    _user.userID,
                    txtCurrentPassword.Text
                );

                if (!valid)
                {
                    MessageBox.Show("Current password is incorrect.");
                    return;
                }

                newPassword = txtNewPassword.Text;
            }

            try
            {
                _userManager.UpdateUser(
                    userID: _user.userID,
                    username: username,
                    roleID: roleId,
                    newPlainPassword: newPassword
                );

                MessageBox.Show("User updated successfully.");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Failed");
            }
        }

        private void chbEditPassword_CheckedChanged(object sender, EventArgs e)
        {
            TogglePasswordFields(chkEditPassword.Checked);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            txtUserID.Text = _user.userID;
            txtUsername.Text = _user.username;

            txtUserID.ReadOnly = true;

            cmbRole.DataSource = new[]
            {
        new { Text = "Admin", Value = 1 },
        new { Text = "Cashier", Value = 2 }
    };
            cmbRole.DisplayMember = "Text";
            cmbRole.ValueMember = "Value";
            cmbRole.SelectedValue = _user.roleID;

            chkEditPassword.Checked = false;
            TogglePasswordFields(false);
        }
        private void chkEditPassword_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void TogglePasswordFields(bool enabled)
        {
            txtCurrentPassword.Enabled = enabled;
            txtNewPassword.Enabled = enabled;

            if (!enabled)
            {
                txtCurrentPassword.Clear();
                txtNewPassword.Clear();
            }
        }

    }
}
