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
        POSform posForm;
        public CashierForm(Cashier cashier)
        {
            InitializeComponent();
            this.cashier = cashier;
            lblWelcome.Text = $"Welcome {cashier.username}";
        }

      /* private void button1_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Hide();
        }*/

        private void CashierForm_Load(object sender, EventArgs e)
        {

        }

    /*    private void btnPOSModule_Click(object sender, EventArgs e)
        {
            posForm = new POSform(cashier);
            posForm.Show();
            this.Hide();
        }*/

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Hide();
        }

        private void btnPOSModule_Click_1(object sender, EventArgs e)
        {
            posForm = new POSform(cashier);
            posForm.Show();
            this.Hide();
        }
    }
}
