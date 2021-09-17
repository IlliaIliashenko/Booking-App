using System.Collections.Generic;

namespace Booking.DAL.Models.Booking
{
    public class Apartment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public IEnumerable<ApartmentPhoto> ApartmentPhotos { get;set; }
        public IEnumerable<Order> Orders { get;set; }
        public ApartmentDetails Details { get; set; }
    }
}