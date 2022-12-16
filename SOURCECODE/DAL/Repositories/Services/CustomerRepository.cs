using DAL.Infrastructure.Interfaces;
using DAL.Infrastructure.Services;
using TourManager.Models;

namespace DAL.Repositories.Interfaces
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }
}
