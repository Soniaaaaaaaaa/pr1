using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Core
{
    public class CoreDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public CoreDbContext(DbContextOptions<CoreDbContext> options):base(options) { }
        
    }
}
