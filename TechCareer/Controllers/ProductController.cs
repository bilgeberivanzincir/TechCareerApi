using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechCareer.Models;

namespace TechCareer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public List<Product> products = new List<Product>
        {
            new Product {
                Id = 1,
                Name="Computer",
                UnitPrice=40000,
                Category =new Category {Id=1, Name="Electronic"}},

            new Product {
                Id = 2,
                Name="Dün",
                UnitPrice=100,
                Category= new Category{Id=2, Name="Book"} },

            new Product {
                Id = 3,
                Name="Mouse",
                UnitPrice=600,
                Category =new Category{Id=1, Name="Electronic"}},

            new Product {
                Id = 4,
                Name="Kuzeyli Annem",
                UnitPrice=120,
                Category= new Category{Id=2, Name="Book"} },


        };


        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            if (product == null)
                return NotFound();
            else
                return Ok(product);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            product.Id = products.Count + 1;
            products.Add(product);
            return StatusCode(200, product);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            if (product == null)
                return BadRequest();
            else
            {
                products.Remove(product);
                return Ok(product);
            }
        }
    }
}
