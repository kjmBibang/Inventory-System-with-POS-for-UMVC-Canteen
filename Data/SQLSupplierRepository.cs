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
    public class SQLSupplierRepository : ISupplierRepository
    {
        IServerHelper serverHelper = new SQLHelper();

        public List<Supplier> GetAllSuppliers()
        {
            var list = new List<Supplier>();

            using (SqlConnection con = new SqlConnection(serverHelper.GetConnectionString()))
            {
                string query = @"SELECT SupplierID, Name,Contact,Address,Email FROM Supplier";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Supplier
                        {
                            supplierID = (int)reader["SupplierID"],
                            supplierName = (string)reader["Name"],
                            supplierContact = (string)reader["Contact"],
                            supplierAddress = (string)reader["Name"],
                            supplierEmail = (string)reader["Name"]
                        });
                    }
                }
            }

            return list;
        }
    }
}
