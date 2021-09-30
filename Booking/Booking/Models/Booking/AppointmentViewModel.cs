using System;

namespace Booking.Models.Booking
{
    public class AppointmentViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool Visited { get; set; }
        public int ApartmentId { get; set; }
    }
}