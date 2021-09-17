using System;

namespace Booking.BLL.Services.Booking
{
    public class OrderDomain
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int ApartmentId { get; set; }
        public ApartmentDomain Apartment { get; set; }
    }
}