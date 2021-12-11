using NetAngularAuth.Models;
using Microsoft.EntityFrameworkCore;

namespace NetAngularAuth.Data
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { set; get; }
        
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity => { entity.HasIndex(e => e.Email).IsUnique(); });
        }
    }
}
