using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using Booking.BLL.Models.Authentication;
using Booking.BLL.Services.Authentication.Interfaces;
using Microsoft.IdentityModel.Tokens;

namespace Booking.BLL.Services.Authentication
{
    public class TokenBuilder : ITokenBuilder
    {
        private readonly IAuthOption _authOption;

        public TokenBuilder(IAuthOption authOption)
        {
            _authOption = authOption;
        }

        public AccessAndRefreshTokenDomain GetEncodedToken(ClaimsIdentity identity)
        {
            DateTime utcNow = DateTime.UtcNow;
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            JwtSecurityToken jwt = new JwtSecurityToken(
                issuer: _authOption.Issuer,
                audience:_authOption.Audience,
                notBefore: utcNow,
                claims: identity.Claims,
                expires:utcNow.AddMinutes(_authOption.TokenLifetime),
                signingCredentials: new SigningCredentials(_authOption.SymmetricKey, algorithm:_authOption.Algorithm)
            );

            JwtSecurityToken refresh = new JwtSecurityToken(
                notBefore: utcNow,
                claims: identity.Claims.Where(c=> c.Type == ClaimsIdentity.DefaultNameClaimType),
                expires: utcNow.AddHours(_authOption.TokenLifetimeHours),
                signingCredentials: new SigningCredentials(_authOption.SymmetricKey, algorithm: _authOption.Algorithm)
            );

            string accessToken = jwtHandler.WriteToken(jwt);
            string refreshToken = jwtHandler.WriteToken(refresh);

            return new AccessAndRefreshTokenDomain()
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken
            };
        }
    }
}