using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DAL.EntityConfiguration
{
    internal sealed class GoodConfiguration : IEntityTypeConfiguration<Good>
    {
        public void Configure(EntityTypeBuilder<Good> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.HasOne(x => x.Material)
                .WithMany(x => x.Goods)
                .HasForeignKey(x => x.MaterialId);

            builder.HasMany(x => x.Orders)
                .WithOne(x => x.Good)
                .HasForeignKey(x => x.GoodId);
        }
    }
}
