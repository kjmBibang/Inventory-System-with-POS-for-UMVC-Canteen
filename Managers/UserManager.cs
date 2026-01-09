using BCrypt.Net;
using Inventory_System_with_POS_for_UMVC_Canteen.Data;
using Inventory_System_with_POS_for_UMVC_Canteen.Helpers;
using Inventory_System_with_POS_for_UMVC_Canteen.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.Versioning;
using System.Windows.Forms;

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
        public List<User> GetAllUsers()
        {
            return _repo.GetUsers();
        }
        public void AddUser(string userId, string username, string password, int roleId)
        {
            if (_repo.UserIdExists(userId))
                throw new Exception("UserID already exists.");

            User user;

            if (roleId == 1)
                user = new Admin(userId, username, roleId,"Admin");
            else
                user = new Cashier(userId, username, roleId,"Cashier");

            _repo.AddUser(user, password);
        }
        // ✅ NEW: verify password
        public bool VerifyCurrentPassword(string userID, string plainPassword)
        {
            return _repo.VerifyPassword(userID, plainPassword);
        }

        // ✅ NEW: update user (with optional password)
        public void UpdateUser(
            string userID,
            string username,
            int roleID,
            string newPlainPassword // NULL = don't update password
        )
        {
            string newPasswordHash = null;

            if (!string.IsNullOrWhiteSpace(newPlainPassword))
            {
                newPasswordHash = BCrypt.Net.BCrypt.HashPassword(newPlainPassword);
            }

            _repo.UpdateUser(userID, username, roleID, newPasswordHash);
        }
        public void DeleteUser(string userId)
        {
            if (string.IsNullOrWhiteSpace(userId))
                throw new Exception("Invalid user.");

            _repo.DeleteUser(userId);
        }

    }
}
