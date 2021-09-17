using System.Collections.Generic;
using System.Threading.Tasks;

namespace Booking.DAL.Data.Repositories.Interfaces
{
    public interface IApartmentPhotoRepository
    {
        Task<IEnumerable<string>> GetApartmentPhotoPath(int id);
    }
}