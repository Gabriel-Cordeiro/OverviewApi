using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Overview.Core.Entities;

namespace Overview.Repository.Configuration.Mappings
{
    public class CountryEntityConfiguration : BaseEntityConfiguration<Country>
    {
        public override void Configure(EntityTypeBuilder<Country> builder)
        {
            base.Configure(builder);
            builder.ToTable("Countries");
            builder.Property(p => p.Name)
                   .IsRequired()
                   .HasMaxLength(150);
        }
    }
}
