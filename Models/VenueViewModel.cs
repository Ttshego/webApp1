public class VenueViewModel
{
    public int VenueId { get; set; }

    public string VenueName { get; set; }

    public string Location { get; set; }
    public int Capacity { get; set; }

    public IFormFile ImageFile { get; set; }  // For image upload

    public string? ImageUrl { get; set; }  // URL to store image after upload
}
