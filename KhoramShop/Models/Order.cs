using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KhoramShop.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }
        public virtual Customer Customer { get; set; }

    }
}