using System.Collections.Generic;
using System.Threading.Tasks;
using Booking.BLL.Models;
using Booking.BLL.Models.Booking;

namespace Booking.BLL.Services.Booking.Interfaces
{
    public interface IAppointmentService
    {
        Task<IEnumerable<AppointmentResponseDomain>> GetAllAppointmentsAsync();
        Task CreateAppointmentAsync(int apartmentId);
        Task DeleteAppointmentAsync(int id);
        Task EditAppointmentAsync(AppointmentEditDomain appointment);
    }
}