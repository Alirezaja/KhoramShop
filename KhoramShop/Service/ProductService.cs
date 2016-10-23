using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KhoramShop.Models;
using System.Data.Entity;

namespace KhoramShop.Service
{
    public class ProductService
    {
        KhoramContext db = new KhoramContext();
        public Product Insert(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return product;
        }
        public Product Update(Product product)
        {
            db.Entry(product).State= EntityState.Modified;
            db.SaveChanges();
            return product;
        }
        public void Delete(Product product)
        {
            db.Products.Remove(product);
            db.SaveChanges();
        }
        public Product Get(int id)
        {
           return db.Products.Find(id);
        }
        public List<Product> GetAll()
        {
            return db.Products.ToList();
        }
        public List<Product> GetAllPaginated(int pageNumber, int pageSize)
        {
            int Pn = 0 * pageSize;
            if (pageNumber > 0)
            {
                Pn = (pageNumber - 1) * pageSize;
            }

            return db.Products.Skip(Pn).Take(pageSize).ToList();
        }
    }
}