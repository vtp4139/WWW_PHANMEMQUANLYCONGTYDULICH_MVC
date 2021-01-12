using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        TourBLL tourBLL = new TourBLL();
        CustomerBLL cusBLL = new CustomerBLL();
        AccountBLL accountBLL = new AccountBLL();
        BillBLL billBLL = new BillBLL();
        FeedbackBLL fbBLL = new FeedbackBLL();

        public ActionResult Index()
        {
            return View(tourBLL.getAll());
        }

        public ActionResult TourType(int i)
        {
            Session["TourType"] = i;

            if (i == 1)
            {
                return View(tourBLL.getAllTourInLand());
            }
            else
            {
                return View(tourBLL.getAllTourAbroad());
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }            

        // XỬ LÝ ĐĂNG KÝ TOUR
        public ActionResult CreateBill(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            eCustomer e = new eCustomer();
            e = cusBLL.GetCustomer(int.Parse(Session["id"].ToString()));

            ViewBag.Customer = new eCustomer()
            {
                customerID = e.customerID,
                customerName = e.customerName,
                IDCard = e.IDCard,
                phone = e.phone,
                address = e.address,
            };

            eTour tour = tourBLL.findTour(id);
            Session["tourID"] = tour.tourID;
            if (tour == null)
            {
                return HttpNotFound();
            }
            return View(tour);
        }       

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateBill()
        {
            eBill b = new eBill();

            b.dateCreate = DateTime.Now;
            b.tourID = int.Parse(Session["tourID"].ToString());
            b.customerID = int.Parse(Session["id"].ToString());

            billBLL.addBill(b);

            eTour e = tourBLL.findTour(int.Parse(Session["tourID"].ToString()));
            e.emptySeat--;
            tourBLL.editTour(e);


            ViewBag.checkCreateBill = 1;

            return View();
        }

        //TRANG PHẢN HỒI
        public ActionResult FeedBack()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FeedBack(string title, string content)
        {
            eFeedback e = new eFeedback();

            e.title = title;
            e.content = content;
            e.dateCreate = DateTime.Now;
            e.customerID = int.Parse(Session["id"].ToString());

            fbBLL.addFeedback(e);

            ViewBag.checkFeedback = 1;
            return View();
        }
      
        //CHI TIẾT TOUR
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            eTour tour = tourBLL.findTour(id);
            if (tour == null)
            {
                return HttpNotFound();
            }
            return View(tour);
        }

        [HttpPost]
        public ActionResult Search(FormCollection f)
        {
            List<eTour> lst = tourBLL.searchTour(f["StartAddress"], f["Price"], f["date"]);

            ViewBag.Count = lst.Count;

            return View(lst);
        }

        //THAO TÁC TÀI KHOẢN
        //------------------------------------------------------------------------------------------

        //LOGIN
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(eAccount c)
        {
            if (c.id == "admin" && c.password == "123")
            {
                Session["FullName"] = "admin";
                return RedirectToAction("Index");
            }
            if (ModelState.IsValid)
            {
                eAccount result = accountBLL.IsAccount(c.id, c.password);
                if (result != null)
                {
                    //add session
                    Session["FullName"] = result.Customer.customerName;
                    Session["id"] = result.customerID;

                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.error = "Tên tài khoản hoặc mật khẩu sai !";
                    return View();
                }
            }
            return View();
        }

        //ĐĂNG KÝ
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(FormCollection f)
        {
            eCustomer c = new eCustomer();
            c.customerName = f["cusName"];
            c.IDCard = f["idCard"];
            c.phone = f["phone"];
            c.address = f["Address"];
            cusBLL.addCustomer(c);

            eAccount e = new eAccount();
            e.id = f["idAccount"];
            e.password = f["password"];
            e.customerID = c.customerID;
            accountBLL.addAccount(e);

            ViewBag.checkRegis = 1;

            return View();
        }

        //LOGOUT
        public ActionResult Logout()
        {
            Session.Clear();

            return RedirectToAction("Index");
        }
    }
}