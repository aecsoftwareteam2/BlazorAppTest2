using Microsoft.EntityFrameworkCore;
using BlazorAppTest2.Models;

namespace BlazorAppTest2.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Customer> Customers => Set<Customer>();
    }
}
