using System.Collections.Generic;

namespace Booking.BLL.Models.Booking
{
    public class PaginationDomain
    {
        public IEnumerable<ApartmentWithDetailsDomain> Apartments { get; set; }
        public PageDomain PageModel { get; set; }
    }
}