namespace Overview.Core.Entities
{
    public class OverviewEntity : BaseEntity
    {
        private OverviewEntity()
        {

        }

        public OverviewEntity(int id, DateTime createAt, int emploeyeeId, string notes) : base(id, createAt)
        {
            Id = id;
            CreatedAt = createAt;
            EmployeeId = emploeyeeId;
            Notes = notes;
            EntityValidation();
        }

        public int EmployeeId { get; set; }

        public string Notes { get; set; }
       
        public override void EntityValidation()
        {
            base.EntityValidation();

            if (string.IsNullOrEmpty(Notes))
                throw new ArgumentNullException(nameof(Notes), "Notes is mandatory");

            if (EmployeeId <= 0)
                throw new Exception("EmploeyeeId should be greater than 0");
        }

        public virtual ICollection<FollowUp> FollowUp { get; set; }

    }
}
