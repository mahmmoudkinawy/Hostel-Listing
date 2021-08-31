using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models.User
{
    public class LoginUserDto
    {

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [MaxLength(15, ErrorMessage = "Must be from 5 to 15 characters")]
        [MinLength(5, ErrorMessage = "Must be from 5 to 15 characters")]
        public string Password { get; set; }
    }
}
