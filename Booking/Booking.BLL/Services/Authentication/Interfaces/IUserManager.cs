using System.Threading.Tasks;
using Booking.BLL.Models.Authentication;
using Booking.Common.Models;

namespace Booking.BLL.Services.Authentication.Interfaces
{
    public interface IUserManager
    {
        Task<OperationResult<int>> CreateUser(CreateUserModelDomain user);
    }
}