namespace TechCareer.Models.ORM
{
    public class Order : BaseModel
    {
        public int OrderNumber { get; set; }
        public float TotalPrice { get; set; }
        public List<WebUser> WebUsers { get; set; }
    }
}
