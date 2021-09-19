using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Booking.BLL.Models.Booking;
using Booking.BLL.Services.Booking.Interfaces;
using Booking.Models.Booking;

namespace Booking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;
        private readonly IMapper _mapper;

        public AppointmentController(IAppointmentService appointmentService, IMapper mapper)
        {
            _appointmentService = appointmentService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppointmentViewModel>>> GetAllAppointmentsAsync()
        {
            var domainModels = await _appointmentService.GetAllAppointmentsAsync();
            var mappedModel = _mapper.Map<IEnumerable<AppointmentViewModel>>(domainModels);

            return Ok(mappedModel);
        }

        [HttpPost("{apartmentId}")]
        public async Task<ActionResult> CreateAppointmentsAsync(int apartmentId)
        {
            await _appointmentService.CreateAppointmentAsync(apartmentId);

            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> EditAppointmentsAsync(AppointmentViewModel model)
        {
            var mappedModel = _mapper.Map<AppointmentDomain>(model);
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
