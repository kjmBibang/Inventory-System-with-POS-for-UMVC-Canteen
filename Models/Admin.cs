using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Models
{
    internal class Admin : User
    {
        public Admin(string userID, string username, string passwordHash, int roleID)
            : base(userID, username, passwordHash, roleID)
        {
        }

        // Admin-specific members go here
    }
}
