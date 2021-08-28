using HotelListing.Models.Country;

namespace HotelListing.Models.Hotel
{
    public class HotelDto : CreateHotelDto
    {
        public int Id { get; set; }
        public CountryDto Country { get; set; }
    }
}
