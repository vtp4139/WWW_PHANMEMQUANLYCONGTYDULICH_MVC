using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FeedbackBLL
    {
        FeedbackDAL fbDAL;

        public FeedbackBLL()
        {
            fbDAL = new FeedbackDAL();
        }

        public void addFeedback(eFeedback e)
        {
            fbDAL.addFeedback(e);
        }

        public List<eFeedback> getAllFeedback()
        {
            return fbDAL.getAllFeedback();
        }

        public eFeedback findFeedback(int id)
        {
            return fbDAL.findFeedback(id);
        }

        public void deleteFeedback(eFeedback e)
        {
            fbDAL.deleteFeedback(e);
        }
    }
}
