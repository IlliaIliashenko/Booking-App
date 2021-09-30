namespace Booking.BLL.Models.Booking
{
    public class AppointmentResponseDomain
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public bool Visited { get; set; }
        public string Apartment { get; set; }
    }
}