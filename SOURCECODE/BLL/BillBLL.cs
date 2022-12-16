using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BillBLL
    {
        BillDAL billDAL;

        public BillBLL()
        {
            billDAL = new BillDAL();
        }

        public void addBill(Bill e)
        {
           billDAL.addBill(e);
        }
        public List<Bill> getAllBill()
        {
            return billDAL.getAllBill();
        }
        public Bill findBill(int id)
        {
            return billDAL.findBill(id);
        }
        public void deleteBill(Bill e)
        {
            billDAL.deleteBill(e);
        }
    }
}
