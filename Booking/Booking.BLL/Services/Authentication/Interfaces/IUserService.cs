using System.Threading.Tasks;
using Booking.Common.Models;

namespace Booking.BLL.Services.Authentication.Interfaces
{
    public interface IUserService
    {
        OperationResult<string> GetCurrentUserId();
    }
}