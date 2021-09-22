using System.Collections.Generic;

namespace Booking.DAL.Models.Booking
{
    public class ApartmentPerPageEntity
    {
        public IEnumerable<ApartmentWithDetailsEntity> ApartmentDetails { get; set; }
        public int Count { get; set; }
    }
}