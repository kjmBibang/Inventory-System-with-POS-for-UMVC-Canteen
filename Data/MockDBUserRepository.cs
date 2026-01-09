using Inventory_System_with_POS_for_UMVC_Canteen.Interfaces;
using Inventory_System_with_POS_for_UMVC_Canteen.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Data
{
    public class MockDBUserRepository : IUserRepository
    {
        private static List<MockUser> _users = new List<MockUser>
        {
            new MockUser { UserID = 1, Username = "admin", PasswordHash = "admin", RoleID = 1, RoleName = "Admin" },
            new MockUser { UserID = 2, Username = "cashier", PasswordHash = "cashier", RoleID = 2, RoleName = "Cashier" }
        };
        private static int _nextId = 3;

        public User AuthenticateUser(string username, string password)
        {
            // mock = plaintext compare
            var mockUser = _users.FirstOrDefault(u => u.Username == username && u.PasswordHash == password);

            if (mockUser == null)
                return null;

            if (mockUser.RoleID == 1)
                return new Admin(mockUser.UserID.ToString(), mockUser.Username, mockUser.RoleID);
            else
                return new Cashier(mockUser.UserID.ToString(), mockUser.Username, mockUser.RoleID);
        }

        public void AddUser(string username, string passwordHash, int roleID)
        {
            if (_users.Any(u => u.Username == username))
            {
                throw new Exception("Username already exists.");
            }

            _users.Add(new MockUser
            {
                UserID = _nextId++,
                Username = username,
                PasswordHash = passwordHash,
                RoleID = roleID,
                RoleName = roleID == 1 ? "Admin" : "Cashier"
            });
        }

        public void UpdateUser(int userID, string username, string passwordHash, int roleID)
        {
            var user = _users.FirstOrDefault(u => u.UserID == userID);

            if (user == null)
            {
                throw new Exception("User not found.");
            }

            if (_users.Any(u => u.Username == username && u.UserID != userID))
            {
                throw new Exception("Username already exists.");
            }

            user.Username = username;
            user.PasswordHash = passwordHash;
            user.RoleID = roleID;
            user.RoleName = roleID == 1 ? "Admin" : "Cashier";
        }

        public void UpdateUserWithoutPassword(int userID, string username, int roleID)
        {
            var user = _users.FirstOrDefault(u => u.UserID == userID);

            if (user == null)
            {
                throw new Exception("User not found.");
            }

            if (_users.Any(u => u.Username == username && u.UserID != userID))
            {
                throw new Exception("Username already exists.");
            }

            user.Username = username;
            user.RoleID = roleID;
            user.RoleName = roleID == 1 ? "Admin" : "Cashier";
        }

        public void DeleteUser(int userID)
        {
            var user = _users.FirstOrDefault(u => u.UserID == userID);

            if (user == null)
            {
                throw new Exception("User not found.");
            }

            _users.Remove(user);
        }

        public List<Interfaces.UserInfo> GetAllUsers()
        {
            return _users.Select(u => new Interfaces.UserInfo
            {
                UserID = u.UserID,
                Username = u.Username,
                RoleID = u.RoleID,
                RoleName = u.RoleName
            }).ToList();
        }

        // Internal class to represent mock user data
        private class MockUser
        {
            public int UserID { get; set; }
            public string Username { get; set; }
            public string PasswordHash { get; set; }
            public int RoleID { get; set; }
            public string RoleName { get; set; }
        }
    }
}