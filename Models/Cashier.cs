using System;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Models
{
    public class Cashier : User
    {
        public Cashier(string userID, string username , int roleID)
            : base(userID, username, roleID)
        {
        }

        // Cashier-specific members go here
    }
}
