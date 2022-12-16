using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccountDAL
    {
        TourContext db;
        public AccountDAL()
        {
            db = new TourContext();
        }
        public Account IsAccount(string id, string pass)
        {
            Account a = db.Accounts.Where(s => s.id == id && s.password == pass).FirstOrDefault();
            if (a != null)
                return a;
            return null;
        }
        public void addAccount(Account e)
        {
            db.Accounts.Add(e);
            db.SaveChanges();
        }
    }
}
