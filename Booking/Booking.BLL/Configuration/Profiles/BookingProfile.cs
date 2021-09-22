using AutoMapper;
using Booking.BLL.Models.Booking;
using Booking.DAL.Models.Booking;

namespace Booking.BLL.Configuration.Profiles
{
    public class BookingProfile : Profile
    {
        public BookingProfile()
        {
            CreateMap<AppointmentEntity, AppointmentDomain>().ReverseMap();
            CreateMap<AppointmentEntity, ApartmentWithDetailsDomain>();
            CreateMap<ApartmentPhotoEntity, ApartmentPhotoDomain>();
            CreateMap<ApartmentRequestDomain, ApartmentRequestEntity>();
            CreateMap<ApartmentWithDetailsEntity, ApartmentWithDetailsDomain>();
            CreateMap<DetailsEntity,DetailsDomain>()
                .ForMember(u => u.DetailsToApartmentDomains, 
                    opts => opts.MapFrom(u => u.DetailsToApartment));
            CreateMap<ApartmentEntity, ApartmentDomain>()
                .ForMember(u => u.DetailsToApartmentDomains, 
                    opts => opts.MapFrom(u => u.DetailsToApartment));
            CreateMap<DetailsToApartmentEntity, DetailsToApartmentDomain>();
        }
    }
}