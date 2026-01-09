using System;
using System.Collections.Generic;
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

        public Admin AuthorizeAdmin(string username, string password)
        {
            User user = _repo.AuthenticateUser(username, password);

            if (user == null)
                return null;

            if (user.roleID != 1)
                return null;

            return user as Admin;
        }

        public List<Interfaces.UserInfo> LoadUsers()
        {
            try
            {
                return _repo.GetAllUsers();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading users: {ex.Message}", ex);
            }
        }

        public void AddUser(string username, string passwordHash, int roleID)
        {
            _repo.AddUser(username, passwordHash, roleID);
        }

        public void UpdateUser(int userID, string username, string passwordHash, int roleID)
        {
            _repo.UpdateUser(userID, username, passwordHash, roleID);
        }

        public void UpdateUserWithoutPassword(int userID, string username, int roleID)
        {
            _repo.UpdateUserWithoutPassword(userID, username, roleID);
        }

        public void DeleteUser(int userID)
        {
            _repo.DeleteUser(userID);
        }
    }
}