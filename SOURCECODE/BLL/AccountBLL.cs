using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AccountBLL
    {
        AccountDAL accountDAL;

        public AccountBLL()
        {
            accountDAL = new AccountDAL();
        }
        public eAccount IsAccount(string id, string pass)
        {
            return accountDAL.IsAccount(id, pass);
        }
        public void addAccount(eAccount e)
        {
            accountDAL.addAccount(e);
        }
    }

    //Test git is work or not ?
}
