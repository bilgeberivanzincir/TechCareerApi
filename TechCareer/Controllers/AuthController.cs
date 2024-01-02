using Microsoft.AspNetCore.Mvc;
using TechCareer.Models.Auth;
using TechCareer.Models.DTO;
using TechCareer.Models.ORM;

namespace TechCareer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        TechDbContext db;
        public AuthController()
        {
           db = new TechDbContext();
        }
    

        [HttpPost]
        public IActionResult Login(LoginRequestModel model)
        {
            var user = db.WebUsers.FirstOrDefault(q => q.Email == model.Email && q.Password == model.Password);

            if (user != null)
            {
                TechCareerTokenHandler tokenHandler = new TechCareerTokenHandler();
                var token = tokenHandler.CreateAccessToken(user.Email);

                return Ok(token);
            }
            else
            {
                return BadRequest("Kullanıcı adı veya şifre hatalı");
            }
        }
    }
}
