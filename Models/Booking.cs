using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Booking
{
    public int BookingId { get; set; }

    [Required]
    public int EventId { get; set; }

    [Required]
    public int VenueId { get; set; }

    [DataType(DataType.DateTime)]
    public DateTime BookingDate { get; set; }

    [ForeignKey("EventId")]
    public Event? Event { get; set; }

    [ForeignKey("VenueId")]
    public Venue? Venue { get; set; }
}
