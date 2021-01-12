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
    public class FeedbackController : Controller
    {
        FeedbackBLL fb = new FeedbackBLL();

        public ActionResult Index()
        {
            ViewBag.error = TempData["Message"];
            return View(fb.getAllFeedback());
        }

        //XÓA HÓA ĐƠN
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            eFeedback e = fb.findFeedback(id);
            if (e == null)
            {
                return HttpNotFound();
            }
            return View(e);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            eFeedback e = fb.findFeedback(id);
            fb.deleteFeedback(e);
            TempData["Message"] = "Xóa phản hồi thành công !";
            return RedirectToAction("Index");
        }

        //XEM CHI TIẾT HÓA ĐƠN
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            eFeedback e = fb.findFeedback(id);

            if (e == null)
            {
                return HttpNotFound();
            }
            return View(e);
        }
    }
}