using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Booking.BLL.Models.Booking;
using Booking.BLL.Services.Booking.Interfaces;
using Booking.DAL.Data.Repositories.Interfaces;
using Booking.DAL.Models.Booking;

namespace Booking.BLL.Services.Booking
{
    public class ApartmentService : IApartmentService
    {
        private readonly IApartmentRepository _apartmentRepository;
        private readonly IMapper _mapper;
        private readonly IPagingOption _pagingOption;

        public ApartmentService(
            IApartmentRepository apartmentRepository, 
            IMapper mapper, 
            IPagingOption pagingOption)
        {
            _apartmentRepository = apartmentRepository;
            _mapper = mapper;
            _pagingOption = pagingOption;
        }

        public async Task<PaginationDomain> GetAllApartmentsAsync(ApartmentRequestDomain requestModel)
        {
            requestModel.PageSize = _pagingOption.PageSize;
            var mappedModel = _mapper.Map<ApartmentRequestEntity>(requestModel);

            var apartmentEntities = await _apartmentRepository.GetAllApartmentsAsync(mappedModel);
            var mappedApartments = _mapper.Map<IEnumerable<ApartmentWithDetailsDomain>>(apartmentEntities.ApartmentDetails);

            var count = apartmentEntities.Count;
            var pageModel = new PageDomain(apartmentEntities.Count, requestModel.Page, requestModel.PageSize);

            var paginationModel = new PaginationDomain()
            {
                PageModel = pageModel,
                Apartments = mappedApartments
            };

            return paginationModel;
        }

        public async Task<IEnumerable<ApartmentWithDetailsDomain>> GetApartmentByNameAsync(string name)
        {
            var apartmentEntities = await _apartmentRepository.GetApartmentByNameAsync(name);
            var mappedApartments = _mapper.Map<IEnumerable<ApartmentWithDetailsDomain>>(apartmentEntities);

            return mappedApartments;
        }
    }
}