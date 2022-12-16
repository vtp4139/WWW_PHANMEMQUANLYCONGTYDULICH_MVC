using BLL.Interfaces;
using TourManager.DAL.Infrastructure.Interfaces;
using TourManager.DAL.Repositories.Interfaces;
using System.Collections.Generic;
using TourManager.Models;

namespace TourManager.BLL.Services
{
    public class BillService : IBillService
    {
        private readonly IBillRepository billRepository;
        private readonly IUnitOfWork unitOfWork;

        public BillService(IBillRepository billRepository, IUnitOfWork unitOfWork)
        {
            this.billRepository = billRepository;
            this.unitOfWork = unitOfWork;
        }

        #region IGadgetService Members

        public IEnumerable<Bill> GetBills()
        {
            var bills = billRepository.GetAll();
            return bills;
        }

        public Bill GetBill(int id)
        {
            var bill = billRepository.GetById(id);
            return bill;
        }

        public void CreateBill(Bill bill)
        {
            billRepository.Add(bill);
        }

        public void SaveBill()
        {
            unitOfWork.Commit();
        }

        #endregion

    }
}
