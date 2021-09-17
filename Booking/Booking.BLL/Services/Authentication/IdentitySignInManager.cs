using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Booking.BLL.Services.Authentication.Interfaces;
using Booking.DAL.Models.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.VisualBasic;

namespace Booking.BLL.Services.Authentication
{
    public class IdentitySignInManager : ISignInManager
    {
        private readonly SignInManager<UserEntity> _signInManager;
        private readonly RoleManager<RoleEntity> _roleManager;

        public IdentitySignInManager(SignInManager<UserEntity> signInManager, RoleManager<RoleEntity> roleManager)
        {
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public async Task<ClaimsIdentity> GetIdentityAsync(string login, string password)
        {
            SignInResult result = await _signInManager.PasswordSignInAsync(login, password, false, false);

            if (result.Succeeded)
            {
                return await GetIdentityByNameAsync(login);
            }

            return null;
        }

        public async Task<ClaimsIdentity> GetIdentityByNameAsync(string login)
        {
            UserEntity user = await _signInManager.UserManager.FindByNameAsync(login);

            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Login)
            };

            var userRoles = await _signInManager.UserManager.GetRolesAsync(user);

            foreach (var userRole in userRoles)
            {
                claims.Add(new Claim(ClaimsIdentity.DefaultRoleClaimType, userRole));
                var role = await _roleManager.FindByNameAsync(userRole);
                var roleClaims = await  _roleManager.GetClaimsAsync(role);
                foreach (var claim in roleClaims)
                {
                    claims.Add(claim);
                }
            }

            ClaimsIdentity identity = new ClaimsIdentity(
                claims,
                "Token",
                ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);

            return identity;
        }
    }

}