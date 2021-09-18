namespace Booking.BLL.Models.Booking
{
    public class DetailsToApartmentDomain
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public int DetailsId { get; set; }
        public DetailsDomain Details { get; set; }
        public int ApartmentId { get; set; }
        public ApartmentDomain Apartment { get; set; }
    }
}