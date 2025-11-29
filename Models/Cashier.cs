using System;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Models
{
    internal class Cashier : User
    {
        public Cashier(string userID, string username, string passwordHash, int roleID)
            : base(userID, username, passwordHash, roleID)
        {
        }

        // Cashier-specific members go here
    }
}
