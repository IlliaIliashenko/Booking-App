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
            CreateMap<ApartmentWithDetailsEntity, ApartmentWithDetailsDomain>();
            CreateMap<DetailsEntity,DetailsDomain>()
                .ForMember(u => u.DetailsToApartmentDomains, 
                    opts => opts.MapFrom(u => u.DetailsToApartmentEntities));
            CreateMap<ApartmentEntity, ApartmentDomain>()
                .ForMember(u => u.DetailsToApartmentDomains, 
                    opts => opts.MapFrom(u => u.DetailsToApartmentEntities));
            CreateMap<DetailsToApartmentEntity,DetailsToApartmentDomain>()
                .ForMember(u => u.Apartment, 
                    opts => opts.MapFrom(u => u.ApartmentEntity))
                .ForMember(u => u.ApartmentId, 
                    opts => opts.MapFrom(u => u.ApartmentEntityId))
                .ForMember(u => u.Details, 
                    opts => opts.MapFrom(u => u.DetailsEntity))
                .ForMember(u => u.DetailsId, 
                    opts => opts.MapFrom(u => u.DetailsEntityId));
        }
    }
}