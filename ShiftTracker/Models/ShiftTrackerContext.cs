using Microsoft.EntityFrameworkCore;

namespace ShiftTracker.Models
{
    public class ShiftTrackerContext : DbContext
    {
        public DbSet<Shift> Shifts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=ShiftTrackeDB;Trusted_Connection=True;");
        }
    }
}
