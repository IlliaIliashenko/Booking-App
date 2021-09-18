using System.Collections.Generic;
using System.Threading.Tasks;
using Booking.DAL.Models.Booking;

namespace Booking.DAL.Data.Repositories.Interfaces
{
    public interface IApartmentRepository
    {
        Task<IEnumerable<ApartmentWithDetailsEntity>> GetAllApartmentsAsync();
        Task<IEnumerable<ApartmentWithDetailsEntity>> GetApartmentByNameAsync(string name);
    }
}