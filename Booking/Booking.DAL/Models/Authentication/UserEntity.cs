using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Booking.DAL.Models.Authentication
{
    public class UserEntity : IdentityUser<int>
    {
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}