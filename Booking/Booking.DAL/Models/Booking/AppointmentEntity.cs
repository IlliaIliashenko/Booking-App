using System;

namespace Booking.DAL.Models.Booking
{
    public class AppointmentEntity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool Visited { get; set; }

        public int ApartmentId { get; set; }
        public ApartmentEntity Apartment { get; set; }
    }
}