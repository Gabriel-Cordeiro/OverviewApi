using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Overview.Core.Entities;

namespace Overview.Repository.Configuration.Mappings
{
    public class OverviewEntityConfiguration : BaseEntityConfiguration<OverviewEntity>
    {
        public override void Configure(EntityTypeBuilder<OverviewEntity> builder)
        {
            base.Configure(builder);
            builder.ToTable("Overviews");
            builder.Property(p => p.Notes).IsRequired().HasMaxLength(150);
            builder.Property(p => p.EmployeeId).IsRequired();
        }
    }
}
