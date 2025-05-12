using Microsoft.EntityFrameworkCore;
using EventEaseBookingSys.Models;

namespace EventEaseBookingSys.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Venue> Venues { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Booking>()
                .HasIndex(b => new { b.EventId, b.VenueId })
                .IsUnique();

        // Map the view to the ViewModel
        modelBuilder
            .Entity<ViewModel>(eb =>
            {
                eb.HasNoKey(); // Since SQL views usually don't have a primary key
                eb.ToView("BookingsView"); // Match the exact SQL view name
            
           } );
    }

}
}
