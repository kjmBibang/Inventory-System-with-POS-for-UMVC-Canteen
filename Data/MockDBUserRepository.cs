using Inventory_System_with_POS_for_UMVC_Canteen.Helpers;
using Inventory_System_with_POS_for_UMVC_Canteen.Interfaces;
using Inventory_System_with_POS_for_UMVC_Canteen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Data
{
    public class MockDBUserRepository : IUserRepository
    {       
            private IServerHelper mockDBHelper;
            private ISecurityHelper bcryptHelper;

            // Mock users (simulating DB rows)
            private readonly List<(string UserID, string Username, string PasswordHash, int RoleID, string RoleName)> users;

            public MockDBUserRepository()
            {
                mockDBHelper = new MockDBHelper(); // still called, even if random string
                bcryptHelper = new BCryptHelper();

                // Simulated database data
                users = new List<(string, string, string, int, string)>
        {
            (
                "1",
                "admin",
                bcryptHelper.HashPassword("admin123"),
                1,
                "Admin"
            ),
            (
                "2",
                "cashier",
                bcryptHelper.HashPassword("cashier123"),
                2,
                "Cashier"
            )
        };
            }

            public User AuthenticateUser(string username, string password)
            {
                // Still "uses" connection string (mocked)
                string fakeConnection = mockDBHelper.GetConnectionString();

                // Simulate SELECT ... WHERE Username = @Username
                var user = users.FirstOrDefault(u => u.Username == username);

                if (user.Username == null)
                    return null;

                // Simulate bcrypt verification
                if (!bcryptHelper.VerifyPassword(password, user.PasswordHash))
                    return null;

                // Simulate role logic
                if (user.RoleID == 1)
                    return new Admin(user.UserID, user.Username, user.RoleID);

                if (user.RoleID == 2)
                    return new Cashier(user.UserID, user.Username, user.RoleID);

                return null;
            }
        }

    }

