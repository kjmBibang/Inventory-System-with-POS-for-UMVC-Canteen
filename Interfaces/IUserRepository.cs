using Inventory_System_with_POS_for_UMVC_Canteen.Helpers;
using Inventory_System_with_POS_for_UMVC_Canteen.Interfaces;
using Inventory_System_with_POS_for_UMVC_Canteen.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Data
{
    public interface IUserRepository
    {
        User AuthenticateUser(string username, string password);
        List<User> GetUsers();
        void AddUser(User user, string plainPassword);
        bool UserIdExists(string userId);
        bool VerifyPassword(string userId, string plainPassword);
        void UpdateUser(string userID, string username, int roleID, string newPasswordHash);

    }

}
