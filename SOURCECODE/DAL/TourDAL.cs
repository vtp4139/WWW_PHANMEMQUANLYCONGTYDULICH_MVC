using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TourDAL
    {
        TourContext db;

        public TourDAL()
        {
            db = new TourContext();
        }

        public List<eTour> getAll()
        {           
            return db.Tours.ToList();
        }

        public List<eTour> getAllTourInLand()
        {
            return db.Tours.Where(p => p.tourType == true).ToList();
        }

        public List<eTour> getAllTourAbroad()
        {
            return db.Tours.Where(p => p.tourType == false).ToList();
        }

        public void addTour(eTour e)
        {
            db.Tours.Add(e);
            db.SaveChanges();
        }
        public void deleteTour(eTour e)
        {
            db.Tours.Remove(e);
            db.SaveChanges();
        }
        public eTour findTour(int id)
        {
            eTour tour = db.Tours.Find(id);
            return tour;
        }
        public void editTour(eTour tour)
        {
            db.Entry(tour).State = EntityState.Modified;
            db.SaveChanges();
        }

        //TÌM KIẾM
        public List<eTour> searchTour(string Start, string price, string date)
        {
            double a = 0;
            double z = 0;
            List<eTour> list = new List<eTour>();

            if(price == "1")
            {
                a = 0;
                z = 2000000;
            }
            else if (price == "2")
            {
                a = 2000000;
                z = 5000000;
            }
            else if (price == "3")
            {
                a = 5000000;
                z = 10000000;
            }
            else if (price == "4")
            {
                a = 2000000;
                z = double.MaxValue;
            }
            // ======= theo noi khoi hanh gia va ngay ==============
            if (Start != "Nơi khởi hành" && price != "Giá tiền" && date != "")
            {
                DateTime dateDe = DateTime.Parse(date);
                list = db.Tours.Where(p => p.startAddress.Contains(Start) && p.price > a && p.price < z && p.departureDate > dateDe).ToList();
            }
            // ========= theo noi khoi hanh va va gia==========================
            else if (Start != "Nơi khởi hành" && price != "Giá tiền" && date == "")
            {
                list = db.Tours.Where(p => p.startAddress.Contains(Start) && p.price > a && p.price < z).ToList();
            }
            // ======= theo noi khoi hanh va ngay khoi hanh ==============
            else if (Start != "Nơi khởi hành" && price == "Giá tiền" && date != "")
            {
                DateTime dateDe = DateTime.Parse(date);
                list = db.Tours.Where(p => p.startAddress.Contains(Start) && p.departureDate > dateDe).ToList();
            }

            //======= theo gia va ngay khoi hanh ======================
            else if (Start == "Nơi khởi hành" && price != "Giá tiền" && date != "")
            {
                DateTime dateDe = DateTime.Parse(date);
                list = db.Tours.Where(p => p.price > a && p.price < z && p.departureDate > dateDe).ToList();
            }
            //=============== theo noi khoi hanh ===============
            else if (Start != "Nơi khởi hành" && price == "Giá tiền" && date == "")
            {
                list = db.Tours.Where(p => p.startAddress.Contains(Start)).ToList();
            }
            // ==== Theo gia ===================
            else if (Start == "Nơi khởi hành" && price != "Giá tiền" && date == "")
            {
                list = db.Tours.Where(p => p.price > a && p.price < z).ToList();
            }
            // == Theoo ngay ======================
            else if (Start == "Nơi khởi hành" && price == "Giá tiền" && date != "")
            {
                DateTime dateDe = DateTime.Parse(date);
                list = db.Tours.Where(p => p.departureDate > dateDe).ToList();
            }           

            return list;
        }
    }
}
