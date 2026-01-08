using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Models
{
    public class Supplier
    {
        public int supplierID { get; set; }
        public string supplierName { get; set; }
        public string supplierContact { get; set; }     // phone or person
        public string supplierAddress { get; set; }
        public string supplierEmail { get; set; }

        public Supplier() { }

        public Supplier(int supplierID,string name, string contact, string address, string email)
        {
            this.supplierID = supplierID;
            supplierName = name;
            supplierContact = contact;
            supplierAddress = address;
            supplierEmail = email;
        }
    }
}
