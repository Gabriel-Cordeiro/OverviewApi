
namespace Overview.Core.Entities
{
    public class Employee : BaseEntity
    {
        private Employee()
        {

        }

        public Employee(int id, DateTime createdAt, string name, int countryId, int communityId, int projectId): base(id, createdAt)
        {
            Id = id;
            CreatedAt = createdAt;
            Name = name;
            CountryId = countryId;
            CommunityId = communityId;
            ProjectId = projectId;
            EntityValidation();
        }

        public string Name { get; private set; }

        public int CountryId { get; private set; }

        public int CommunityId { get; private set; }

        public int ProjectId { get; private set; }

        public override void EntityValidation()
        {
            base.EntityValidation();

            if (string.IsNullOrEmpty(Name))
                throw new ArgumentNullException(nameof(Name), "Name is mandatory");

            if (CountryId == 0)
                throw new Exception("CountryId should be greater than 0");

            if (CommunityId == 0)
                throw new Exception("CommunityId should be greater than 0");

            if (ProjectId == 0)
                throw new Exception("ProjectId should be greater than 0");
        }

        #region Relations

        public IList<OverviewEntity> Overviews { get; set; }

        public Project Project { get; set; }

        public Country Country { get; set; }

        public Community Community { get; set; }


        #endregion

    }
}
