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
    public partial class UserManagementForm : Form
    {
        User currentUser;
        IUserRepository userRepository;
        UserManager userManager;

        public UserManagementForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            userRepository = RepositoryFactory.CreateUserRepository();
            userManager = new UserManager(userRepository);
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            // Wire up button click events to ensure they work
            // Remove existing handlers first to prevent duplicates
            btnAddUser.Click -= btnAddUser_Click;
            btnAddUser.Click += btnAddUser_Click;

            btnUpdateUser.Click -= btnUpdateUser_Click;
            btnUpdateUser.Click += btnUpdateUser_Click;

            btnDeleteUser.Click -= btnDeleteUser_Click;
            btnDeleteUser.Click += btnDeleteUser_Click;

            btnBack.Click -= btnBack_Click;
            btnBack.Click += btnBack_Click;
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Configure DataGridView
                dgvUsers.AutoGenerateColumns = false;
                userIDColumn.DataPropertyName = "UserID";
                usernameColumn.DataPropertyName = "Username";
                roleColumn.DataPropertyName = "RoleName";

                // Hide password column since we don't want to display hashed passwords
                if (passwordColumn != null)
                {
                    passwordColumn.Visible = false;
                }

                dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvUsers.MultiSelect = false;

                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUsers()
        {
            try
            {
                var users = userManager.LoadUsers();

                if (users == null || users.Count == 0)
                {
                    dgvUsers.DataSource = null;
                    MessageBox.Show("No users found.", "Information");
                    return;
                }

                dgvUsers.DataSource = null;
                dgvUsers.DataSource = users;
                dgvUsers.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}\n\nStack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                using (AddUsersForm addUsersForm = new AddUsersForm())
                {
                    if (addUsersForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadUsers();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Add User form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsers.CurrentRow == null || dgvUsers.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a user to update.", "No Selection");
                    return;
                }

                Interfaces.UserInfo selectedUser = LoadUserFromSelectedRow();

                if (selectedUser == null)
                {
                    MessageBox.Show("Error loading selected user data.", "Error");
                    return;
                }

                using (UpdateUsersForm updateUsersForm = new UpdateUsersForm(selectedUser))
                {
                    if (updateUsersForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadUsers();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Update User form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsers.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a user to delete.", "No Selection");
                    return;
                }

                DataGridViewRow row = dgvUsers.SelectedRows[0];

                // Get userID safely
                int userID;
                var userIdValue = row.Cells["userIDColumn"].Value;

                if (userIdValue == null || !int.TryParse(userIdValue.ToString(), out userID))
                {
                    MessageBox.Show("Invalid user ID.", "Error");
                    return;
                }

                string username = row.Cells["usernameColumn"].Value?.ToString() ?? "Unknown";

                // Prevent deleting yourself
                if (userID.ToString() == currentUser.userID)
                {
                    MessageBox.Show("You cannot delete your own account.", "Action Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult confirm = MessageBox.Show(
                    $"Are you sure you want to delete user '{username}'?\n\nThis action cannot be undone.",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm != DialogResult.Yes)
                    return;

                userManager.DeleteUser(userID);
                MessageBox.Show("User deleted successfully.", "Success");
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting user: {ex.Message}", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Interfaces.UserInfo LoadUserFromSelectedRow()
        {
            try
            {
                DataGridViewRow row = dgvUsers.CurrentRow;

                if (row == null)
                    return null;

                // Get the bound data item directly
                var userInfo = row.DataBoundItem as Interfaces.UserInfo;

                if (userInfo != null)
                {
                    return userInfo;
                }

                // Fallback to cell values if DataBoundItem is not available
                return new Interfaces.UserInfo
                {
                    UserID = Convert.ToInt32(row.Cells["userIDColumn"].Value),
                    Username = row.Cells["usernameColumn"].Value?.ToString() ?? "",
                    RoleID = GetRoleIDFromRoleName(row.Cells["roleColumn"].Value?.ToString() ?? "Cashier"),
                    RoleName = row.Cells["roleColumn"].Value?.ToString() ?? "Cashier"
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private int GetRoleIDFromRoleName(string roleName)
        {
            return roleName.ToLower() == "admin" ? 1 : 2;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                NavigationHelper.GoBackToDashboard(this, currentUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error navigating back: {ex.Message}", "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Keep for compatibility
        }

        // Cleanup when form is closing to prevent event handler issues
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Remove event handlers to prevent memory leaks and duplicate handlers
            if (btnAddUser != null)
                btnAddUser.Click -= btnAddUser_Click;

            if (btnUpdateUser != null)
                btnUpdateUser.Click -= btnUpdateUser_Click;

            if (btnDeleteUser != null)
                btnDeleteUser.Click -= btnDeleteUser_Click;

            if (btnBack != null)
                btnBack.Click -= btnBack_Click;
        }
    }
}