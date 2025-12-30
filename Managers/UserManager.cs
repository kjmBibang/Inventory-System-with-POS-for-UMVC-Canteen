using System;
using System.Data.SqlClient;
using System.Runtime.Versioning;
using System.Windows.Forms;
using BCrypt.Net;
using Inventory_System_with_POS_for_UMVC_Canteen.Data;
using Inventory_System_with_POS_for_UMVC_Canteen.Helpers;
using Inventory_System_with_POS_for_UMVC_Canteen.Interfaces;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Models
{
    public class UserManager
    {
        IUserRepository _repo;
        
        public UserManager(IUserRepository userRepository)
        {

            _repo = userRepository;
        }
        public User Login(string username, string password)
        {
            return _repo.AuthenticateUser(username, password);
        }
    }
}
