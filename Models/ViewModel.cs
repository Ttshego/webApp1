
namespace EventEaseBookingSys.Models
{

    public class ViewModel
    {
        public int BookingId { get; set; }
        public string EventName { get; set; }
        public string VenueName { get; set; }
        public string Location { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime BookingDate { get; set; }
        public int Capacity { get; set; }
    }
}
