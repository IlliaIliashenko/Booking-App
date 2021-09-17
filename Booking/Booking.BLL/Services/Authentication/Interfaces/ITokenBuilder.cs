using System.Security.Claims;
using Booking.BLL.Models.Authentication;

namespace Booking.BLL.Services.Authentication.Interfaces
{
    public interface ITokenBuilder
    {
        AccessAndRefreshTokenDomain GetEncodedToken(ClaimsIdentity identity);
    }
}