using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BillDAL
    {
        TourContext db;

        public BillDAL()
        {
            db = new TourContext();
        }

        public List<Bill> getAllBill()
        {
            return db.Bills.ToList();
        }

        public void addBill(Bill e)
        {
            db.Bills.Add(e);
            db.SaveChanges();
        }

        public Bill findBill(int id)
        {
            Bill bill = db.Bills.Find(id);

            if(bill != null)
                return bill;
            return null;
        }

        public void deleteBill(Bill e)
        {
            db.Bills.Remove(e);
            db.SaveChanges();
        }
    }
}
