using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Booking.BLL.Models;
using Booking.BLL.Models.Booking;
using Booking.DAL.Models.Booking;
using Microsoft.AspNetCore.Routing.Constraints;

namespace Booking.BLL.Configuration.Profiles
{
    public class BookingProfile : Profile
    {
        public BookingProfile()
        {
            CreateMap<AppointmentEntity, ApartmentWithDetailsDomain>();
            CreateMap<ApartmentPhotoEntity, ApartmentPhotoDomain>();
            CreateMap<AppointmentResponseEntity, AppointmentResponseDomain>();
            CreateMap<AppointmentEditDomain, AppointmentEditEntity>();
            CreateMap<ApartmentRequestEntity, ApartmentRequestDomain>().ReverseMap();
            CreateMap<AppointmentCreateDomain, AppointmentCreateEntity>();
            CreateMap<DetailsEntity,DetailsDomain>()
                .ForMember(u => u.DetailsToApartmentDomains, 
                    opts => opts.MapFrom(u => u.DetailsToApartment));
            CreateMap<ApartmentEntity, ApartmentDomain>()
                .ForMember(u => u.DetailsToApartmentDomains, 
                    opts => opts.MapFrom(u => u.DetailsToApartment))
                .ReverseMap();
            CreateMap<DetailsToApartmentEntity, DetailsToApartmentDomain>();
            CreateMap<IEnumerable<ApartmentDomain>, IEnumerable<ApartmentWithDetailsDomain>>().ConvertUsing(
                (src,dest , ctx) =>
                {
                    dest ??= new List<ApartmentWithDetailsDomain>();
                    var details = src.SelectMany(a => a.DetailsToApartmentDomains,
                            (a, d) => new
                            {
                                SingleDetail = new SingleDetailDomain()
                                {
                                    ApartmentId = a.Id,
                                    Type = d.Details.ValueType,
                                    Name = d.Details.Name,
                                    Value = d.Value
                                }
                            })
                        .Select(d => d.SingleDetail);

                    dest = src.Join(details,
                            a => a.Id,
                            d => d.ApartmentId,
                            (a, d) => new ApartmentWithDetailsDomain()
                            {
                                Id = a.Id,
                                Price = a.Price,
                                Name = a.Name,
                                Details = details.Where(d => d.ApartmentId == a.Id).ToDictionary(x => x.Name, x => x.Value)
                            })
                        .GroupBy(a => a.Id)
                        .Select(a => a.FirstOrDefault());

                    return dest;
                });
        }
    }
}