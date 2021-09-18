using System.Collections.Generic;

namespace Booking.DAL.Models.Booking
{
    public class ApartmentWithDetailsEntity
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public IDictionary<string,string> Details { get; set; }
    }
}