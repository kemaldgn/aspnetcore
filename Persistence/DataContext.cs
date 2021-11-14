using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(){}

        public DataContext(DbContextOptions options) : base(options)
        {

        }


        public DbSet<Activity> Activties { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("reactivities.db");
        }

    }
}