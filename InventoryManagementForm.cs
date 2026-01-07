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
    public partial class InventoryManagementForm : Form
    {
        User currentUser;
        public InventoryManagementForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void InventoryManagementForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NavigationHelper.GoBackToDashboard(this, currentUser);
        }
    }
}
