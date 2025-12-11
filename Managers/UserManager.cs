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


        
        UserRepository userRepository;
        
        public UserManager(UserRepository userRepository)
        {
            
            this.userRepository = userRepository;
            
        }
        public User Login(string username, string password)

        {

            return userRepository.AuthenticateUser(username, password);
        }
    }
}
