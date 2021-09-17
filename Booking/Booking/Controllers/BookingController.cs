using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Booking.BLL.Policy;
using Microsoft.AspNetCore.Authorization;

namespace Booking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        [HttpGet]
        [Authorize(Policy = PolicyTypes.Users.View)]
        public ActionResult Index()
        {
            return Ok("from index");
        }
    }
}
