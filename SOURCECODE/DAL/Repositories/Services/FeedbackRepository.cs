using DAL.Infrastructure.Interfaces;
using DAL.Infrastructure.Services;
using TourManager.Models;

namespace DAL.Repositories.Interfaces
{
    public class FeedbackRepository : RepositoryBase<Feedback>, IFeedbackRepository
    {
        public FeedbackRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }
}
