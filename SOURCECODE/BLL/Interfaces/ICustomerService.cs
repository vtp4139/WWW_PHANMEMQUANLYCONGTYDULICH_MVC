using System.Collections.Generic;
using TourManager.Models;

namespace BLL.Interfaces
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomer(int id);
        void CreateCustomer(Customer customer);
        void SaveCustomer();
    }
}
