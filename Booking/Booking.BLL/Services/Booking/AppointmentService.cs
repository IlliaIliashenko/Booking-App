using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Booking.BLL.Models.Booking;
using Booking.BLL.Services.Booking.Interfaces;
using Booking.DAL.Data.Repositories.Interfaces;
using Booking.DAL.Models.Booking;

namespace Booking.BLL.Services.Booking
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IMapper _mapper;

        public AppointmentService( IMapper mapper, IAppointmentRepository appointmentRepository)
        {
            _mapper = mapper;
            _appointmentRepository = appointmentRepository;
        }

        public async Task<IEnumerable<AppointmentDomain>> GetAllAppointmentsAsync()
        {
            var appointmentEntities = await _appointmentRepository.GetAllAppointmentsAsync();
            var mappedAppointments = _mapper.Map<IEnumerable<AppointmentDomain>>(appointmentEntities);

            return mappedAppointments;
        }

        public async Task CreateAppointmentAsync(int apartmentId)
        {
            await _appointmentRepository.CreateAppointmentAsync(apartmentId);
        }

        public async Task DeleteAppointmentAsync(int id)
        {
            await _appointmentRepository.DeleteAppointmentAsync(id);
        }

        public async Task EditAppointmentAsync(AppointmentDomain appointment)
        {
            var appointmentEntity = _mapper.Map<AppointmentEntity>(appointment);
            await _appointmentRepository.EditAppointmentAsync(appointmentEntity);
        }
    }
}