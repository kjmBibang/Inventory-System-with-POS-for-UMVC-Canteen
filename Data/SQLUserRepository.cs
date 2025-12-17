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
            return null; // Username not found OR password incorrect
        }
    }
}
