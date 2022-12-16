using System.Collections.Generic;
using TourManager.Models;

namespace BLL.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
        Account GetAccount(int id);
        void CreateAccount(Account account);
        void SaveAccount();
    }
}
