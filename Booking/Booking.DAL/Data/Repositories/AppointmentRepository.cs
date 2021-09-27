using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<IEnumerable<AppointmentResponseEntity>> GetAllAppointmentsAsync(int id)
        {
            var orders = await _bookingContext
                .Appointments
                .Where(a=>a.UserId == id)
                .Include(a => a.Apartment)
                .AsNoTracking()
                .Select(a => new AppointmentResponseEntity()
                {
                    Id = a.Id,
                    Apartment = a.Apartment.Name,
                    Date = a.Date.ToString("g"),
                    Visited = a.Visited
                }).ToListAsync();

            return orders;
        }

        public async Task CreateAppointmentAsync(AppointmentCreateEntity model)
        {
            var appointment = new AppointmentEntity()
            {
                Visited = false,
                Date = DateTime.UtcNow,
                ApartmentId = model.ApartmentId,
                UserId = model.UserId
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

        public async Task EditAppointmentAsync(AppointmentEditEntity editAppointment)
        {
            var appointment = await _bookingContext.Appointments.FindAsync(editAppointment.Id);
            appointment.Visited = editAppointment.Visited;
            _bookingContext.Appointments.Update(appointment);

            await _bookingContext.SaveChangesAsync();
        }
    }
}