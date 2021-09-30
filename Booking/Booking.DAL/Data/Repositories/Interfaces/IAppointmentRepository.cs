using System.Collections.Generic;
using System.Threading.Tasks;
using Booking.DAL.Models.Booking;

namespace Booking.DAL.Data.Repositories.Interfaces
{
    public interface IAppointmentRepository
    {
        Task<IEnumerable<AppointmentResponseEntity>> GetAllAppointmentsAsync(int userId);
        Task CreateAppointmentAsync(AppointmentCreateEntity model);
        Task DeleteAppointmentAsync(int id);
        Task EditAppointmentAsync(AppointmentEditEntity appointment);
    }
}