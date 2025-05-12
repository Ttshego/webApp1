using Microsoft.EntityFrameworkCore;
using EventEaseBookingSys.Models;

namespace EventEaseBookingSys.Data
{
    public class EventEaseBookingSysDbContext : DbContext
    {
        public EventEaseBookingSysDbContext(DbContextOptions<EventEaseBookingSysDbContext> options)
            : base(options)
        {
        }

        public DbSet<Venue> Venues { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>()
                .HasIndex(b => new { b.VenueId, b.BookingDate })
                .IsUnique(); // Prevent double bookings
        }
    }
}
