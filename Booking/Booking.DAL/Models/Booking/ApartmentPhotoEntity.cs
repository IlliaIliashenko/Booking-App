namespace Booking.DAL.Models.Booking
{
    public class ApartmentPhotoEntity
    {
        public int Id { get; set; }
        public string Path { get; set; }

        public int ApartmentId { get; set; }
        public ApartmentEntity Apartment { get; set; }
    }
}