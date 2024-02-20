using CustomerDB.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerDB.Utilities
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }

    }
}
