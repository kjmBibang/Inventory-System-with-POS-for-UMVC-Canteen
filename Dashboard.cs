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
    public partial class Dashboard : Form
    {
        UserManagementForm userManagementForm;
        InventoryManagementForm inventoryManagementForm;
        POSform posForm;
        LoginForm loginForm;
        User user;
        public Dashboard(User user)
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.user = user;
        }

        private void button1_Click(object sender, EventArgs e)//btnUsers
        {
            NavigationHelper.NavigateToUserManagement(this, user);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateToInventory(this, user);
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            posForm = new POSform(user);
            posForm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
