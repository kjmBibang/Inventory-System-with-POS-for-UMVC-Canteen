using System;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Models
{
    public abstract class User
    {
        protected string UserID { get; }
        protected string Username { get; }
        protected string PasswordHash { get; }
        protected int RoleID { get; }

        protected User(string userID, string username, string passwordHash, int roleID)
        {
            UserID = userID;
            Username = username;
            PasswordHash = passwordHash;
            RoleID = roleID;
        }

        public string GetUsername()
        {
            return Username;
        }

        public string GetUserID()
        {
            return UserID;
        }
    }
}
