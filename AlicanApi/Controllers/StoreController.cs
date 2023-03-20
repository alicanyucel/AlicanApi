using AlicanApi.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlicanApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IStoreService _storeservice;
        public StoreController(IStoreService storeService)
        {

            _storeservice = storeService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            //

            // getbyname eklenecek
            var stores = _storeservice.GetStores().ToList();


            if (stores == null)
            {
                return BadRequest("dukkanlar listelenemedi");
            }
            else
                return Ok(stores);
        }
    }
}
