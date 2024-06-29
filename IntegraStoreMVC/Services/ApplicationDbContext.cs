using IntegraStoreMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace IntegraStoreMVC.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
    }
}
