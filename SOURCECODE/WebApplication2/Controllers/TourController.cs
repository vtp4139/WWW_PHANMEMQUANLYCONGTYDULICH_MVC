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
    public class TourController : Controller
    {
        TourBLL tourBLL = new TourBLL();

        // GET: Tour
        public ActionResult Index()
        {
            ViewBag.error = TempData["Message"];
            return View(tourBLL.getAll());
        }       

        // GET: Tours/Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "tourName,departureDate,numberOfDay,startAddress,price,numSeat,emptySeat,tourType")] Tour tour)
        {
            var fhinh = Request.Files[0];
            var path = Server.MapPath("~/Images/" + fhinh.FileName);
            fhinh.SaveAs(path);

            tour.Picture = fhinh.FileName;

            if (ModelState.IsValid)
            {
                tourBLL.addTour(tour);
                TempData["Message"] = "Thêm tour mới thành công !";
                return RedirectToAction("Index");
            }
            return View(tour);
        }

        // GET: Tours/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tour tour = tourBLL.findTour(id);
            if (tour == null)
            {
                return HttpNotFound();
            }
            return View(tour);
        }

        // POST: Tours/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tour tour = tourBLL.findTour(id);
            tourBLL.deleteTour(tour);
            TempData["Message"] = "Xóa tour thành công !";
            return RedirectToAction("Index");
        }

        // GET: Tours/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tour tour = tourBLL.findTour(id);
            if (tour == null)
            {
                return HttpNotFound();
            }
            return View(tour);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "tourID,tourName,departureDate,numberOfDay,startAddress,price,numSeat,emptySeat,tourType")] Tour tour)
        {
            if (ModelState.IsValid)
            {
                tourBLL.editTour(tour);
                TempData["Message"] = "Cập nhập tour thành công !";
                return RedirectToAction("Index");
            }
            return View(tour);
        }
        // GET: Tours/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tour tour = tourBLL.findTour(id);
            if (tour == null)
            {
                return HttpNotFound();
            }
            return View(tour);
        }
    }
}