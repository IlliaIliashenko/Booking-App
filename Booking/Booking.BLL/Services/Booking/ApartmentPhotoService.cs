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
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IApartmentPhotoRepository _apartmentPhotoRepository;
        private readonly string _baseUrl = "https://localhost:44309/";

        public ApartmentPhotoService(
            IWebHostEnvironment hostingEnvironment, 
            IApartmentPhotoRepository apartmentPhotoRepository)
        {
            _hostingEnvironment = hostingEnvironment;
            _apartmentPhotoRepository = apartmentPhotoRepository;
        }

        public async Task<IEnumerable<string>> GetApartmentPhotoPathAsync(int id)
        {
            var photoPathOriginal = await _apartmentPhotoRepository.GetApartmentPhotoPath(id);

           //var photoPathRelative = photoPathOriginal.Select(p => Path.Combine(_hostingEnvironment.WebRootPath, p));
            var photoPathRelative = photoPathOriginal.Select(p => Path.Combine(_baseUrl, p));

            return photoPathRelative;
        }
    }
}