using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerDAL
    {
        TourContext db;

        public CustomerDAL()
        {
            db = new TourContext();
        }

        public eCustomer GetCustomer(int id)
        {
            eCustomer a = db.Customers.Where(s => s.customerID == id).FirstOrDefault();
            if (a != null)
                return a;
            return null;
        }
        public void editCustomer(eCustomer c)
        {
            db.Entry(c).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void addCustomer(eCustomer e)
        {
            db.Customers.Add(e);
            db.SaveChanges();
        }

    }
}
