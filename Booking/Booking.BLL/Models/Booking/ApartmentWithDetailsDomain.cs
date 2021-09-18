using System.Collections.Generic;

namespace Booking.BLL.Models.Booking
{
    public class ApartmentWithDetailsDomain
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        
        public IDictionary<string,string> Details { get; set; }
    }
}