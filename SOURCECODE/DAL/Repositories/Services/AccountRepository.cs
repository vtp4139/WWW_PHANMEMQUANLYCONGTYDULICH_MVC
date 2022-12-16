using DAL.Infrastructure.Interfaces;
using DAL.Infrastructure.Services;
using TourManager.Models;

namespace DAL.Repositories.Interfaces
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }
}
