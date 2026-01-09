using Inventory_System_with_POS_for_UMVC_Canteen.Data;
using Inventory_System_with_POS_for_UMVC_Canteen.Factories;
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
    
    public partial class LoginForm : Form
    {
        IUserRepository userRepository= RepositoryFactory.CreateUserRepository();
        UserManager userManager;
        public LoginForm()

        {

            InitializeComponent();
            userManager = new UserManager(userRepository);
        }

        private void picboxPASS_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            User user = userManager.Login(txtUsername.Text, txtPassword.Text);
            if (user != null)
            {
                if (user is Admin admin)
                {
                    Dashboard dashboard = new Dashboard(admin);
                    dashboard.Show();
                    
                    this.Hide();
                }
                else if (user is Cashier cashier)
                {
                    Dashboard dashboard = new Dashboard(cashier);
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Unkown role");
                    
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }

        }

        private void txtWelcome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
