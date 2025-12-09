using Inventory_System_with_POS_for_UMVC_Canteen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Helpers
{
    class SQLHelper : IServerHelper
    {
        public string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString;
        }
    }
}
