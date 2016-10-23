using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Linq.Expressions;
using KhoramShop.Models;
using System.Data.Entity;


namespace KhoramShop.Service
{
    public class BaseService<TObject>where TObject:class
    {
        protected KhoramContext db;
        public BaseService(KhoramContext context)
        {
            db = context;
        }
        
        public ICollection<TObject> GetAll()
        {
            return db.Set<TObject>().ToList();
        }
        public TObject Get(int id)
        {
            return db.Set<TObject>().Find(id);
        }
        public TObject Update(TObject update)
        {
            db.Entry(update).CurrentValues.SetValues(update);
            db.SaveChanges();
            return update;
        }
        public TObject Insert(TObject t)
        {
            db.Set<TObject>().Add(t);
            db.SaveChanges();
            return t;
        }
        public void Delete(TObject t)
        {
            db.Set<TObject>().Remove(t);
            db.SaveChanges();
        }
        public ICollection<TObject> Paginated(int pageNumber,int pageSize)
        {
            int Pn = 0 * pageSize;
            if(pageSize>0)
            {
                Pn = (pageNumber - 1) * pageSize;
            }
            return db.Set<TObject>().Skip(Pn).Take(pageSize).ToList();
        }

    }
}
