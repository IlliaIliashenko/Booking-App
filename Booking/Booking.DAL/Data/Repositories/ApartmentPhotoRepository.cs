using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Booking.DAL.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Booking.DAL.Data.Repositories
{
    public class ApartmentPhotoRepository : IApartmentPhotoRepository
    {
        private readonly BookingContext _bookingContext;

        public ApartmentPhotoRepository(BookingContext bookingContext)
        {
            _bookingContext = bookingContext;
        }

        public async Task<IEnumerable<string>> GetApartmentPhotoPath(int id)
        {
            var photoPath = await _bookingContext
                .ApartmentPhotos
                .Where(p=>p.ApartmentId==id)
                .AsNoTracking()
                .Select(p=>p.Path)
                .ToListAsync();

            return photoPath;
        }
    }
}