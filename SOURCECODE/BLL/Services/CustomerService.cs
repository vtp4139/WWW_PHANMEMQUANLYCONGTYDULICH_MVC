using BLL.Interfaces;
using TourManager.DAL.Infrastructure.Interfaces;
using TourManager.DAL.Repositories.Interfaces;
using System.Collections.Generic;
using TourManager.Models;

namespace TourManager.BLL.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;
        private readonly IUnitOfWork unitOfWork;

        public CustomerService(ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
        {
            this.customerRepository = customerRepository;
            this.unitOfWork = unitOfWork;
        }

        #region IGadgetService Members

        public IEnumerable<Customer> GetCustomers()
        {
            var customers = customerRepository.GetAll();
            return customers;
        }

        public Customer GetCustomer(int id)
        {
            var customer = customerRepository.GetById(id);
            return customer;
        }

        public void CreateCustomer(Customer customer)
        {
            customerRepository.Add(customer);
        }

        public void SaveCustomer()
        {
            unitOfWork.Commit();
        }

        #endregion

    }
}
