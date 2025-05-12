
namespace EventEaseBookingSys.Models
{
    public class EventViewModel
    {
        // Event Properties
        public int EventId { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string Description { get; set; }
        public int VenueId { get; set; }
        public string? ImageUrl { get; set; }  // Image URL from Azure Blob Storage

        // For Image Upload
        public IFormFile? ImageFile { get; set; }  // This will be used to upload the image
    }
}
