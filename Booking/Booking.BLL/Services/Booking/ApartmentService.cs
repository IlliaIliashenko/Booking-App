using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Booking.BLL.Models.Booking;
using Booking.BLL.Services.Booking.Interfaces;
using Booking.DAL.Data.Repositories.Interfaces;

namespace Booking.BLL.Services.Booking
{
    public class ApartmentService : IApartmentService
    {
        private readonly IApartmentRepository _apartmentRepository;
        private readonly IMapper _mapper;

        public ApartmentService(
            IApartmentRepository apartmentRepository, 
            IMapper mapper)
        {
            _apartmentRepository = apartmentRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ApartmentDomain>> GetAllApartmentsAsync()
        {
            var apartmentEntities = await _apartmentRepository.GetAllApartmentsAsync();
            var mappedApartments = _mapper.Map<IEnumerable<ApartmentDomain>>(apartmentEntities);

            return mappedApartments;
        }

        public async Task<IEnumerable<ApartmentDomain>> GetApartmentByNameAsync(string name)
        {
            var apartmentEntities = await _apartmentRepository.GetApartmentByNameAsync(name);
            var mappedApartments = _mapper.Map<IEnumerable<ApartmentDomain>>(apartmentEntities);

            return mappedApartments;
        }
    }
}