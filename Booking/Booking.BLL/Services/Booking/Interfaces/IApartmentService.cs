using System.Collections.Generic;
using System.Threading.Tasks;
using Booking.BLL.Models.Booking;

namespace Booking.BLL.Services.Booking.Interfaces
{
    public interface IApartmentService
    {
        Task<IEnumerable<ApartmentDomain>> GetAllApartmentsAsync();
        Task<IEnumerable<ApartmentDomain>> GetApartmentByNameAsync(string name);
    }
}