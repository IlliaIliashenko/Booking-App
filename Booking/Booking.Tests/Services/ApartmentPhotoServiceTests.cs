using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Booking.BLL.Configuration.Profiles;
using Booking.BLL.Services.Booking;
using Booking.BLL.Services.Booking.Interfaces;
using Booking.DAL.Data.Repositories.Interfaces;
using FluentAssertions;
using Moq;
using Xunit;

namespace Booking.Tests.Services
{
    public class ApartmentPhotoServiceTests
    {
       
        [Fact]
        public async Task GetApartmentPhotoPathAsync_ShouldReturnCollectionOfPath()
        {
            //arrange

            var pathList = new List<string>() {"path1","path2","path3"};
            var baseUrl = "baseUrl";

            var apartmentPhotoRepositoryMock = new Mock<IApartmentPhotoRepository>();
            apartmentPhotoRepositoryMock.Setup(x => x.GetApartmentPhotoPath(It.IsAny<int>()))
                .Returns(Task.FromResult<IEnumerable<string>>(pathList));

            var baseUrlOptionMock = new Mock<IBaseUrlOption>();
            baseUrlOptionMock.SetupGet(o => o.BaseUrl).Returns(baseUrl);
            
            var apartmentPhotoService = new ApartmentPhotoService(apartmentPhotoRepositoryMock.Object,baseUrlOptionMock.Object);

            //act

            var result = await apartmentPhotoService.GetApartmentPhotoPathAsync(It.IsAny<int>());

            //assert

            result.Should().HaveCount(pathList.Count);
        }
    }
}