using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Booking.BLL.Configuration.Profiles;
using Booking.BLL.Models.Booking;
using Booking.BLL.Services.Booking;
using Booking.BLL.Services.Cache.Interfaces;
using Booking.DAL.Data.Repositories.Interfaces;
using Booking.DAL.Models.Booking;
using FluentAssertions;
using Moq;
using Xunit;

namespace Booking.Tests.Services
{
    public class AppointmentServiceTests
    {
        private static IMapper _mapper;
        private static Mock<ICacheService> _cacheMock;

        public AppointmentServiceTests()
        {
            if (_mapper != null) return;
            var mappingConfig = new MapperConfiguration(mc => { mc.AddProfile(new BookingProfile()); });
            var mapper = mappingConfig.CreateMapper();
            _mapper = mapper;
            if (_cacheMock != null) return;
            _cacheMock = new Mock<ICacheService>();
        }

        [Fact]
        public async Task GetAllAppointmentsAsync_ShouldReturnCollectionOfAppointmentResponseDomain()
        {
            //arrange
            var listAppointments = new List<AppointmentResponseEntity>();

            var appointmentRepositoryMock = new Mock<IAppointmentRepository>();
            appointmentRepositoryMock.Setup(x => x.GetAllAppointmentsAsync(It.IsAny<int>()))
                .Returns(Task.FromResult<IEnumerable<AppointmentResponseEntity>>(listAppointments));


            var appointmentService = new AppointmentService(_mapper, appointmentRepositoryMock.Object, _cacheMock.Object);

            //act

            var result = await appointmentService.GetAllAppointmentsAsync(It.IsAny<string>());

            //assert

            result.Should().HaveCount(listAppointments.Count);
        }

        [Fact]
        public async Task CreateAppointmentAsync_ShouldReturnNothing()
        {
            //arrange
            var appointment = new AppointmentCreateDomain();
            var appointmentRepositoryMock = new Mock<IAppointmentRepository>();


            var appointmentService = new AppointmentService(_mapper, appointmentRepositoryMock.Object, _cacheMock.Object);

            //act

            await appointmentService.CreateAppointmentAsync(appointment);

            //assert

            appointmentRepositoryMock.Verify(x=>x.CreateAppointmentAsync(It.IsAny<AppointmentCreateEntity>()));
        }

        [Fact]
        public async Task EditAppointmentAsync_ShouldReturnNothing()
        {
            //arrange
            var appointment = new AppointmentEditDomain();
            var appointmentRepositoryMock = new Mock<IAppointmentRepository>();


            var appointmentService = new AppointmentService(_mapper, appointmentRepositoryMock.Object, _cacheMock.Object);

            //act

            await appointmentService.EditAppointmentAsync(appointment);

            //assert

            appointmentRepositoryMock.Verify(x => x.EditAppointmentAsync(It.IsAny<AppointmentEditEntity>()));
        }

        [Fact]
        public async Task DeleteAppointmentAsync_ShouldReturnNothing()
        {
            //arrange
            var id = 111;
            var appointment = new DeleteDomainModel(){Id = id,UserId = "1"};
            var appointmentRepositoryMock = new Mock<IAppointmentRepository>();


            var appointmentService = new AppointmentService(_mapper, appointmentRepositoryMock.Object, _cacheMock.Object);

            //act

            await appointmentService.DeleteAppointmentAsync(appointment);

            //assert

            appointmentRepositoryMock.Verify(x => x.DeleteAppointmentAsync(id));
        }
    }
}