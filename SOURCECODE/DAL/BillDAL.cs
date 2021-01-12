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

        public List<eBill> getAllBill()
        {
            return db.Bills.ToList();
        }

        public void addBill(eBill e)
        {
            db.Bills.Add(e);
            db.SaveChanges();
        }

        public eBill findBill(int id)
        {
            eBill bill = db.Bills.Find(id);

            if(bill != null)
                return bill;
            return null;
        }

        public void deleteBill(eBill e)
        {
            db.Bills.Remove(e);
            db.SaveChanges();
        }
    }
}
