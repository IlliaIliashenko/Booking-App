using System;
using System.Text;
using Booking.BLL.Services.Authentication.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Booking.BLL.Services.Authentication
{
    public class AuthOption : IAuthOption
    {

        private const string AuthOptionsSection = nameof(AuthOption);
        private const string IssuerKey = "Issuer";
        private const string AudienceKey = "Audience";
        private const string TokenLifetimeKey = "TokenLifetime";
        private const string TokenLifetimeKeyHours = "TokenLifetimeHours";
        private const string SecretKey = "Secret";
        private const string AlgorithmKey = "Algorithm";
        private readonly IConfigurationSection _authOptionsSection;

        public AuthOption(IConfiguration configuration)
        {
            _authOptionsSection = configuration.GetSection("AuthOptions");
        }

        private string Key => _authOptionsSection.GetValue<string>(SecretKey);

        public string Issuer => _authOptionsSection.GetValue<string>(IssuerKey);
        public string Audience => _authOptionsSection.GetValue<string>(AudienceKey);
        public int TokenLifetime => _authOptionsSection.GetValue<int>(TokenLifetimeKey);
        public int TokenLifetimeHours => _authOptionsSection.GetValue<int>(TokenLifetimeKeyHours);
        public string Algorithm => _authOptionsSection.GetValue<string>(AlgorithmKey);

        public SymmetricSecurityKey SymmetricKey => new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Key));
    }
}