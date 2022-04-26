using Microsoft.EntityFrameworkCore;
using ShoppingStoreAPI.Models;

namespace ShoppingStoreAPI.DATA
{
    public class ShoppingStoreDbContext : DbContext
    {
        public ShoppingStoreDbContext(DbContextOptions<ShoppingStoreDbContext> options) : base(options)
        {

        }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Product> products { get; set; }
    }
}
