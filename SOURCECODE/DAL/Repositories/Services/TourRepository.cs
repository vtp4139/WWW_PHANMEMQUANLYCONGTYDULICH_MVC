using DAL.Infrastructure.Interfaces;
using DAL.Infrastructure.Services;
using TourManager.Models;

namespace DAL.Repositories.Interfaces
{
    public class TourRepository : RepositoryBase<Tour>, ITourRepository
    {
        public TourRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }
}
