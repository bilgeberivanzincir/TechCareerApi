using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechCareer.Models.ORM;

namespace TechCareer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebUsersController : ControllerBase
    {
        private readonly TechDbContext _context;

        public WebUsersController()
        {
            _context = new TechDbContext();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _context.WebUsers.Include(x => x.Orders);
            return Ok(result);
        }
    }
}
