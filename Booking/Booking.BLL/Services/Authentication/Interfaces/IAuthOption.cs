using Microsoft.IdentityModel.Tokens;

namespace Booking.BLL.Services.Authentication.Interfaces
{
    public interface IAuthOption
    {
        string Issuer { get; }
        string Audience { get; }
        int TokenLifetime { get; }
        int TokenLifetimeHours { get; }
        SymmetricSecurityKey SymmetricKey { get; }
        string Algorithm { get; }
    }
}