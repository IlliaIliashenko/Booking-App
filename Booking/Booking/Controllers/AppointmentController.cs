using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Booking.BLL.Models;
using Booking.BLL.Models.Booking;
using Booking.BLL.Policy;
using Booking.BLL.Services.Authentication.Interfaces;
using Booking.BLL.Services.Booking.Interfaces;
using Booking.Models;
using Booking.Models.Booking;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Caching.Distributed;

namespace Booking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = PolicyTypes.Users.View)]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;


        public AppointmentController(
            IAppointmentService appointmentService, 
            IMapper mapper, 
            IUserService userService)
        {
            _appointmentService = appointmentService;
            _mapper = mapper;
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppointmentResponseModel>>> GetAllAppointmentsAsync()
        {
            var userId = _userService.GetCurrentUserId().Result;
            var appointments = await _appointmentService.GetAllAppointmentsAsync(userId);
          
            var mappedModel = _mapper.Map<IEnumerable<AppointmentResponseModel>>(appointments);

            return Ok(mappedModel);
        }

        [HttpPost]
        public async Task<ActionResult> CreateAppointmentsAsync(AppointmentCreateModel model)
        {
             var userId = _userService.GetCurrentUserId().Result;
            model.UserId = userId;

            var mappedModel = _mapper.Map<AppointmentCreateDomain>(model);

            await _appointmentService.CreateAppointmentAsync(mappedModel);

            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> EditAppointmentsAsync(AppointmentEditViewModel model)
        {
            var userId = _userService.GetCurrentUserId().Result;
            model.UserId = userId;

            var mappedModel = _mapper.Map<AppointmentEditDomain>(model);

            await _appointmentService.EditAppointmentAsync(mappedModel);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAppointmentsAsync(int id)
        {
            var userId = _userService.GetCurrentUserId().Result;
            await _appointmentService.DeleteAppointmentAsync(new DeleteDomainModel(){Id = id,UserId = userId});

            return Ok();
        }
    }
}
