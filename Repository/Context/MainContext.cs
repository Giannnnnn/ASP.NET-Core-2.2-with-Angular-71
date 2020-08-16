using Castle.DynamicProxy.Contributors;
using Domain.Entities;
using Domain.Value_Object;
using Domain.ValueObject;
using Microsoft.EntityFrameworkCore;
using Repository.Config;

namespace Repository.Context
{
    public class MainContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<PaymentOption> PaymentOptions { get; set; }
        public DbSet<Address> Address { get; set; }

        public MainContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //classes de mapeamento
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new OrderItemConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentOptionConfiguration());
            modelBuilder.ApplyConfiguration(new AddressConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}
