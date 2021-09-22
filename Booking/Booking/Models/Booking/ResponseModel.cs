using System.Collections.Generic;


namespace Booking.Models.Booking
{
    public class ResponseModel
    {
        public IEnumerable<ApartmentViewModel> Apartments { get; set; }
        public PageViewModel PageModel { get; set; }
    }
}