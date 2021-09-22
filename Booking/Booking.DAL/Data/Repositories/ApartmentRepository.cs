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

        public async Task<ApartmentPerPageEntity> GetAllApartmentsAsync(ApartmentRequestEntity requestEntity)
        {
            var apartmentCount = _bookingContext.Apartments.Count();

            var apartments = _bookingContext
                .Apartments
                .Include(a => a.DetailsToApartment)
                .ThenInclude(d => d.Details)
                .AsNoTracking();

            var sortResult = requestEntity.FilterOption switch
            {
                "price" => await apartments
                    .OrderBy(a => a.Price)
                    .Skip((requestEntity.Page - 1) * requestEntity.PageSize)
                    .Take(requestEntity.PageSize)
                    .ToListAsync(),
                "all" => await apartments
                    .Skip((requestEntity.Page - 1) * requestEntity.PageSize)
                    .Take(requestEntity.PageSize)
                    .ToListAsync()
            };

            var detailsEntities = ConvertToModelWithDetails(sortResult);

            var result = new ApartmentPerPageEntity()
            {
                Count = apartmentCount,
                ApartmentDetails = detailsEntities
            };

            return result;
        }

        public async Task<IEnumerable<ApartmentWithDetailsEntity>> GetApartmentByNameAsync(string name)
        {
            var apartments = await _bookingContext
                .Apartments
                .Where(ap=>ap.Name.StartsWith(name))
                .Include(a => a.DetailsToApartment)
                .ThenInclude(d => d.Details)
                .AsNoTracking()
                .ToListAsync();

            var result = ConvertToModelWithDetails(apartments);

            return result;
        }

        private IEnumerable<ApartmentWithDetailsEntity> ConvertToModelWithDetails(
            IEnumerable<ApartmentEntity> apartments)
        {
            var detailsList = apartments.SelectMany(a => a.DetailsToApartment,
                    (a, d) => new
                    {
                        SingleDetail = new SingleDetailEntity()
                        {
                            ApartmentId = a.Id,
                            Type = d.Details.ValueType,
                            Name = d.Details.Name,
                            Value = d.Value
                        }
                    })
                .Select(d => d.SingleDetail);

            var result = apartments.Join(detailsList,
                    a => a.Id,
                    d => d.ApartmentId,
                    (a, d) => new ApartmentWithDetailsEntity()
                    {
                        Id = a.Id,
                        Price = a.Price,
                        Name = a.Name,
                        Details = detailsList.Where(d => d.ApartmentId == a.Id).ToDictionary(x=>x.Name,x=>x.Value)
                    })
                .GroupBy(a => a.Id)
                .Select(a => a.FirstOrDefault());

            return result;
        }
    }
}