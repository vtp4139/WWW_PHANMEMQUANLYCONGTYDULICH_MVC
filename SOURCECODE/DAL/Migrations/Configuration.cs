namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.TourContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.TourContext context)
        {
            context.Tours.AddOrUpdate(
               t => t.tourID, AddData.getTours().ToArray());
            context.SaveChanges();

            context.Customers.AddOrUpdate(
                kh => kh.customerID, AddData.getCustomer().ToArray());
            context.SaveChanges();

            context.Bills.AddOrUpdate(
                emt => emt.billID, AddData.GetBills().ToArray());
            context.SaveChanges();

            context.Feedbacks.AddOrUpdate(
                em => em.feedbackID, AddData.GetFeedbacks().ToArray());
            context.SaveChanges();

            context.Accounts.AddOrUpdate(
                em => em.id, AddData.getAccounts().ToArray());
            context.SaveChanges();
        }
    }
}
