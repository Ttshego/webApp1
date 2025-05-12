using EventEaseBookingSys.Models;
using Microsoft.EntityFrameworkCore;

namespace EventEaseBookingSys.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
    {
    }

    public DbSet<Venue> Venues { get; set; }
    public DbSet<Event> Event { get; set; } 
}