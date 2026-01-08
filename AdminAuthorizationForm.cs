using Inventory_System_with_POS_for_UMVC_Canteen.Data;
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
    public partial class AdminAuthorizationForm : Form
    {
        public Admin AuthorizedAdmin { get; private set; }

        private UserManager userManager;

        public AdminAuthorizationForm()
        {
            InitializeComponent();
            IUserRepository repo = new SQLUserRepository();
            userManager = new UserManager(repo);

        }

        private void txtAuthorizationKey_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnAuthorize_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAuthorize_Click_1(object sender, EventArgs e)
        {
            var admin = userManager.AuthorizeAdmin(
                txtUsername.Text.Trim(),
                txtPassword.Text.Trim()
            );

            if (admin == null)
            {
                MessageBox.Show("Invalid admin credentials.");
                return;
            }

            AuthorizedAdmin = admin;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
