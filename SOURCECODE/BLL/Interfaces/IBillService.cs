using System.Collections.Generic;
using TourManager.Models;

namespace BLL.Interfaces
{
    public interface IBillService
    {
        IEnumerable<Bill> GetBills();
        Bill GetBill(int id);
        void CreateBill(Bill bill);
        void SaveBill();
    }
}
