using System.Collections.Generic;
using System.Linq;
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
        }
    }
}