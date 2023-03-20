using AlicanApi.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace AlicanApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrierController : ControllerBase
    {

        private readonly ICarrierService _carrierservice;
        public CarrierController(ICarrierService carrierService)
        {

            _carrierservice = carrierService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            //

            // getbyname eklenecek
            var carriers = _carrierservice.GetCarriers().ToList();


            if (carriers == null)
            {
                return BadRequest("kuryeler listelenemedi");
            }
            else
            return Ok(carriers);
        }

    }
}