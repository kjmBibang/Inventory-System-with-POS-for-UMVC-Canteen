using System;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Models
{
    public abstract class User
    {
        protected string userID { get; }
        protected string username { get; }
        protected string passwordHash { get; }
        protected int roleID { get; }

        protected User(string userID, string username, string passwordHash, int roleID)
        {
            this.userID = userID;
            this.username = username;
            this.passwordHash = passwordHash;
            this.roleID = roleID;
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
