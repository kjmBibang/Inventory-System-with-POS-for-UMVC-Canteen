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
        public UserManagementForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NavigationHelper.GoBack(this, currentUser);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//dgvUsers ni
        {

        }
    }
}
