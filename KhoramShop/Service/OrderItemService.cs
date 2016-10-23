using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KhoramShop.Models;
using System.Data.Entity;

namespace KhoramShop.Service
{
    public class OrderItemService
    {
        KhoramContext db = new KhoramContext();
        public Order Insert(Order customer)
        {
            db.OrderItem.Add(customer);
            db.SaveChanges();
            return customer;
        }
        public Order Update(Order customer)
        {
            db.Entry(customer).State = EntityState.Modified;
            db.SaveChanges();
            return customer;
        }
        public void Delete(Order customer)
        {
            db.OrderItem.Remove(customer);
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