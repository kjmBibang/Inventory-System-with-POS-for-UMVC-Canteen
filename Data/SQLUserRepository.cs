using Inventory_System_with_POS_for_UMVC_Canteen.Helpers;
using Inventory_System_with_POS_for_UMVC_Canteen.Interfaces;
using Inventory_System_with_POS_for_UMVC_Canteen.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Data
{
    public class SQLUserRepository : IUserRepository
    {
        private IServerHelper SQLhelper;
        private ISecurityHelper bcryptHelper = new BCryptHelper();

        public SQLUserRepository()
        {
            SQLhelper = new SQLHelper();
        }

        public User AuthenticateUser(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(SQLhelper.GetConnectionString()))
            {
                conn.Open();
                string query = @"SELECT u.UserID, u.Username, u.PasswordHash, u.RoleID, r.RoleName 
                            FROM Users u 
                            INNER JOIN Roles r ON u.RoleID = r.RoleID 
                            WHERE u.Username = @Username";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.CommandTimeout = 30;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string passwordHash = reader["PasswordHash"].ToString();

                            if (bcryptHelper.VerifyPassword(password, passwordHash))
                            {
                                string userId = reader["UserID"].ToString();
                                string dbUsername = reader["Username"].ToString();
                                int roleId = (int)reader["RoleID"];
                                string roleName = reader["RoleName"].ToString();

                                if (roleId == 1)
                                {
                                    return new Admin(userId, dbUsername, roleId);
                                }
                                else if (roleId == 2)
                                {
                                    return new Cashier(userId, dbUsername, roleId);
                                }
                            }
                        }
                    }
                }
            }
            return null;
        }

        public void AddUser(string username, string passwordHash, int roleID)
        {
            using (SqlConnection conn = new SqlConnection(SQLhelper.GetConnectionString()))
            {
                conn.Open();

                // Check if username already exists
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@Username", username);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        throw new Exception("Username already exists.");
                    }
                }

                // Fixed: Removed UserID from INSERT - it's auto-generated (IDENTITY column)
                string query = @"INSERT INTO Users (Username, PasswordHash, RoleID) 
                                VALUES (@Username, @PasswordHash, @RoleID)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
                    cmd.Parameters.AddWithValue("@RoleID", roleID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateUser(int userID, string username, string passwordHash, int roleID)
        {
            using (SqlConnection conn = new SqlConnection(SQLhelper.GetConnectionString()))
            {
                conn.Open();

                // Check if username already exists for another user
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND UserID != @UserID";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@Username", username);
                    checkCmd.Parameters.AddWithValue("@UserID", userID);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        throw new Exception("Username already exists.");
                    }
                }

                string query = @"UPDATE Users 
                                SET Username = @Username, PasswordHash = @PasswordHash, RoleID = @RoleID 
                                WHERE UserID = @UserID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
                    cmd.Parameters.AddWithValue("@RoleID", roleID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateUserWithoutPassword(int userID, string username, int roleID)
        {
            using (SqlConnection conn = new SqlConnection(SQLhelper.GetConnectionString()))
            {
                conn.Open();

                // Check if username already exists for another user
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND UserID != @UserID";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@Username", username);
                    checkCmd.Parameters.AddWithValue("@UserID", userID);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        throw new Exception("Username already exists.");
                    }
                }

                string query = @"UPDATE Users 
                                SET Username = @Username, RoleID = @RoleID 
                                WHERE UserID = @UserID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@RoleID", roleID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteUser(int userID)
        {
            using (SqlConnection conn = new SqlConnection(SQLhelper.GetConnectionString()))
            {
                conn.Open();
                string query = "DELETE FROM Users WHERE UserID = @UserID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("User not found.");
                    }
                }
            }
        }

        public List<Interfaces.UserInfo> GetAllUsers()
        {
            List<Interfaces.UserInfo> users = new List<Interfaces.UserInfo>();

            try
            {
                using (SqlConnection conn = new SqlConnection(SQLhelper.GetConnectionString()))
                {
                    conn.Open();
                    string query = @"SELECT u.UserID, u.Username, u.RoleID, r.RoleName 
                                    FROM Users u 
                                    INNER JOIN Roles r ON u.RoleID = r.RoleID
                                    ORDER BY u.UserID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var userInfo = new Interfaces.UserInfo();

                                // Safely parse UserID
                                string rawUserId = reader["UserID"]?.ToString();
                                if (int.TryParse(rawUserId, out int uId))
                                {
                                    userInfo.UserID = uId;
                                }

                                userInfo.Username = reader["Username"]?.ToString() ?? "";

                                // Safely parse RoleID
                                string rawRoleId = reader["RoleID"]?.ToString();
                                if (int.TryParse(rawRoleId, out int rId))
                                {
                                    userInfo.RoleID = rId;
                                }

                                userInfo.RoleName = reader["RoleName"]?.ToString() ?? "";

                                users.Add(userInfo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving users from database: {ex.Message}", ex);
            }

            return users;
        }
    }
}