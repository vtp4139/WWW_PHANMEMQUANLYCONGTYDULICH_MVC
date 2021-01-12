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

        public void addBill(eBill e)
        {
           billDAL.addBill(e);
        }
        public List<eBill> getAllBill()
        {
            return billDAL.getAllBill();
        }
        public eBill findBill(int id)
        {
            return billDAL.findBill(id);
        }
        public void deleteBill(eBill e)
        {
            billDAL.deleteBill(e);
        }
    }
}
