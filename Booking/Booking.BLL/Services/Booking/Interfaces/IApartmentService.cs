using System.Collections.Generic;
using System.Threading.Tasks;
using Booking.BLL.Models.Booking;

namespace Booking.BLL.Services.Booking.Interfaces
{
    public interface IApartmentService
    {
        Task<PaginationDomain> GetAllApartmentsAsync(ApartmentRequestDomain requestModel);
    }
}