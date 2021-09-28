using System;
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

        public async Task<IEnumerable<ApartmentEntity>> GetAllApartmentsAsync(ApartmentRequestEntity requestEntity)
        {
            var apartmentCount = _bookingContext.Apartments.Count();

            var apartments = _bookingContext
                .Apartments
                .Include(a => a.DetailsToApartment)
                .ThenInclude(d => d.Details)
                .AsNoTracking();

            var sortResult = requestEntity.FilterOption switch
            {
                "price" =>  apartments.OrderBy(a => a.Price),
                "all" =>  apartments,
                _ => apartments
            };

             var pageResult = await sortResult.Skip((requestEntity.Page - 1) * requestEntity.PageSize)
                .Take(requestEntity.PageSize)
                .ToListAsync();

             return pageResult;
        }

        public Task<int> GetApartmentsCount()
        {
            var apartmentCount = _bookingContext.Apartments.Count();

            return Task.FromResult(apartmentCount);
        }

    }
}