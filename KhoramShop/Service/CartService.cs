using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using KhoramShop.Models;

namespace KhoramShop.Service
{
    public class CartService
    {
        public class CustomerService
        {
            KhoramContext db = new KhoramContext();
            public Cart Insert(Cart Cart)
            {
                db.Cart.Add(Cart);
                db.SaveChanges();
                return Cart;
            }
            public Cart Update(Cart Cart)
            {
                db.Entry(Cart).State = EntityState.Modified;
                db.SaveChanges();
                return Cart;
            }
            public void Delete(Cart Cart)
            {
                db.Cart.Remove(Cart);
                db.SaveChanges();
            }
            public Cart Get(int id)
            {
                Cart student = db.Cart.Find(id);
                return student;
            }
            public List<Cart> GetAll()
            {
                return db.Cart.ToList();
            }
            public List<Cart> GetAllPaginated(int pageNumber, int pageSize)
            {
                int Pn = 0 * pageSize;
                if (pageNumber > 0)
                {
                    Pn = (pageNumber - 1) * pageSize;
                }

                return db.Cart.Skip(Pn).Take(pageSize).ToList();
            }
        }
    }
}