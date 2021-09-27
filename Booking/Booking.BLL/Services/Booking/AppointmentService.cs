using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Booking.BLL.Extensions;
using Booking.BLL.Models;
using Booking.BLL.Models.Booking;
using Booking.BLL.Services.Authentication.Interfaces;
using Booking.BLL.Services.Booking.Interfaces;
using Booking.BLL.Services.Cache.Interfaces;
using Booking.DAL.Data.Repositories.Interfaces;
using Booking.DAL.Models.Booking;
using Microsoft.Extensions.Caching.Distributed;

namespace Booking.BLL.Services.Booking
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IMapper _mapper;
        private readonly ICacheService _cacheService;

        public AppointmentService( 
            IMapper mapper, 
            IAppointmentRepository appointmentRepository,
            ICacheService cacheService)
        {
            _mapper = mapper;
            _appointmentRepository = appointmentRepository;
            _cacheService = cacheService;
        }

        public async Task<IEnumerable<AppointmentResponseDomain>> GetAllAppointmentsAsync(string userId)
        {

            var appointments = await _cacheService.GetAppointmentsRecordAsync(userId)
                               ?? await SetAppointmentRecordAsync(Convert.ToInt32(userId));

            var mappedAppointments = _mapper.Map<IEnumerable<AppointmentResponseDomain>>(appointments);

            return mappedAppointments;
        }

        public async Task CreateAppointmentAsync(AppointmentCreateDomain model)
        {
            var mappedModel = _mapper.Map<AppointmentCreateEntity>(model);

            await _appointmentRepository.CreateAppointmentAsync(mappedModel);
            await SetAppointmentRecordAsync(model.UserId);
        }

        public async Task DeleteAppointmentAsync(DeleteDomainModel model)
        {
            var userId = Convert.ToInt32(model.UserId);

            await _appointmentRepository.DeleteAppointmentAsync(model.Id);
            await SetAppointmentRecordAsync(userId);
        }

        public async Task EditAppointmentAsync(AppointmentEditDomain appointment)
        {
            var appointmentEntity = _mapper.Map<AppointmentEditEntity>(appointment);

            await _appointmentRepository.EditAppointmentAsync(appointmentEntity);
            await SetAppointmentRecordAsync(appointment.UserId);
        }

        private async Task<IEnumerable<AppointmentResponseEntity>> SetAppointmentRecordAsync(int id)
        {
            var appointments = await _appointmentRepository.GetAllAppointmentsAsync(id);

            await _cacheService.SetAppointmentsRecordAsync(id.ToString(), appointments);

            return appointments;
        }
    }
}