using System.Collections.Generic;


namespace Booking.BLL.Models.Booking
{
    public class ApartmentDomain
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public IEnumerable<ApartmentPhotoDomain> ApartmentPhotos { get; set; }
        public IEnumerable<AppointmentDomain> Orders { get; set; }
        public IEnumerable<DetailsToApartmentDomain> DetailsToApartmentDomains { get; set; }
    }
}