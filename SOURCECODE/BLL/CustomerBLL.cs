using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CustomerBLL
    {
        CustomerDAL cusDAL;

        public CustomerBLL()
        {
            cusDAL = new CustomerDAL();
        }

        public eCustomer GetCustomer(int id)
        {
            return cusDAL.GetCustomer(id);
        }

        public void editCustomer(eCustomer c)
        {
            cusDAL.editCustomer(c);
        }
        public void addCustomer(eCustomer e)
        {
            cusDAL.addCustomer(e);
        }
    }
}
