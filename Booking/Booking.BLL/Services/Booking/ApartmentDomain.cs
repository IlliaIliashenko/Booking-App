using System.Collections.Generic;

namespace Booking.BLL.Services.Booking
{
    public class ApartmentDomain
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public IEnumerable<ApartmentPhotoDomain> ApartmentPhotos { get; set; }
        public IEnumerable<OrderDomain> Orders { get; set; }
        public ApartmentDetailsDomain Details { get; set; }
    }
}