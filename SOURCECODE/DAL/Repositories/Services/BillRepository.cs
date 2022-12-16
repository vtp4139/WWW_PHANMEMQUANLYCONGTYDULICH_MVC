using TourManager.DAL.Infrastructure.Interfaces;
using TourManager.DAL.Repositories.Interfaces;
using TourManager.Models;

namespace TourManager.DAL.Infrastructure.Services
{
    public class BillRepository : RepositoryBase<Bill>, IBillRepository
    {
        public BillRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }
}
