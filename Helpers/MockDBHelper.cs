using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Inventory_System_with_POS_for_UMVC_Canteen.Interfaces;
namespace Inventory_System_with_POS_for_UMVC_Canteen.Helpers
{
    class MockDBHelper : IServerHelper
    {
        public string GetConnectionString()
        {
            return "MockDBConnectionString";
        }
    }
}
