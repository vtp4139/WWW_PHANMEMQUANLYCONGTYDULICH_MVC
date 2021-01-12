using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BLL;
using Entities;

namespace WebApplication2.Controllers
{
    public class CustomerController : Controller
    {
        CustomerBLL cusBLL = new CustomerBLL();

        // GET: Customer
        public ActionResult Index()
        {
            eCustomer c = cusBLL.GetCustomer(int.Parse(Session["id"].ToString()));
            return View(c);
        }      
        // GET: Tours/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            eCustomer c = cusBLL.GetCustomer(id);
            if (c == null)
            {
                return HttpNotFound();
            }
            return View(c);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "customerID,customerName,IDCard,phone,address")] eCustomer c)
        {
            if (ModelState.IsValid)
            {
                cusBLL.editCustomer(c);
                TempData["Message"] = "Cập nhập thông tin thành công !";
                return RedirectToAction("Index");
            }
            return View(c);
        }

    }
}