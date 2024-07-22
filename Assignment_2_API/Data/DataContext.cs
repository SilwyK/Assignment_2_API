using Microsoft.EntityFrameworkCore;
using Assignment_2_API.Models;

namespace Assignment_2_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
    }
}
