namespace Booking.DAL.Models.Booking
{
    public class ApartmentDetails
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int Size { get; set; }
        public int Rooms { get; set; }
        public int Floor { get; set; }

        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
    }
}