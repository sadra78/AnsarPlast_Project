using DiscountManagement.Domain.DiscountCodeAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DiscountManagement.Infrastructure.EFCore.Mapping
{
    public class DiscountCodeMapping : IEntityTypeConfiguration<DiscountCode>
    {
        public void Configure(EntityTypeBuilder<DiscountCode> builder)
        {
            builder.ToTable("DiscountCodes");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Reason).HasMaxLength(500);
        }
    }
}