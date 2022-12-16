using BLL.Interfaces;
using TourManager.DAL.Infrastructure.Interfaces;
using TourManager.DAL.Repositories.Interfaces;
using System.Collections.Generic;
using TourManager.Models;

namespace BLL.Services
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IFeedbackRepository feedbackRepository;
        private readonly IUnitOfWork unitOfWork;

        public FeedbackService(IFeedbackRepository feedbackRepository, IUnitOfWork unitOfWork)
        {
            this.feedbackRepository = feedbackRepository;
            this.unitOfWork = unitOfWork;
        }

        #region IGadgetService Members

        public IEnumerable<Feedback> GetFeedbacks()
        {
            var feedbacks = feedbackRepository.GetAll();
            return feedbacks;
        }

        public Feedback GetFeedback(int id)
        {
            var feedback = feedbackRepository.GetById(id);
            return feedback;
        }

        public void CreateFeedback(Feedback feedback)
        {
            feedbackRepository.Add(feedback);
        }

        public void SaveFeedback()
        {
            unitOfWork.Commit();
        }

        #endregion

    }
}
