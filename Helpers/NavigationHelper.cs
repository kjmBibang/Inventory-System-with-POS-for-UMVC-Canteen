using Inventory_System_with_POS_for_UMVC_Canteen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Helpers
{
    public static class NavigationHelper
    {
        public static void GoBack(Form currentForm, User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            currentForm.Hide();

            Form nextForm;

            switch (user.roleID)
            {
                case 1: // admin
                    var admin = new Admin(user.userID, user.username, user.roleID);
                    nextForm = new AdminForm(admin);
                    break;
                case 2: // cashier
                    var cashier = new Cashier(user.userID, user.username, user.roleID);
                    nextForm = new CashierForm(cashier);
                    break;
                default:
                    MessageBox.Show("Unknown role. Cannot navigate back.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    currentForm.Show();
                    return;
            }

            nextForm.FormClosed += (s, args) => currentForm.Close();
            nextForm.Show();
        }
    }
}
