using System.ComponentModel.DataAnnotations;

namespace Booking.Models
{
    public class LoginUserViewModel
    {
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
    }
}