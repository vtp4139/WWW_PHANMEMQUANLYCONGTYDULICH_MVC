using TourManager.DAL.Infrastructure.Interfaces;
using TourManager.DAL.Infrastructure.Services;
using TourManager.Models;

namespace TourManager.DAL.Repositories.Interfaces
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }
}
