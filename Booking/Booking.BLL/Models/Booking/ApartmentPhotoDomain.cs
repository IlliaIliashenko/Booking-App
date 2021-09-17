namespace Booking.BLL.Models.Booking
{
    public class ApartmentPhotoDomain
    {
        public int Id { get; set; }
        public string Path { get; set; }

        public int ApartmentId { get; set; }
        public ApartmentDomain Apartment { get; set; }
    }
}