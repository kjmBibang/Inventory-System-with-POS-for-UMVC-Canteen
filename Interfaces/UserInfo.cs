using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Interfaces
{
    public class UserInfo
    {
        public int UserID { get; set; }  // Can be changed to string if needed
        public string Username { get; set; }
        public int RoleID { get; set; }
        public string RoleName { get; set; }
    }
}