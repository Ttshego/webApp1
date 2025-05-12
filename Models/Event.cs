using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EventEaseBookingSys.Models;

public class Event
{
    public int EventId { get; set; }

    [Required]
    public string EventName { get; set; }

    [DataType(DataType.DateTime)]
    public DateTime EventDate { get; set; }

    public string Description { get; set; }

    public int? VenueId { get; set; }

    [ForeignKey("VenueId")]
    public Venue? Venue { get; set; }

    public Booking? Booking { get; set; }

    public string? ImageUrl { get; set; }
}
