﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Booking.DAL.Models.Booking;

namespace Booking.DAL.Data.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        Task<IEnumerable<OrderEntity>> GetAllOrdersAsync();
        Task CreateOrderAsync(int apartmentId);
        Task DeleteOrderAsync(int Id);
        Task EditOrderAsync(OrderEntity order);
    }
}