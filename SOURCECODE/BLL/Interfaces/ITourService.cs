using System.Collections.Generic;
using TourManager.Models;

namespace BLL.Interfaces
{
    public interface ITourService
    {
        IEnumerable<Tour> GetTours();
        Tour GetTour(int id);
        void CreateTour(Tour tour);
        void SaveTour();
    }
}
