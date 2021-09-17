using AutoMapper;
using Booking.BLL.Models.Authentication;
using Booking.DAL.Models.Authentication;

namespace Booking.BLL.Configuration.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<CreateUserModelDomain, UserEntity>()
                .ForMember(u => u.PasswordHash, opts => opts.MapFrom(u => u.Password))
                .ForMember(u => u.Login, opts => opts.MapFrom(u => u.Email));

        }
    }
}