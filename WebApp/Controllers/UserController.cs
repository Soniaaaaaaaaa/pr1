using Core;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("api/user")]
    public class UserController : Controller
    {
        private readonly CoreDbContext context;
        public UserController(CoreDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var list = context.Users.ToList();
            return Ok(list);
        }
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            context.Users.Add(user);
            context.SaveChanges();

            return Created("", user);
        }
    }
}
