namespace Booking.DAL.Models.Booking
{
    public class AppointmentResponseEntity
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public bool Visited { get; set; }
        public string Apartment { get; set; }
    }
}