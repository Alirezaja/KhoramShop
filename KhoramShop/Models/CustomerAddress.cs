using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KhoramShop.Models
{
    public class CustomerAddress
    {
        public int CustomerAddressID { get; set; }
        public int CustomerID { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int Phone1 { get; set; }
        public int Phone2 { get; set; }
        public virtual Order Customer { get; set; }
    }
}