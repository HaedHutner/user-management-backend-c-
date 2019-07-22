using Microsoft.EntityFrameworkCore;
using UserManagement.Model;

namespace UserManagement.Context
{
    public class UserContext : DbContext
    {
        internal DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=users.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}