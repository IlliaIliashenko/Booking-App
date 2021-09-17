using System.Collections.Generic;
using System.Threading.Tasks;

namespace Booking.BLL.Services.Booking.Interfaces
{
    public interface IApartmentPhotoService
    {
        Task<IEnumerable<string>> GetApartmentPhotoPath(int id);
    }
}