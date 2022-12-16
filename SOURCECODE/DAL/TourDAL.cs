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

        public List<Tour> getAll()
        {           
            return db.Tours.ToList();
        }

        public List<Tour> getAllTourInLand()
        {
            return db.Tours.Where(p => p.tourType == true).ToList();
        }

        public List<Tour> getAllTourAbroad()
        {
            return db.Tours.Where(p => p.tourType == false).ToList();
        }

        public void addTour(Tour e)
        {
            db.Tours.Add(e);
            db.SaveChanges();
        }
        public void deleteTour(Tour e)
        {
            db.Tours.Remove(e);
            db.SaveChanges();
        }
        public Tour findTour(int id)
        {
            Tour tour = db.Tours.Find(id);
            return tour;
        }
        public void editTour(Tour tour)
        {
            db.Entry(tour).State = EntityState.Modified;
            db.SaveChanges();
        }

        //TÌM KIẾM
        public List<Tour> searchTour(string Start, string price, string date)
        {
            double a = 0;
            double z = 0;
            List<Tour> list = new List<Tour>();

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
