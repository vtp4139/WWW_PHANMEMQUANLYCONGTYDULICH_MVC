using System.Collections.Generic;
using TourManager.Models;

namespace BLL.Interfaces
{
    public interface IFeedbackService
    {
        IEnumerable<Feedback> GetFeedbacks();
        Feedback GetFeedback(int id);
        void CreateFeedback(Feedback feedback);
        void SaveFeedback();
    }
}
