using AutoMapper;
using Booking.BLL.Models.Authentication;
using Booking.DAL.Models.Authentication;
using Booking.Models;

namespace Booking.Configuration.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<RegisterUserViewModel, CreateUserModelDomain>()
                .ForMember(u => u.UserName, opts => opts.MapFrom(u => u.Email));
        }
    }
}