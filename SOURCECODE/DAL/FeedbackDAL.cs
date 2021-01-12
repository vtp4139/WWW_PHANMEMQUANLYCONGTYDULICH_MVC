using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FeedbackDAL
    {
        TourContext db;

        public FeedbackDAL()
        {
            db = new TourContext();
        }

        public List<eFeedback> getAllFeedback()
        {
            return db.Feedbacks.ToList();
        }

        public void addFeedback(eFeedback e)
        {
            db.Feedbacks.Add(e);
            db.SaveChanges();
        }

        public eFeedback findFeedback(int id)
        {
            eFeedback fb = db.Feedbacks.Find(id);

            if (fb != null)
                return fb;
            return null;
        }

        public void deleteFeedback(eFeedback e)
        {
            db.Feedbacks.Remove(e);
            db.SaveChanges();
        }
    }
}
