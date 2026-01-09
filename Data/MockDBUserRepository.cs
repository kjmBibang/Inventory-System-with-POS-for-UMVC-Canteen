using Inventory_System_with_POS_for_UMVC_Canteen.Interfaces;
using Inventory_System_with_POS_for_UMVC_Canteen.Models;
using System.Collections.Generic;
using System.Linq;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Data
{
    public class MockDBUserRepository : IUserRepository
    {
        private static List<User> _users = new List<User>
        {
            new Admin("1", "admin", 1,""),
            new Cashier("2", "cashier", 2,"")
        };

        public void AddUser(User user, string plainPassword)
        {
            throw new System.NotImplementedException();
        }

        public User AuthenticateUser(string username, string password)
        {
            // mock = plaintext compare
            return _users.FirstOrDefault(u => u.username == username);
        }

        public void DeleteUser(string userId)
        {
            throw new System.NotImplementedException();
        }

        public List<User> GetUsers()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateUser(string userID, string username, int roleID, string newPasswordHash)
        {
            throw new System.NotImplementedException();
        }

        public bool UserIdExists(string userId)
        {
            throw new System.NotImplementedException();
        }

        public bool VerifyPassword(string userId, string plainPassword)
        {
            throw new System.NotImplementedException();
        }
    }
}
