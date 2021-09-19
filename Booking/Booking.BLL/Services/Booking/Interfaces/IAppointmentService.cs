using System.Collections.Generic;
using System.Threading.Tasks;
using Booking.BLL.Models.Booking;

namespace Booking.BLL.Services.Booking.Interfaces
{
    public interface IAppointmentService
    {
        Task<IEnumerable<AppointmentDomain>> GetAllAppointmentsAsync();
        Task CreateAppointmentAsync(int apartmentId);
        Task DeleteAppointmentAsync(int id);
        Task EditAppointmentAsync(AppointmentDomain appointment);
    }
}