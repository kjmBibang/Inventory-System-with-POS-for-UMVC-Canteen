using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Models
{
    abstract class User
    {
        protected string userID { get; set; }
        protected string username { get; set; } 
        protected string passwordHash { get; set; }
        protected int roleID { get; set; }

        public User(string userID, string username, string passwordHash, int roleID)
        {
           
        }
        public string GetUsername()
        {
            return username;
        }
        public string GetUserID()
        {
            return userID;
        }

    }
}
