using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TourBLL
    {
        TourDAL tourDAL;

        public TourBLL()
        {
            tourDAL = new TourDAL();
        }

        public List<eTour> getAll()
        {
            return tourDAL.getAll();
        }

        public void addTour(eTour e)
        {
            tourDAL.addTour(e);
        }
        public void deleteTour(eTour e)
        {
            tourDAL.deleteTour(e);
        }
        public eTour findTour(int id)
        {
            return tourDAL.findTour(id);
        }
        public void editTour(eTour tour)
        {
            tourDAL.editTour(tour);
        }
        public List<eTour> getAllTourInLand()
        {
            return tourDAL.getAllTourInLand();
        }
        public List<eTour> getAllTourAbroad()
        {
            return tourDAL.getAllTourAbroad();
        }
        public List<eTour> searchTour(string Start, string price, string date)
        {
            return tourDAL.searchTour(Start, price, date);
        }
    }
}
