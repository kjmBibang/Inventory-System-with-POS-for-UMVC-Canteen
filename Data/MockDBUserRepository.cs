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

        public User AuthenticateUser(string username, string password)
        {
            // mock = plaintext compare
            return _users.FirstOrDefault(u => u.username == username);
        }

        public List<User> GetUsers()
        {
            throw new System.NotImplementedException();
        }
    }
}
