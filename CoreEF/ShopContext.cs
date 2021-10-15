using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using CoreEF.Configurations;
using CoreEF;

namespace CoreEF
{
    public class ShopContext : DbContext
    {
        public ShopContext() : base() { }   // WCF
        public ShopContext(DbContextOptions<ShopContext> options) : base(options) { }   // ASP.NET CORE

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                string connectionString = "Server=(localdb)\\mssqllocaldb;Database=Shop;Trusted_Connection=true;";
                options.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
        }
    }
}
