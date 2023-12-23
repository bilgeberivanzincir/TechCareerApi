using System.Security.Cryptography.X509Certificates;

namespace TechCareer.Models
{
    public class Product
    {
          
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? UnitPrice { get; set; }
        public Category Category { get; set; }
    }
}
