using System.ComponentModel.DataAnnotations;

namespace TechCareer.Models.ORM
{
    public class WebUser : BaseModel
    {
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public List<Order> Orders { get; set; }

    }
}
