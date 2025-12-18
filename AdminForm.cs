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
        public AdminForm(Admin admin)
        {
            InitializeComponent();
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
    }
}
