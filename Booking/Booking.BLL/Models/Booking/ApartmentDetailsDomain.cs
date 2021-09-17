
namespace Booking.BLL.Models.Booking
{
    public class ApartmentDetailsDomain
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int Size { get; set; }
        public int Rooms { get; set; }
        public int Floor { get; set; }

        public int ApartmentId { get; set; }
        public ApartmentDomain Apartment { get; set; }
    }
}