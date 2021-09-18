using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Booking.DAL.Data.Repositories.Interfaces;
using Booking.DAL.Models.Booking;
using Microsoft.EntityFrameworkCore;

namespace Booking.DAL.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly BookingContext _bookingContext;

        public OrderRepository(BookingContext bookingContext)
        {
            _bookingContext = bookingContext;
        }

        public async Task<IEnumerable<AppointmentEntity>> GetAllOrdersAsync()
        {
           var orders = await _bookingContext
               .Appointments
               .AsNoTracking()
               .ToListAsync();

           return orders;
        }

        public async Task CreateOrderAsync(int apartmentId)
        {
            var order = new AppointmentEntity()
            {
                Date = DateTime.UtcNow,
                ApartmentId = apartmentId
            };

            await _bookingContext.Appointments.AddAsync(order);
            await _bookingContext.SaveChangesAsync();
        }

        public async Task DeleteOrderAsync(int Id)
        {
            var order = await _bookingContext.Appointments.FindAsync(Id);

            _bookingContext.Appointments.Remove(order);
            await _bookingContext.SaveChangesAsync();
        }

        public async Task EditOrderAsync(AppointmentEntity order)
        { 
            _bookingContext.Update(order);

            await _bookingContext.SaveChangesAsync();
        }
    }
}