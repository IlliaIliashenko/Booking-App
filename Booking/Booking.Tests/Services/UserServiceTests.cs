using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Booking.BLL.Services.Authentication;
using Booking.BLL.Services.Authentication.Interfaces;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Moq;
using Xunit;

namespace Booking.Tests.Services
{
    public class UserServiceTests
    {
        [Fact]
        public void GetCurrentUserId_ShouldReturnStruct()
        {
            //arrange
            var id = "1";
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, id)
            };
            var identity = new ClaimsIdentity(claims);
            var contextUser = new ClaimsPrincipal(identity);

            var httpContextAccessorMock = new Mock<IHttpContextAccessor>();
            httpContextAccessorMock.Setup(x => x.HttpContext.User).Returns(contextUser);
            var userServiceMock = new UserService(httpContextAccessorMock.Object);

            //act

            var result = userServiceMock.GetCurrentUserId().Result;
            //assert

            result.Should().Be(id);
        }
    }
}