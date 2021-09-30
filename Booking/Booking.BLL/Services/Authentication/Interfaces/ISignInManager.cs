using System.Security.Claims;
using System.Threading.Tasks;

namespace Booking.BLL.Services.Authentication.Interfaces
{
    public interface ISignInManager
    {
        Task<ClaimsIdentity> GetIdentityAsync(string login, string password);
        Task<ClaimsIdentity> GetIdentityByNameAsync(string login);
    }
}