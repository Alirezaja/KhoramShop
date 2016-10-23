using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KhoramShop.Models
{
    public class CartItem
    {
        public int CartItemID { get; set; }
        public int CartID { get; set; }
        public int ProductID { get; set; }
        public int Count { get; set; }
        public virtual Product Product { get; set; }
    }
}