using System.Data.Entity;
using TourManager.Models;
namespace TourManager.DAL
{
    public class TourContext:DbContext
    {
        public TourContext() : base("TourConnectDB")
        {

        }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        public DbSet<Tour> Tours { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
    }
}
