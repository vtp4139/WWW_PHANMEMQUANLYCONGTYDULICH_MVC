using TourManager.DAL.Infrastructure.Interfaces;
using TourManager.DAL.Infrastructure.Services;
using TourManager.Models;

namespace TourManager.DAL.Repositories.Interfaces
{
    public class FeedbackRepository : RepositoryBase<Feedback>, IFeedbackRepository
    {
        public FeedbackRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }
}
