using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using BCrypt.Net;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Models
{
    public class UserManager
    {

        private string databaseConnection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UMVC-CanteenDB;Integrated Security=True;TrustServerCertificate=True;";

        public User Login(string username, string password)

        {
            
            using (SqlConnection conn = new SqlConnection(databaseConnection))
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
                            string userId = reader["UserID"].ToString();
                            string dbUsername = reader["Username"].ToString();
                            string passwordHash = reader["PasswordHash"].ToString();
                            int roleId = (int)reader["RoleID"];
                            string roleName = reader["RoleName"].ToString();

                            if (BCrypt.Net.BCrypt.Verify(password, passwordHash))
                            {
                                if (roleName == "admin")
                                {
                                    MessageBox.Show("new admin");
                                    return new Admin(userId, dbUsername, passwordHash, roleId);
                                }
                                else if (roleName == "cashier")
                                {
                                    MessageBox.Show("new cashier");
                                    return new Cashier(userId, dbUsername, passwordHash, roleId);
                                }
                            }
                        }
                    }
                }

            }
            
            MessageBox.Show("Wrong credentials");
            return null;
        }
    }
}
