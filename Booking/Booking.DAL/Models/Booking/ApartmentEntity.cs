using System.Collections.Generic;

namespace Booking.DAL.Models.Booking
{
    public class ApartmentEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public IEnumerable<ApartmentPhotoEntity> ApartmentPhotos { get;set; }
        public IEnumerable<AppointmentEntity> Appointments { get;set; }
        public IEnumerable<DetailsToApartmentEntity> DetailsToApartment { get; set; }
    }
}