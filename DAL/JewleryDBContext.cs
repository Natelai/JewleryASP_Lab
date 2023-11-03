using DAL.DBTypeConverters;
using DAL.EntityConfiguration;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class JewleryDBContext : DbContext
    {
        public JewleryDBContext(DbContextOptions dbContextOption) : base(dbContextOption)
        { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ApplyConfiguration(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder modelBuilder)
        {
            modelBuilder.Properties<DateOnly>().HaveConversion<DateOnlyConverter>();
            modelBuilder.Properties<TimeOnly>().HaveConversion<TimeOnlyConverter>();
        }

        private void ApplyConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new GoodConfiguration());
            modelBuilder.ApplyConfiguration(new MaterialConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
        }
    }
}