using System;
using System.Collections.Generic;

namespace Booking.DAL.Models.Booking
{
    public class DetailsEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ValueType { get; set; }

        public IEnumerable<DetailsToApartmentEntity> DetailsToApartment { get; set; }
    }
}