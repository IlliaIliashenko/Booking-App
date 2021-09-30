using System.Collections.Generic;
using System.Threading.Tasks;
using Booking.DAL.Models.Booking;

namespace Booking.BLL.Services.Cache.Interfaces
{
    public interface ICacheService
    {
        Task<IEnumerable<AppointmentResponseEntity>> GetAppointmentsRecordAsync(string key);
        Task SetAppointmentsRecordAsync(string key, IEnumerable<AppointmentResponseEntity> appointments);
    }
}