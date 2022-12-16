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

        public List<Tour> getAll()
        {
            return tourDAL.getAll();
        }

        public void addTour(Tour e)
        {
            tourDAL.addTour(e);
        }
        public void deleteTour(Tour e)
        {
            tourDAL.deleteTour(e);
        }
        public Tour findTour(int id)
        {
            return tourDAL.findTour(id);
        }
        public void editTour(Tour tour)
        {
            tourDAL.editTour(tour);
        }
        public List<Tour> getAllTourInLand()
        {
            return tourDAL.getAllTourInLand();
        }
        public List<Tour> getAllTourAbroad()
        {
            return tourDAL.getAllTourAbroad();
        }
        public List<Tour> searchTour(string Start, string price, string date)
        {
            return tourDAL.searchTour(Start, price, date);
        }
    }
}
