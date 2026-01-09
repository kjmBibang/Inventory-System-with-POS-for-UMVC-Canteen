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


                                    return new Admin(userId, dbUsername, roleId, roleName);
                                }

                                else if (roleId == 2)
                                {


                                    return new Cashier(userId, dbUsername, roleId, roleName);
                                }
                            }
                        }
                    }
                }
            }
            return null; // Username not found OR password incorrect
        }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();

            using (SqlConnection conn = new SqlConnection(SQLhelper.GetConnectionString()))
            {
                conn.Open();

                string query = @"
            SELECT 
                u.UserID,
                u.Username,
                u.PasswordHash,
                u.RoleID,
                r.RoleName
            FROM Users u
            INNER JOIN Roles r ON u.RoleID = r.RoleID
        ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string userId = reader["UserID"].ToString();
                        string username = reader["Username"].ToString();
                        int roleId = Convert.ToInt32(reader["RoleID"]);
                        string roleName = reader["RoleName"].ToString();

                        User user;

                        if (roleId == 1)
                            user = new Admin(userId, username, roleId, roleName);
                        else
                            user = new Cashier(userId, username, roleId, roleName);

                        // optional helper property if you have one
                        user.roleName = roleName;

                        users.Add(user);
                    }
                }
            }

            return users;
        }
        public bool UserIdExists(string userId)
        {
            using (SqlConnection conn = new SqlConnection(SQLhelper.GetConnectionString()))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE UserID = @UserID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }
        public void AddUser(User user, string plainPassword)
        {
            string hashedPassword = bcryptHelper.HashPassword(plainPassword);

            using (SqlConnection conn = new SqlConnection(SQLhelper.GetConnectionString()))
            {
                conn.Open();

                string query = @"
            INSERT INTO Users (UserID, Username, PasswordHash, RoleID)
            VALUES (@UserID, @Username, @PasswordHash, @RoleID)
        ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", user.userID);
                    cmd.Parameters.AddWithValue("@Username", user.username);
                    cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                    cmd.Parameters.AddWithValue("@RoleID", user.roleID);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public bool VerifyPassword(string userId, string plainPassword)
        {
            using (SqlConnection conn = new SqlConnection(SQLhelper.GetConnectionString()))
            {
                conn.Open();
                string sql = "SELECT PasswordHash FROM Users WHERE UserID = @UserID";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    var hash = cmd.ExecuteScalar()?.ToString();
                    if (hash == null) return false;

                    return bcryptHelper.VerifyPassword(plainPassword, hash);
                }
            }
        }
        public void UpdateUser(string userID, string username, int roleID, string newPasswordHash)
        {
            using (SqlConnection conn = new SqlConnection(SQLhelper.GetConnectionString()))
            {
                conn.Open();

                string sql = newPasswordHash == null
                    ? @"UPDATE Users SET Username=@Username, RoleID=@RoleID WHERE UserID=@UserID"
                    : @"UPDATE Users SET Username=@Username, RoleID=@RoleID, PasswordHash=@PasswordHash WHERE UserID=@UserID";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@RoleID", roleID);

                    if (newPasswordHash != null)
                        cmd.Parameters.AddWithValue("@PasswordHash", newPasswordHash);

                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
