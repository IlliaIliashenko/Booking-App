using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Booking.BLL.Models.Booking;
using Booking.BLL.Policy;
using Booking.BLL.Services.Booking.Interfaces;
using Booking.DAL.Data.Repositories.Interfaces;
using Booking.Models.Booking;
using Microsoft.AspNetCore.Authorization;

namespace Booking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class ApartmentController : ControllerBase
    {
        private readonly IApartmentPhotoService _photoService;
        private readonly IApartmentService _apartmentService;
        private readonly IMapper _mapper;

        public ApartmentController(
            IApartmentPhotoService photoService, 
            IApartmentService apartmentService, IMapper mapper)
        {
            _photoService = photoService;
            _apartmentService = apartmentService;
            _mapper = mapper;
        }



        [HttpGet("{filterOption}/{page}")]
        public async Task<ActionResult<ResponseModel>> GetAllApartmentsWithPhoto(string filterOption, int page = 1)
        {
            var test = new ApartmentRequestViewModel() {FilterOption = filterOption, Page = page };
            var mappedModel = _mapper.Map<ApartmentRequestDomain>(test);
            var apartmentsDomain = await _apartmentService.GetAllApartmentsAsync(mappedModel);
            var mappedApartments = _mapper.Map<ResponseModel>(apartmentsDomain);

            foreach (var model in mappedApartments.Apartments)
            {
                model.Photos = await _photoService.GetApartmentPhotoPathAsync(model.Id);
            }

            return Ok(mappedApartments);
        }
    }
}
