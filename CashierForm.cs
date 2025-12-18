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
    public partial class CashierForm : Form
    {
        private Cashier cashier;
        LoginForm loginForm = new LoginForm();
        public CashierForm(Cashier cashier)
        {
            InitializeComponent();
            this.cashier = cashier;
            lblWelcome.Text = $"Welcome {cashier.username}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Hide();
        }

        private void CashierForm_Load(object sender, EventArgs e)
        {

        }
    }
}
