using BLL.Interfaces;
using System.Collections.Generic;
using TourManager.DAL.Infrastructure.Interfaces;
using TourManager.DAL.Repositories.Interfaces;
using TourManager.Models;

namespace TourManager.BLL.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository accountRepository;
        private readonly IUnitOfWork unitOfWork;

        public AccountService(IAccountRepository accountRepository, IUnitOfWork unitOfWork)
        {
            this.accountRepository = accountRepository;
            this.unitOfWork = unitOfWork;
        }

        #region IGadgetService Members

        public IEnumerable<Account> GetAccounts()
        {
            var accounts = accountRepository.GetAll();
            return accounts;
        }

        public Account GetAccount(int id)
        {
            var account = accountRepository.GetById(id);
            return account;
        }

        public void CreateAccount(Account account)
        {
            accountRepository.Add(account);
        }

        public void SaveAccount()
        {
            unitOfWork.Commit();
        }

        #endregion

    }
}
