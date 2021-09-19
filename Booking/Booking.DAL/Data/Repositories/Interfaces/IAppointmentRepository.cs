using System.Collections.Generic;
using System.Threading.Tasks;
using Booking.DAL.Models.Booking;

namespace Booking.DAL.Data.Repositories.Interfaces
{
    public interface IAppointmentRepository
    {
        Task<IEnumerable<AppointmentEntity>> GetAllAppointmentsAsync();
        Task CreateAppointmentAsync(int apartmentId);
        Task DeleteAppointmentAsync(int id);
        Task EditAppointmentAsync(AppointmentEntity appointment);
    }
}