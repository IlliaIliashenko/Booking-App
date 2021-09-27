using System.Collections.Generic;
using System.Threading.Tasks;
using Booking.BLL.Services.Authentication.Interfaces;
using Booking.BLL.Services.Cache.Interfaces;
using Booking.BLL.Extensions;
using Booking.DAL.Models.Booking;
using Microsoft.Extensions.Caching.Distributed;

namespace Booking.BLL.Services.Cache
{
    public class CacheService : ICacheService
    {
        private readonly IDistributedCache _cache;

        public CacheService(
            IDistributedCache cache)
        {
            _cache = cache;
        }

        public async Task<IEnumerable<AppointmentResponseEntity>> GetAppointmentsRecordAsync(string key)
        {
            var record = await _cache.GetRecordAsync<IEnumerable<AppointmentResponseEntity>>(key);

            return record;
        }

        public async Task SetAppointmentsRecordAsync(string key, IEnumerable<AppointmentResponseEntity> appointments)
        {
            await _cache.SetRecordAsync(key, appointments);
        }
    }
}