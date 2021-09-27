using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Booking.BLL.Configuration.Profiles;
using Booking.BLL.Models.Booking;
using Booking.BLL.Services.Booking;
using Booking.BLL.Services.Booking.Interfaces;
using Booking.DAL.Data.Repositories.Interfaces;
using Booking.DAL.Models.Booking;
using FluentAssertions;
using Moq;
using Xunit;

namespace Booking.Tests.Services
{
    public class ApartmentServiceTests
    {
        private static IMapper _mapper;

        public ApartmentServiceTests()
        {
            if (_mapper != null) return;
            var mappingConfig = new MapperConfiguration(mc => { mc.AddProfile(new BookingProfile()); });
            var mapper = mappingConfig.CreateMapper();
            _mapper = mapper;
        }

        [Fact]
        public async Task GetAllApartmentsAsync_ShouldReturnPaginationDomain()
        {
            //arrange
            var apartmentWithDetails = new List<ApartmentWithDetailsEntity>() 
                {
                    new ApartmentWithDetailsEntity(), 
                    new ApartmentWithDetailsEntity()
                };
            var apartmentsPerPage = new ApartmentPerPageEntity(){ApartmentDetails = apartmentWithDetails,Count = 3};
            var pageSize = 3;
            var apartmentRequestDomain = new ApartmentRequestDomain();

            var apartmentRepositoryMock = new Mock<IApartmentRepository>();
            apartmentRepositoryMock.Setup(x => x.GetAllApartmentsAsync(It.IsAny<ApartmentRequestEntity>()))
                .Returns(Task.FromResult<ApartmentPerPageEntity>(apartmentsPerPage));

            var pagingOptionMock = new Mock<IPagingOption>();
            pagingOptionMock.SetupGet(o => o.PageSize).Returns(pageSize);

            var apartmentService = new ApartmentService(apartmentRepositoryMock.Object, _mapper, pagingOptionMock.Object);

            //act

            var result = await apartmentService.GetAllApartmentsAsync(apartmentRequestDomain);

            //assert

            result.Apartments.Should().HaveCount(apartmentWithDetails.Count);
        }
    }
}