using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using KhoramShop.Models;

namespace KhoramShop.Service
{
    public class OrderService
    {
        KhoramContext db = new KhoramContext();
        public Order Insert(Order order)
        {
            db.OrderItem.Add(order);
            db.SaveChanges();
            return order;
        }
        public Order Update(Order order)
        {
            db.Entry(order).State = EntityState.Modified;
            db.SaveChanges();
            return order;
        }
        public void Delete(Order order)
        {
            db.OrderItem.Remove(order);
            db.SaveChanges();
        }
        public Order Get(int id)
        {
            Order student = db.OrderItem.Find(id);
            return student;
        }
        public List<Order> GetAll()
        {
            return db.OrderItem.ToList();
        }
        public List<Order> GetAllPaginated(int pageNumber, int pageSize)
        {
            int Pn = 0 * pageSize;
            if (pageNumber > 0)
            {
                Pn = (pageNumber - 1) * pageSize;
            }

            return db.OrderItem.Skip(Pn).Take(pageSize).ToList();
        }
    }
}