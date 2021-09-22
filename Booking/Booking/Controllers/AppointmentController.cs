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
using Booking.BLL.Services.Booking.Interfaces;
using Booking.Extensions;
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
        private readonly IDistributedCache _cache;
        private readonly string _recordKey = "appointments";

        public AppointmentController(
            IAppointmentService appointmentService, 
            IMapper mapper, 
            IDistributedCache cache)
        {
            _appointmentService = appointmentService;
            _mapper = mapper;
            _cache = cache;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppointmentResponseModel>>> GetAllAppointmentsAsync()
        {
            var appointments = await _cache.GetRecordAsync<IEnumerable<AppointmentResponseDomain>>(_recordKey);
            if (appointments is null)
            {
                appointments = await _appointmentService.GetAllAppointmentsAsync();
                await _cache.SetRecordAsync(_recordKey, appointments);
            }
            var mappedModel = _mapper.Map<IEnumerable<AppointmentResponseModel>>(appointments);

            return Ok(mappedModel);
        }

        [HttpPost("{apartmentId}")]
        public async Task<ActionResult> CreateAppointmentsAsync(int apartmentId)
        {
            await _appointmentService.CreateAppointmentAsync(apartmentId);

            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> EditAppointmentsAsync(AppointmentEditViewModel model)
        {
            var mappedModel = _mapper.Map<AppointmentEditDomain>(model);
            await _appointmentService.EditAppointmentAsync(mappedModel);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAppointmentsAsync(int id)
        {
            await _appointmentService.DeleteAppointmentAsync(id);

            return Ok();
        }
    }
}
