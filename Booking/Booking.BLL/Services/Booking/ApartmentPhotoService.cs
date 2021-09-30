using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Booking.BLL.Services.Booking.Interfaces;
using Booking.DAL.Data.Repositories.Interfaces;
using Microsoft.AspNetCore.Hosting;

namespace Booking.BLL.Services.Booking
{
    public class ApartmentPhotoService : IApartmentPhotoService
    {
        private readonly IApartmentPhotoRepository _apartmentPhotoRepository;
        private readonly IBaseUrlOption _baseUrlOption;

        public ApartmentPhotoService(
            IApartmentPhotoRepository apartmentPhotoRepository, 
            IBaseUrlOption baseUrlOption)
        {
            _apartmentPhotoRepository = apartmentPhotoRepository;
            _baseUrlOption = baseUrlOption;
        }

        public async Task<IEnumerable<string>> GetApartmentPhotoPathAsync(int id)
        {
            var photoPathOriginal = await _apartmentPhotoRepository.GetApartmentPhotoPath(id);
            var photoPathRelative = photoPathOriginal.Select(p => Path.Combine(_baseUrlOption.BaseUrl, p));

            return photoPathRelative;
        }
    }
}