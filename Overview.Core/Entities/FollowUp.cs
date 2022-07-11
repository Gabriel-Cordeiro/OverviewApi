using Overview.Core.Enums;

namespace Overview.Core.Entities
{
    public class FollowUp : BaseEntity
    {

        private FollowUp()
        {

        }

        public FollowUp(int id, int overviewId, FeedbackType feedbackType, FollowUpEvaluation followUpEvaluation, DateTime createdAt) : base(id, createdAt)
        {
            Id = id;
            CreatedAt = createdAt;
            OverviewId = overviewId;
            FeedbackType = feedbackType;
            FollowUpEvaluation = followUpEvaluation;
            EntityValidation();
        }

        public int OverviewId { get; set; }

        public FeedbackType FeedbackType { get; set; }

        public FollowUpEvaluation FollowUpEvaluation { get; set; }

        public override void EntityValidation()
        {
            base.EntityValidation();

            if (OverviewId <= 0)
                throw new Exception("OverviewId should be greater than 0");
        }
    }
}
