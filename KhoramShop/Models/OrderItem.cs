using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KhoramShop.Models
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Count { get; set; }
        public virtual Product Product { get; set; }
    }
}