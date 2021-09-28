using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Booking.BLL.Configuration.Profiles;
using Booking.BLL.Models.Authentication;
using Booking.BLL.Services.Authentication;
using Booking.Common.Models;
using Booking.DAL.Models.Authentication;
using FluentAssertions;
using Microsoft.AspNetCore.Identity;
using Moq;
using Xunit;

namespace Booking.Tests.Services
{
    public class IdentityUserManagerTests
    {
        private static IMapper _mapper;

        public IdentityUserManagerTests()
        {
            if (_mapper != null) return;
            var mappingConfig = new MapperConfiguration(mc => { mc.AddProfile(new UserProfile()); });
            var mapper = mappingConfig.CreateMapper();
            _mapper = mapper;
        }
        public static Mock<UserManager<UserEntity>> MockUserManager(List<UserEntity> ls)
        {
            var store = new Mock<IUserStore<UserEntity>>();
            var mgr = new Mock<UserManager<UserEntity>>(store.Object, null, null, null, null, null, null, null, null);
            mgr.Object.UserValidators.Add(new UserValidator<UserEntity>());
            mgr.Object.PasswordValidators.Add(new PasswordValidator<UserEntity>());

            mgr.Setup(x => x.CreateAsync(It.IsAny<UserEntity>(), It.IsAny<string>())).ReturnsAsync(IdentityResult.Success).Callback<UserEntity, string>((x, y) => ls.Add(x));
            mgr.Setup(x => x.AddToRoleAsync(It.IsAny<UserEntity>(),It.IsAny<string>())).ReturnsAsync(IdentityResult.Success);

            return mgr;
        }

        [Fact]
        public async Task CreateUser_ShouldReturnStruct()
        {
            //arrange

            var list = new List<UserEntity>();
            var createModel = new CreateUserModelDomain() {UserName = "tomas", Password = "password"};

            var userManagerMock = MockUserManager(list);

            var identityUserManager = new IdentityUserManager(_mapper, userManagerMock.Object);

            //act

            var result = await identityUserManager.CreateUser(createModel);

            //assert

            result.Result.Should().BeOfType(typeof(int));
            //userManagerMock.Verify(x=>x.CreateAsync(It.IsAny<UserEntity>(), createModel.Password));
        }

    }
}