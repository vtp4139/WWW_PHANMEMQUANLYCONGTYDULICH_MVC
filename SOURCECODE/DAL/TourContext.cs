using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TourContext:DbContext
    {
        public TourContext() : base("TourConnectDB")
        {

        }
        public DbSet<eTour> Tours { get; set; }
        public DbSet<eBill> Bills { get; set; }
        public DbSet<eCustomer> Customers { get; set; }
        public DbSet<eAccount> Accounts { get; set; }
        public DbSet<eFeedback> Feedbacks { get; set; }
    }
}
