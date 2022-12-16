using DAL.Infrastructure.Interfaces;

namespace DAL.Infrastructure.Services
{
    public class DbFactory : Disposable, IDbFactory
    {
        TourContext dbContext;

        public TourContext Init()
        {
            return dbContext ?? (dbContext = new TourContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
