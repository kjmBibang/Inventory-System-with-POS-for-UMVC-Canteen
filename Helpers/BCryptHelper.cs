using Inventory_System_with_POS_for_UMVC_Canteen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Helpers
{
    class BCryptHelper : ISecurityHelper
    {
        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public void VerifyPassword(string plainPassword, string hashPassword)
        {
            BCrypt.Net.BCrypt.Verify(plainPassword, hashPassword);
        }
    }
}
