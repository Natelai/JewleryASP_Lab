using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntityConfiguration
{
    internal sealed class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.HasMany(x => x.Orders)
                 .WithOne(x => x.Client)
                 .HasForeignKey(x => x.ClientId);
        }
    }
}
