using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models.Country
{
    public class CreateCountryDto
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Country Name Is Too Long")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 4, ErrorMessage = "Short Country Name Is Too Long")]
        public string ShortName { get; set; }
    }
}
