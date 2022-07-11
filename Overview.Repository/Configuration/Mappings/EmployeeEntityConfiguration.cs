using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Overview.Core.Entities;

namespace Overview.Repository.Configuration.Mappings
{
    public class EmployeeEntityConfiguration : BaseEntityConfiguration<Employee>
    {
        public override void Configure(EntityTypeBuilder<Employee> builder)
        {
            base.Configure(builder);
            builder.ToTable("Employees");
            builder.Property(p => p.Name)
                   .IsRequired()
                   .HasMaxLength(250);

            builder.HasOne(p => p.Project)
                   .WithMany(p => p.Employees)
                   .HasForeignKey(p => p.ProjectId);

            builder.HasOne(p => p.Country)
                   .WithMany(p => p.Employees)
                   .HasForeignKey(p => p.CountryId);

            builder.HasOne(p => p.Community)
                   .WithMany(p => p.Employees)
                   .HasForeignKey(p => p.CommunityId);
        }
    }
}
