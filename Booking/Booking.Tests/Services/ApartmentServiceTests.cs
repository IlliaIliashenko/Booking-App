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
            var detail1 = new DetailsEntity() {Id = 1, Name = "test"};
            var detail2 = new DetailsEntity() {Id = 2, Name = "test2"};

            var detailsToEntity = new DetailsToApartmentEntity() {Details = detail1, Id = 1, Value = "testing"};
            var detailsToEntity2 = new DetailsToApartmentEntity() {Details = detail2, Id = 2, Value = "testing"};

            var apartments = new List<ApartmentEntity>()
                {
                    new ApartmentEntity(){Id=1,DetailsToApartment = new List<DetailsToApartmentEntity>(){detailsToEntity2,detailsToEntity}},
                    new ApartmentEntity(){Id=2,DetailsToApartment = new List<DetailsToApartmentEntity>(){detailsToEntity2,detailsToEntity}},
                };

            var apartmentRequestDomain = new ApartmentRequestDomain();

            var apartmentRepositoryMock = new Mock<IApartmentRepository>();
            apartmentRepositoryMock.Setup(x => x.GetAllApartmentsAsync(It.IsAny<ApartmentRequestEntity>()))
                .Returns(Task.FromResult<IEnumerable<ApartmentEntity>>(apartments));

            var pagingOptionMock = new Mock<IPagingOption>();

            var apartmentService = new ApartmentService(apartmentRepositoryMock.Object, _mapper, pagingOptionMock.Object);

            //act

            var result = await apartmentService.GetAllApartmentsAsync(apartmentRequestDomain);

            //assert

            result.Apartments.Should().HaveCount(apartments.Count);
        }
    }
}