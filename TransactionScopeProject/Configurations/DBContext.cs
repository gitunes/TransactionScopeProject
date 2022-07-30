using Microsoft.EntityFrameworkCore;
using TransactionScopeProject.Models;

namespace TransactionScopeProject.Configurations
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Stock> Stocks { get; set; }

    }
}
