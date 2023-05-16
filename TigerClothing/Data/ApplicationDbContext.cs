using Microsoft.EntityFrameworkCore;
using TigerClothing.Models;

namespace TigerClothing.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get;set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
