using MODMAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MODMAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<New> News { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Business> Businesses { get; set; }
    }
}
