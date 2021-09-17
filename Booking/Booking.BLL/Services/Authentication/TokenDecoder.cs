using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using Booking.BLL.Models.Authentication;
using Booking.BLL.Services.Authentication.Interfaces;

namespace Booking.BLL.Services.Authentication
{
    public class TokenDecoder : ITokenDecoder
    {
        public string DecodeTokenClaim(string refreshToken)
        {
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            JwtSecurityToken jwtSecurityToken = handler.ReadJwtToken(refreshToken);
            string login = jwtSecurityToken.Claims.First(c => c.Type == ClaimsIdentity.DefaultNameClaimType).Value;

            return login;
        }
    }
}