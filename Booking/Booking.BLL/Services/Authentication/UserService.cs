using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Booking.BLL.Services.Authentication.Interfaces;
using Booking.Common.Models;
using Microsoft.AspNetCore.Http;

namespace Booking.BLL.Services.Authentication
{
    public class UserService: IUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public OperationResult<string> GetCurrentUserId()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            return OperationResult<string>.FromResult(userId);
        }
    }
}