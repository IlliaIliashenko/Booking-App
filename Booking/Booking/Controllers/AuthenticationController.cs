using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Booking.BLL.Models.Authentication;
using Booking.BLL.Services.Authentication.Interfaces;
using Booking.Common.Models;
using Booking.Models;
using Microsoft.AspNetCore.Authorization;

namespace Booking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUserManager _userManager;
        private readonly ISignInManager _signInManager;
        private readonly ITokenBuilder _tokenBuilder;
        private readonly ITokenDecoder _tokenDecoder;
        private readonly IMapper _mapper;

        public AuthenticationController(
            IUserManager userManager, 
            ISignInManager signInManager, 
            ITokenBuilder tokenBuilder, 
            IMapper mapper, 
            ITokenDecoder tokenDecoder)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenBuilder = tokenBuilder;
            _mapper = mapper;
            _tokenDecoder = tokenDecoder;
        }

        [HttpPost("register")]
        public async Task<ActionResult> RegisterUser([FromBody] RegisterUserViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest("User Registration Failed");

            CreateUserModelDomain userDomain = _mapper.Map<CreateUserModelDomain>(model);

            OperationResult<int> result = await _userManager.CreateUser(userDomain);

            if (!result.IsSuccess)
            {
                return BadRequest(result.ErrorMessage);
            }

            return Ok();

        }

        [HttpPost("login")]
        public async Task<ActionResult<TokenResponseModel>> LogIn([FromBody] LoginUserViewModel loginUserModel)
        {
            if (!ModelState.IsValid)
                return BadRequest("User Login Failed");

            ClaimsIdentity identity = await _signInManager.GetIdentityAsync(loginUserModel.Login, loginUserModel.Password);

            if (identity == null)
            {
                return BadRequest("User with provided credentials not found");
            }

            AccessAndRefreshTokenDomain tokens = _tokenBuilder.GetEncodedToken(identity);
            TokenResponseModel response = new TokenResponseModel()
            {
                AccessToken = tokens.AccessToken,
                RefreshToken = tokens.RefreshToken,
                UserName = loginUserModel.Login
            };

            return Ok(response);
        }

        [HttpPost("refresh")]
        public async Task<ActionResult<TokenResponseModel>> GetRefreshToken([FromBody] TokenResponseModel model)
        {
            string login = _tokenDecoder.DecodeTokenClaim(model.RefreshToken);

            if (login != null)
            {
                ClaimsIdentity identity = await _signInManager.GetIdentityByNameAsync(login);

                AccessAndRefreshTokenDomain tokens = _tokenBuilder.GetEncodedToken(identity);

                TokenResponseModel response = new TokenResponseModel()
                {
                    AccessToken = tokens.AccessToken,
                    RefreshToken = tokens.RefreshToken,
                    UserName = login
                };

                return Ok(response);
            }

            return BadRequest("User Login Failed");
        }


    }
}
