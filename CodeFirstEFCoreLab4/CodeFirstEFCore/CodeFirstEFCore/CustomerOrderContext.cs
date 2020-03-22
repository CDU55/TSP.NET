using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstEFCore
{
    public class CustomerOrderContext : DbContext
    {

        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\ProjectsV13;Database=CodeFirstEFCore;Trusted_Connection=True");
            //ChangeTracker.LazyLoadingEnabled = false;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasKey(C => C.CustomerId);
            modelBuilder.Entity<Order>().HasKey(O => O.OrderId);
            modelBuilder.Entity<Customer>()
            .HasMany<Order>(c => c.Orders)
            .WithOne(o => o.customer);
        }
    }
}
