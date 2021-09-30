using System;
using AutoMapper;
using Booking.BLL.Models;
using Booking.BLL.Models.Booking;
using Booking.Models;
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
            CreateMap<AppointmentResponseDomain, AppointmentResponseModel>().ReverseMap();
            CreateMap<AppointmentEditViewModel, AppointmentEditDomain>()
                .ForMember(dest => dest.UserId,
                opt => opt.MapFrom(m => Convert.ToInt32(m.UserId)));
            CreateMap<AppointmentCreateModel, AppointmentCreateDomain>()
                .ForMember(dest =>dest.UserId,
                    opt=>opt.MapFrom(m=>Convert.ToInt32(m.UserId)));
        
        }
        
    }
}