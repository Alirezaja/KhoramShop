using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using KhoramShop.Models;

namespace KhoramShop.Service
{
    public class CategoryService
    {
        KhoramContext db = new KhoramContext();
        public Category Insert(Category category)
        {
            db.Category.Add(category);
            db.SaveChanges();
            return category;
        }
        public Category Update(Category category)
        {
            db.Entry(category).State = EntityState.Modified;
            db.SaveChanges();
            return category;
        }
        public void Delete(Category category)
        {
            db.Category.Remove(category);
            db.SaveChanges();
        }
        public Category Get(int id)
        {
            Category student = db.Category.Find(id);
            return student;
        }
        public List<Category> GetAll()
        {
            return db.Category.ToList();
        }
        public List<Category> GetAllPaginated(int pageNumber, int pageSize)
        {
            int Pn = 0 * pageSize;
            if (pageNumber > 0)
            {
                Pn = (pageNumber - 1) * pageSize;
            }

            return db.Category.Skip(Pn).Take(pageSize).ToList();
        }
    }
}