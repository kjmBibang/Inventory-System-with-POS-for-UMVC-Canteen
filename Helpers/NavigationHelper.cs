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
        public static void GoBackToDashboard(Form currentForm, User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            currentForm.Close();

            Form nextForm;

            switch (user.roleID)
            {
                case 1: // admin
                    var admin = new Admin(user.userID, user.username, user.roleID, user.roleName);
                    nextForm = new Dashboard(admin);
                    break;
                case 2: // cashier
                    var cashier = new Cashier(user.userID, user.username, user.roleID, user.roleName);
                    nextForm = new Dashboard(cashier);
                    break;
                default:
                    MessageBox.Show("Unknown role. Cannot navigate back.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    currentForm.Show();
                    return;
            }

            nextForm.FormClosed += (s, args) => currentForm.Close();
            nextForm.Show();
        }

        public static void NavigateToInventory(Form currentForm, User user)
        {
            var form = new InventoryManagementForm(user);
            form.Show();
            currentForm.Close();
        }
        public static void NavigateToUserManagement(Form currentForm, User user)
        {
            var form = new UserManagementForm(user);
            form.Show();
            currentForm.Close();
        }
        /*public static void NavigateToReports(Form currentForm, User user)
        {
            var form = new ReportsForm(user);
            form.Show();
            currentForm.Hide();
        }*/
    }
}
