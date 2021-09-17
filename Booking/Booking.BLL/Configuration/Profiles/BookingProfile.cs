using AutoMapper;
using Booking.BLL.Models.Booking;
using Booking.DAL.Models.Booking;

namespace Booking.BLL.Configuration.Profiles
{
    public class BookingProfile : Profile
    {
        public BookingProfile()
        {
            CreateMap<OrderEntity, OrderDomain>();
            CreateMap<ApartmentDetailsEntity, ApartmentDetailsDomain>();
            CreateMap<ApartmentPhotoEntity, ApartmentPhotoDomain>();
            CreateMap<ApartmentEntity, ApartmentDomain>();
        }
    }
}