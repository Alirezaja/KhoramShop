using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using KhoramShop.Models;

namespace KhoramShop.Service
{
    public class CartItemService
    {
        public class CustomerService
        {
            KhoramContext db = new KhoramContext();
            public CartItem Insert(CartItem cartitem)
            {
                db.CartItems.Add(cartitem);
                db.SaveChanges();
                return cartitem;
            }
            public CartItem Update(CartItem cartitem)
            {
                db.Entry(cartitem).State = EntityState.Modified;
                db.SaveChanges();
                return cartitem;
            }
            public void Delete(CartItem cartitem)
            {
                db.CartItems.Remove(cartitem);
                db.SaveChanges();
            }
            public CartItem Get(int id)
            {
                CartItem student = db.CartItems.Find(id);
                return student;
            }
            public List<CartItem> GetAll()
            {
                return db.CartItems.ToList();
            }
            public List<CartItem> GetAllPaginated(int pageNumber, int pageSize)
            {
                int Pn = 0 * pageSize;
                if (pageNumber > 0)
                {
                    Pn = (pageNumber - 1) * pageSize;
                }

                return db.CartItems.Skip(Pn).Take(pageSize).ToList();
            }
            }
        }
}