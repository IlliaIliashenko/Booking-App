using Booking.BLL.Services.Booking.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Booking.BLL.Services.Booking
{
    public class BaseUrlOption : IBaseUrlOption
    {
        private const string BaseUrlOptionsSection = nameof(BaseUrlOption);
        private const string BaseUrlKey = "BaseUrl";
        private readonly IConfigurationSection _baseUrlSection;

        public BaseUrlOption(IConfiguration configuration)
        {
            _baseUrlSection = configuration.GetSection(BaseUrlOptionsSection);
        }

        public string BaseUrl => _baseUrlSection.GetValue<string>(BaseUrlKey);
    }
}