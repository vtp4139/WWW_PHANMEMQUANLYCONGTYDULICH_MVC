using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class BillController : Controller
    {
        BillBLL billDLL = new BillBLL();

        public ActionResult Index()
        {
            ViewBag.error = TempData["Message"];
            return View(billDLL.getAllBill());
        }

        //XÓA HÓA ĐƠN
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Bill bill = billDLL.findBill(id);
            if (bill == null)
            {
                return HttpNotFound();
            }
            return View(bill);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bill bill = billDLL.findBill(id);
            billDLL.deleteBill(bill);
            TempData["Message"] = "Xóa hóa đơn thành công !";
            return RedirectToAction("Index");
        }

        //XEM CHI TIẾT HÓA ĐƠN
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bill bill = billDLL.findBill(id);

            if (bill == null)
            {
                return HttpNotFound();
            }
            return View(bill);
        }
    }
}