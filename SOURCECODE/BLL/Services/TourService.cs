using BLL.Interfaces;
using TourManager.DAL.Infrastructure.Interfaces;
using TourManager.DAL.Repositories.Interfaces;
using System.Collections.Generic;
using TourManager.Models;

namespace BLL.Services
{
    public class TourService : ITourService
    {
        private readonly ITourRepository tourRepository;
        private readonly IUnitOfWork unitOfWork;

        public TourService(ITourRepository tourRepository, IUnitOfWork unitOfWork)
        {
            this.tourRepository = tourRepository;
            this.unitOfWork = unitOfWork;
        }

        #region IGadgetService Members

        public IEnumerable<Tour> GetTours()
        {
            var tours = tourRepository.GetAll();
            return tours;
        }

        public Tour GetTour(int id)
        {
            var tour = tourRepository.GetById(id);
            return tour;
        }

        public void CreateTour(Tour tour)
        {
            tourRepository.Add(tour);
        }

        public void SaveTour()
        {
            unitOfWork.Commit();
        }

        #endregion

    }
}
