using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using KhoramShop.Models;
using System.Web.Mvc;

namespace KhoramShop.Service
{
    public class UserService
    {
        KhoramContext db = new KhoramContext();
        public User Insert(User user)
        {
            db.User.Add(user);
            db.SaveChanges();
            return user;
        }
        public User Update(User user)
        {
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();
            return user;
        }
        public User Delete(User user)
        {
            db.User.Remove(user);
            return user;
        }
        public User Get(int id)
        {
            return db.User.Find(id);
        }
        public List<User> GetAll()
        {
           return db.User.ToList();
        }
        public List<User> GetAllPaginated(int pageNumber,int pageSize)
        {
            int Pn = 0 * pageSize;
            if(pageNumber>0)
            {
                Pn = pageNumber - 1 * pageSize;
            }
            return db.User.Skip(pageNumber).Take(pageSize).ToList();
        }
    }
}