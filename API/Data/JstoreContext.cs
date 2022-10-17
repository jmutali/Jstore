using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class JstoreContext : DbContext
    {
        public JstoreContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products => Set<Product>();
    }
}
