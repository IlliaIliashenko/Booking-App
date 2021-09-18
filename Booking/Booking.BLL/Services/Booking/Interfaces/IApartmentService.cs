using System.Collections.Generic;
using System.Threading.Tasks;
using Booking.BLL.Models.Booking;

namespace Booking.BLL.Services.Booking.Interfaces
{
    public interface IApartmentService
    {
        Task<IEnumerable<ApartmentWithDetailsDomain>> GetAllApartmentsAsync();
        Task<IEnumerable<ApartmentWithDetailsDomain>> GetApartmentByNameAsync(string name);
    }
}