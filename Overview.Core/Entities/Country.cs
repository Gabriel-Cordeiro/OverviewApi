﻿namespace Overview.Core.Entities
{
    public class Country : BaseEntity
    {
        public Country(int id, DateTime createdAt, string name) : base(id, createdAt)
        {
            Id = id;
            CreatedAt = createdAt;
            Name = name;
            EntityValidation();
        }

        private Country()
        {

        }

        public string Name { get; set; }

        public override void EntityValidation()
        {
            base.EntityValidation();

            if (string.IsNullOrEmpty(Name))
                throw new ArgumentNullException(nameof(Name), "Name is mandatory");
        }


        public ICollection<Employee> Employees { get; set; }

    }
}
