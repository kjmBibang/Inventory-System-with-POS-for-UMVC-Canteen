using System;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Models
{
    public abstract class User
    {
        public string userID { get; }
        public string username { get; }
        private string passwordHash { get; set; }
        public int roleID { get; }

        protected User(string userID, string username, int roleID)
        {
            this.userID = userID;
            this.username = username;
            this.passwordHash = passwordHash;
            this.roleID = roleID;
        }

        
    }
}
