using TourManager.DAL.Infrastructure.Interfaces;
using TourManager.DAL.Infrastructure.Services;
using TourManager.Models;

namespace TourManager.DAL.Repositories.Interfaces
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }
}
