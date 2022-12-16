using DAL.Infrastructure.Interfaces;
using DAL.Infrastructure.Services;
using DAL.Repositories.Interfaces;
using TourManager.Models;

namespace DAL.Repositories.Services
{
    public class BillRepository : RepositoryBase<Bill>, IBillRepository
    {
        public BillRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }
}
