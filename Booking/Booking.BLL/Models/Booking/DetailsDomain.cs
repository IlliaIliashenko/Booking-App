using System.Collections.Generic;

namespace Booking.BLL.Models.Booking
{
    public class DetailsDomain
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ValueType { get; set; }

        public IEnumerable<DetailsToApartmentDomain> DetailsToApartmentDomains { get; set; }
    }
}