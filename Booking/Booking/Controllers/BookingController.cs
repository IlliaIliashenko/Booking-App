using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Booking.BLL.Policy;
using Booking.BLL.Services.Booking.Interfaces;
using Booking.DAL.Data.Repositories.Interfaces;
using Booking.Models.Booking;
using Microsoft.AspNetCore.Authorization;

namespace Booking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IApartmentPhotoService _photoService;
        private readonly IApartmentService _apartmentService;
        private readonly IMapper _mapper;

        public BookingController(
            IApartmentPhotoService photoService, 
            IApartmentService apartmentService, IMapper mapper)
        {
            _photoService = photoService;
            _apartmentService = apartmentService;
            _mapper = mapper;
        }



        [HttpGet]
        [Authorize(Policy = PolicyTypes.Users.View)]
        public async Task<ActionResult<IEnumerable<ApartmentViewModel>>> GetAllApartmentsWithPhoto()
        {
            var apartmentsDomain = await _apartmentService.GetAllApartmentsAsync();
            var mappedApartments = _mapper.Map<IEnumerable<ApartmentViewModel>>(apartmentsDomain);

            foreach (var model in mappedApartments)
            {
                model.Photos = await _photoService.GetApartmentPhotoPathAsync(model.Id);
            }

            return Ok(mappedApartments);
        }
    }
}
