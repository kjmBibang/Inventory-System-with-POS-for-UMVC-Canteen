using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Models
{
    public class Supplier
    {
        public string Name { get; set; }
        public string Contact { get; set; }     // phone or person
        public string Address { get; set; }
        public string Email { get; set; }

        public Supplier() { }

        public Supplier(string name, string contact, string address, string email)
        {
            Name = name;
            Contact = contact;
            Address = address;
            Email = email;
        }
    }
}
