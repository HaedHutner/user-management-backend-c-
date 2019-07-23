using Microsoft.EntityFrameworkCore;
using UserManagement.Model;

namespace UserManagement.Context
{
    public class ApplicationContext : DbContext
    {
        internal DbSet<User> Users { get; set; }
        internal DbSet<Address> Addresses { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasAlternateKey(user => user.Email).HasName("Email");
        }
    }
}