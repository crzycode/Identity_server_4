using Identity_server_4.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Identity_server_4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoffeeShopController : ControllerBase
    {
        private readonly ICoffeeShopService Coffeeshopservice;
        public CoffeeShopController(ICoffeeShopService _coffee)
        {
            Coffeeshopservice = _coffee;
        }
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var coffeeshop = await Coffeeshopservice.List();
            return Ok(coffeeshop);
        }
    }
}
