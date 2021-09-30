using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Booking.BLL.Models.Authentication;
using Booking.BLL.Services.Authentication;
using Booking.DAL.Models.Authentication;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Moq;
using Xunit;

namespace Booking.Tests.Services
{
    public class IdentitySignInManagerTests
    {
        public static Mock<SignInManager<UserEntity>> GetSignInManagerMock()
        {
            var mockUserManager = new Mock<UserManager<UserEntity>>(new Mock<IUserStore<UserEntity>>().Object,
                null, null, null, null, null, null, null, null);
            mockUserManager.Setup(x => x.FindByNameAsync(It.IsAny<string>())).ReturnsAsync(new UserEntity(){Login = "111",Id=1});
            mockUserManager.Setup(x => x.GetRolesAsync(It.IsAny<UserEntity>())).ReturnsAsync(new List<string>(){"user","admin"});
            var contextAccessor = new Mock<IHttpContextAccessor>();
            var userPrincipalFactory = new Mock<IUserClaimsPrincipalFactory<UserEntity>>();
            var mockSignInManager = new Mock<SignInManager<UserEntity>>(mockUserManager.Object,
                contextAccessor.Object, userPrincipalFactory.Object, null, null, null,null);
            mockSignInManager.Setup(x => x.PasswordSignInAsync(It.IsAny<string>(), It.IsAny<string>(), false, false)).ReturnsAsync(SignInResult.Success);

            return mockSignInManager;
        }

        public static Mock<RoleManager<RoleEntity>> GetRoleManagerMock()
        {
            var _mockRoleManager = new Mock<RoleManager<RoleEntity>>(new Mock<IRoleStore<RoleEntity>>().Object,null,null,null,null);

            _mockRoleManager.Setup(x => x.GetClaimsAsync(It.IsAny<RoleEntity>())).ReturnsAsync(new List<Claim>());
            _mockRoleManager.Setup(x => x.FindByNameAsync(It.IsAny<string>())).ReturnsAsync(new RoleEntity(){Name = "user"});

            return _mockRoleManager;
        }


        [Fact]
        public async Task GetIdentityAsync_ShouldReturnClaimIdentity()
        {
            //arrange
            
            var useRoleManagerMock = GetRoleManagerMock();
            var userSignInManagerMock = GetSignInManagerMock();

            var identitySignInManager = new IdentitySignInManager(userSignInManagerMock.Object, useRoleManagerMock.Object);

            //act

            var result = await identitySignInManager.GetIdentityAsync(It.IsAny<string>(), It.IsAny<string>());

            //assert

            userSignInManagerMock.Verify(x=>x.PasswordSignInAsync(It.IsAny<string>(), It.IsAny<string>(), false, false));
            //userManagerMock.Verify(x=>x.CreateAsync(It.IsAny<UserEntity>(), createModel.Password));
        }
    }
}