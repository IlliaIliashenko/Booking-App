namespace Booking.DAL.Models.Booking
{
    public class ApartmentPhoto
    {
        public int Id { get; set; }
        public string Path { get; set; }

        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
    }
}