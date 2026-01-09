using Inventory_System_with_POS_for_UMVC_Canteen.Factories;
using Inventory_System_with_POS_for_UMVC_Canteen.Helpers;
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
        UserManager userManager;
        public UserManagementForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.MultiSelect = false;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.ForeColor = Color.Black;

            userIDColumn.DataPropertyName = "userID";
            usernameColumn.DataPropertyName = "username";
            passwordColumn.DataPropertyName = "PasswordDisplay";
            roleColumn.DataPropertyName = "RoleName";
        
            userManager = new UserManager(RepositoryFactory.CreateUserRepository());

            LoadUsers();
        }
        private void LoadUsers()
        {
            var users = userManager.GetAllUsers()
                .Select(u => new
                {
                    u.userID,
                    u.username,
                    PasswordDisplay = "********", // ← correct way
                    RoleName = u.roleName
                })
                .ToList();

            dgvUsers.DataSource = users;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NavigationHelper.GoBackToDashboard(this, currentUser);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//dgvUsers ni
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            using (AddUserForm addUserForm = new AddUserForm())
            {
                addUserForm.ShowDialog();
            }
            LoadUsers();
        }
    }
}
