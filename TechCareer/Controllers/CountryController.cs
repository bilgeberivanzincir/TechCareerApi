using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TechCareer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        [HttpGet]
        public string[] Get(){

            string[] countries = new string[] {"Turkey", "United States", "Brazil", "Japan", "Germany", "France", "Russia", "China", "India", "Canada",
             "Australia", "United Kingdom", "Italy", "South Korea", "Mexico", "Spain", "Argentina", "South Africa", "Sweden", "Netherlands"};
            return countries;
  
        }
    }
}
