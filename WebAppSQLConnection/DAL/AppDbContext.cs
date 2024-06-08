using Microsoft.EntityFrameworkCore;
using WebAppSQLConnection.Models;

namespace WebAppSQLConnection.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Group> Group { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
