using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KhoramShop.Models
{
    public class Cart
    {
        public int CartID { get; set; }
        public int CustomerID { get; set; }
        public virtual ICollection<CartItem> CartItem { get; set; }
        public virtual Order Customer { get; set; }
        
    }
}