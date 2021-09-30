using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Booking.BLL.Models.Authentication;
using Booking.BLL.Services.Authentication.Interfaces;
using Booking.Common.Models;
using Booking.DAL.Models.Authentication;
using Microsoft.AspNetCore.Identity;

namespace Booking.BLL.Services.Authentication
{
    public class IdentityUserManager : IUserManager
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly IMapper _mapper;

        public IdentityUserManager(IMapper mapper, UserManager<UserEntity> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }


        public async Task<OperationResult<int>> CreateUser(CreateUserModelDomain createUserModel)
        {
            var userEntity = _mapper.Map<UserEntity>(createUserModel);

            var identityResult = await _userManager.CreateAsync(userEntity, userEntity.PasswordHash);

            if (!identityResult.Succeeded)
            {
                return OperationResult<int>.FromError(identityResult.Errors.FirstOrDefault()?.Description);
            }

            var roleResult = await _userManager.AddToRoleAsync(userEntity, RoleConstants.DefaultUserRole);

            if (!roleResult.Succeeded)
            {
                return OperationResult<int>.FromError(roleResult.Errors.FirstOrDefault()?.Description);
            }

            return OperationResult<int>.FromResult(userEntity.Id);
        }
    }
}