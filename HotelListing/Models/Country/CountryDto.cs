using HotelListing.Models.Hotel;
using System.Collections.Generic;

namespace HotelListing.Models.Country
{
    public class CountryDto : CreateCountryDto
    {
        public int Id { get; set; }
        public IList<HotelDto> Hotels { get; set; }
    }
}
