using Booking.BLL.Services.Booking.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Booking.BLL.Services.Booking
{
    public class PagingOption : IPagingOption

    {
        private const string PagingOptionSection = nameof(PagingOption);
        private const string PageSizeKey = "PageSize";
        private readonly IConfigurationSection _pagingConfigurationSection;

        public PagingOption(IConfiguration configuration)
        {
            _pagingConfigurationSection = configuration.GetSection(PagingOptionSection);
        }

        public int PageSize => _pagingConfigurationSection.GetValue<int>(PageSizeKey);
    }
}