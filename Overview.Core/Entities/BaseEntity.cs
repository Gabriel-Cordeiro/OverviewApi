namespace Overview.Core.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {

        }
        protected BaseEntity(int id, DateTime createdAt)
        {
            Id = id;
            CreatedAt = createdAt;
        }

        public virtual int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public virtual void EntityValidation()
        {
            if (Id <= 0)
                throw new Exception("id should be greater than 0");
            
            if(CreatedAt < DateTime.MinValue)
                throw new Exception("CreatedAt should be greater than min value");
        }
    }
}
