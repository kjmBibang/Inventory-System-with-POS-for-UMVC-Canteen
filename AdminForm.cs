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
    public partial class AdminForm : Form
    {
        private Admin admin;
        LoginForm loginForm = new LoginForm();
        UserManagementForm userManagementForm;
        POSform posForm;
        InventoryManagementForm inventoryManagementForm;
        public AdminForm(Admin admin)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.admin = admin;
            lblWelcome.Text = $"Welcome {admin.username}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Hide();

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPOSModule_Click(object sender, EventArgs e)
        {
            posForm = new POSform(admin);
            posForm.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            inventoryManagementForm = new InventoryManagementForm(admin);
            inventoryManagementForm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Hide();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            userManagementForm = new UserManagementForm(admin);
            userManagementForm.Show();
            this.Hide();
        }
    }




}
