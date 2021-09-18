namespace Booking.DAL.Models.Booking
{
    public class DetailsToApartmentEntity
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public int DetailsEntityId { get; set; }
        public DetailsEntity DetailsEntity { get; set; }
        public int ApartmentEntityId { get; set; }
        public ApartmentEntity ApartmentEntity { get; set; }
    }
}