using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechCareer.Models.ORM;

namespace TechCareer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly TechDbContext _context;
        public EmployeeController()
        {
            _context = new TechDbContext();
        }    

        [HttpGet]
        public IActionResult GetAllEmployee()
        {
            var employee = _context.Employees.ToList();
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);

        }
        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            var employee= _context.Employees.FirstOrDefault(x => x.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);

        }
        [HttpPost]
        public IActionResult PostEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return StatusCode(201, employee);

        }
        [HttpPut]
        public IActionResult PutEmployee(int id, Employee employee)
        {
            if (employee == null || id != employee.Id)
            {
                return BadRequest();
            }
            _context.Employees.Update(employee);
            _context.SaveChanges();
            return NoContent(); //204, içerik güncellendi 
        }

        [HttpDelete]
        public IActionResult DeleteEmployee(int id)
        {
            var employee= _context.Employees.FirstOrDefault(x=>x.Id==id);
            if (employee == null)
            {
                return NotFound();
            }
            _context.Employees.Remove(employee);
            _context.SaveChanges();
            return Ok(employee);

        }
      

    }
}
