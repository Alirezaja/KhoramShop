using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using KhoramShop.Models;

namespace KhoramShop.Service
{
    public class CustomerAddressService
    {
        KhoramContext db = new KhoramContext();
        public CustomerAddress Insert(CustomerAddress customerAddress)
        {
            db.CustomerAddresses.Add(customerAddress);
            db.SaveChanges();
            return customerAddress;
        }
        public CustomerAddress Update(CustomerAddress customerAddress)
        {
            db.Entry(customerAddress).State = EntityState.Modified;
            db.SaveChanges();
            return customerAddress;
        }
        public void Delete(CustomerAddress customerAddress)
        {
            db.CustomerAddresses.Remove(customerAddress);
            db.SaveChanges();
        }
        public CustomerAddress Get(int id)
        {
            CustomerAddress student = db.CustomerAddresses.Find(id);
            return student;
        }
        public List<CustomerAddress> GetAll()
        {
            return db.CustomerAddresses.ToList();
        }
        public List<CustomerAddress> GetAllPaginated(int pageNumber, int pageSize)
        {
            int Pn = 0 * pageSize;
            if (pageNumber > 0)
            {
                Pn = (pageNumber - 1) * pageSize;
            }

            return db.CustomerAddresses.Skip(Pn).Take(pageSize).ToList();
        }
    }
}