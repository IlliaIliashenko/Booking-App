using System.Collections.Generic;
using System.Threading.Tasks;
using Booking.BLL.Models;
using Booking.BLL.Models.Booking;

namespace Booking.BLL.Services.Booking.Interfaces
{
    public interface IAppointmentService
    {
        Task<IEnumerable<AppointmentResponseDomain>> GetAllAppointmentsAsync(string userId);
        Task CreateAppointmentAsync(AppointmentCreateDomain model);
        Task DeleteAppointmentAsync(DeleteDomainModel model);
        Task EditAppointmentAsync(AppointmentEditDomain appointment);
    }
}