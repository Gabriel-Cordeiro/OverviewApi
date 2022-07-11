using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Overview.Core.Entities;

namespace Overview.Repository.Configuration.Mappings
{
    public class CommunityEntityConfiguration : BaseEntityConfiguration<Community>
    {
        public override void Configure(EntityTypeBuilder<Community> builder)
        {
            base.Configure(builder);
            builder.ToTable("Communities");
            builder.Property(p => p.Name)
                   .IsRequired()
                   .HasMaxLength(150);

        }
    }
}
