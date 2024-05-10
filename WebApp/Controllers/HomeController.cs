using Microsoft.AspNetCore.Mvc;


namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        [Route("api/home")]
        public IActionResult Get()
        {
            var value = new { id = 1 };
            return Ok(value);
        }
    }
}
