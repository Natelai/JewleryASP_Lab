using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DAL.EntityConfiguration
{
    internal sealed class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.HasOne(x => x.Client)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.ClientId);

            builder.HasOne(x => x.Good)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.GoodId);
        }
    }
}
