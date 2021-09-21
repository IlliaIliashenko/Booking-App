namespace Booking.DAL.Models.Booking
{
    public class DetailsToApartmentEntity
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public int DetailsId { get; set; }
        public DetailsEntity Details { get; set; }
        public int ApartmentId { get; set; }
        public ApartmentEntity Apartment { get; set; }
    }
}