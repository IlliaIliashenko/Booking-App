using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Booking.DAL.Data.Repositories.Interfaces;
using Booking.DAL.Models.Booking;
using Microsoft.EntityFrameworkCore;

namespace Booking.DAL.Data.Repositories
{
    public class ApartmentRepository : IApartmentRepository
    {
        private readonly BookingContext _bookingContext;

        public ApartmentRepository(BookingContext bookingContext)
        {
            _bookingContext = bookingContext;
        }

        public async Task<IEnumerable<ApartmentEntity>> GetAllApartmentsAsync()
        {
            var apartments = await _bookingContext
                .Apartments
                .Include(a => a.Details)
                .AsNoTracking()
                .ToListAsync();

            return apartments;
        }

        public async Task<IEnumerable<ApartmentEntity>> GetApartmentByNameAsync(string name)
        {
            var apartments = await _bookingContext
                .Apartments
                .Where(ap=>ap.Name.StartsWith(name))
                .Include(a => a.Details)
                .AsNoTracking()
                .ToListAsync();

            return apartments;
        }
    }
}