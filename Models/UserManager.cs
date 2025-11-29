using System.Data.SqlClient;
using BCrypt.Net;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Models
{
    public class UserManager
    {
        private string connectionString = "Server=localhost;Database=UMVCCanteen;Integrated Security=true;";

        public User Login(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT u.UserID, u.Username, u.PasswordHash, u.RoleID, r.RoleName 
                           FROM Users u 
                           INNER JOIN Roles r ON u.RoleID = r.RoleID 
                           WHERE u.Username = @username";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string userId = reader["UserID"].ToString();
                            string dbUsername = reader["Username"].ToString();
                            string passwordHash = reader["PasswordHash"].ToString();
                            int roleId = (int)reader["RoleID"];
                            string roleName = reader["RoleName"].ToString();

                            if (BCrypt.Net.BCrypt.Verify(password, passwordHash))
                            {
                                if (roleName == "Admin")
                                {
                                    return new Admin(userId, dbUsername, passwordHash, roleId);
                                }
                                else if (roleName == "Cashier")
                                {
                                    return new Cashier(userId, dbUsername, passwordHash, roleId);
                                }
                            }
                        }
                    }
                }
            }

            return null;
        }
    }
}
