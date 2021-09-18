using System.Collections.Generic;

namespace Booking.Models.Booking
{
    public class ApartmentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }


        public IDictionary<string,string> Details { get; set; }
        public IEnumerable<string> Photos { get; set; }
    }
}