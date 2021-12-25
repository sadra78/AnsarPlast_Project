using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagement.Domain.BannerAgg;

namespace ShopManagement.Infrastructure.EFCore.Mapping
{
    public class BannerMapping : IEntityTypeConfiguration<Banner>
    {
        public void Configure(EntityTypeBuilder<Banner> builder)
        {
            builder.ToTable("Banners");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Picture).HasMaxLength(1000).IsRequired();
            builder.Property(x => x.PictureAlt).HasMaxLength(500).IsRequired();
            builder.Property(x => x.PictureTitle).HasMaxLength(500).IsRequired();
            builder.Property(x => x.Title).HasMaxLength(500);
            builder.Property(x => x.Text).HasMaxLength(700);
            builder.Property(x => x.BtnText).HasMaxLength(700);
            builder.Property(x => x.Link).HasMaxLength(1000);
        }
    }
}