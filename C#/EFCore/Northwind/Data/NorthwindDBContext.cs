using Microsoft.EntityFrameworkCore;
using Northwind.Models;

namespace Northwind.Data
{
    public class NorthwindDBContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Customer> Customers { set; get; }

        private readonly string _connectionstring;

        public NorthwindDBContext(string connectionString)
        {
            _connectionstring = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionstring);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>()
            .HasKey(od => new { od.OrderID, od.ProductID });
        }
        
    }
}
