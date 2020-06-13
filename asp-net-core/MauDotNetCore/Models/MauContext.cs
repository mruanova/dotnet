using Microsoft.EntityFrameworkCore;

namespace MauDotNetCore.Models
{
    public class MauContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MauContext(DbContextOptions options) : base(options) { }

        // "users" table is represented by this DbSet "Users"
        public DbSet<User> Users { get; set; }
        
        // "sessages" table is represented by this DbSet "Messages"
        public DbSet<Message> Messages { get; set; }
    }
}