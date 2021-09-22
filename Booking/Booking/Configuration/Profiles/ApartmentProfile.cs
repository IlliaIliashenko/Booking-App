
using AutoMapper;
using Booking.BLL.Models.Booking;
using Booking.Models.Booking;

namespace Booking.Configuration.Profiles
{
    public class ApartmentProfile : Profile
    {
        public ApartmentProfile()
        {
            CreateMap<ApartmentWithDetailsDomain, ApartmentViewModel>();
            CreateMap<ApartmentRequestViewModel, ApartmentRequestDomain>();
            CreateMap<PageDomain,PageViewModel>();
            CreateMap<PaginationDomain,ResponseModel>();
            CreateMap<AppointmentDomain, AppointmentViewModel>().ReverseMap();
        }
        
    }
}