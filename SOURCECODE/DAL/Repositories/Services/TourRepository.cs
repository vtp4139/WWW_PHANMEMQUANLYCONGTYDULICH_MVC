using TourManager.DAL.Infrastructure.Interfaces;
using TourManager.DAL.Infrastructure.Services;
using TourManager.Models;

namespace TourManager.DAL.Repositories.Interfaces
{
    public class TourRepository : RepositoryBase<Tour>, ITourRepository
    {
        public TourRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }
}
