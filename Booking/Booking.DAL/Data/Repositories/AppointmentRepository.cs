using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Booking.DAL.Data.Repositories.Interfaces;
using Booking.DAL.Models.Booking;
using Microsoft.EntityFrameworkCore;

namespace Booking.DAL.Data.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly BookingContext _bookingContext;

        public AppointmentRepository(BookingContext bookingContext)
        {
            _bookingContext = bookingContext;
        }

        public async Task<IEnumerable<AppointmentEntity>> GetAllAppointmentsAsync()
        {
           var orders = await _bookingContext
               .Appointments
               .AsNoTracking()
               .ToListAsync();

           return orders;
        }

        public async Task CreateAppointmentAsync(int apartmentId)
        {
            var appointment = new AppointmentEntity()
            {
                Visited = false,
                Date = DateTime.UtcNow,
                ApartmentId = apartmentId
            };

            await _bookingContext.Appointments.AddAsync(appointment);
            await _bookingContext.SaveChangesAsync();
        }

        public async Task DeleteAppointmentAsync(int id)
        {
            var order = await _bookingContext.Appointments.FindAsync(id);

            _bookingContext.Appointments.Remove(order);
            await _bookingContext.SaveChangesAsync();
        }

        public async Task EditAppointmentAsync(AppointmentEntity appointment)
        { 
            _bookingContext.Update(appointment);

            await _bookingContext.SaveChangesAsync();
        }
    }
}