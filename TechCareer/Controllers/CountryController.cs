using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TechCareer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {

        private readonly string[] countries = new string[] {"Turkey", "United States", "Brazil", "Japan", "Germany", "France", "Russia", "China", "India", "Canada",
             "Australia", "United Kingdom", "Italy", "South Korea", "Mexico", "Spain", "Argentina", "South Africa", "Sweden", "Netherlands"};
        [HttpGet]
        public string[] Get() {

            return countries;

        }
        [HttpGet("{id}")]
        public ActionResult GetCountries(int id)
        {
               if(id<0 || id>= countries.Length)
               {
                return BadRequest("Invalid ID");

               }
               else
                {
                return Ok(countries.Take(id).ToArray());
                }
          }

    }
}
