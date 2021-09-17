using System;

namespace Booking.DAL.Models.Booking
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        
        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
    }
}