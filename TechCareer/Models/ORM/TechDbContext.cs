using Microsoft.EntityFrameworkCore;

namespace TechCareer.Models.ORM
{
    public class TechDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("Server=LAPTOP-RP5M39N0\\MSSQLSERVER3; Database=TechCareerDb; trusted_connection=true");
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<WebUser> WebUsers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    FirstName = "Bilge Berivan",
                    LastName = "Zincir",
                    Address = "Kadıköy",
                    City = "İstanbul",
                    BirthDate = new DateTime(2001, 11, 15),
                    AddDate = DateTime.Now
                },
                new Employee
                {
                    Id = 2,
                    FirstName = "Aykut",
                    LastName = "Karakuzu",
                    Address = "Beyoğlu",
                    City = "İstanbul",
                    BirthDate = new DateTime(2001, 11, 15),
                    AddDate = DateTime.Now
                },
                new Employee
                {
                    Id = 3,
                    FirstName = "Derin ",
                    LastName = "Çağdaş",
                    Address = "Kadıköy",
                    City = "İstanbul",
                    BirthDate = new DateTime(2000, 03, 09),
                    AddDate = DateTime.Now
                }
            );

            base.OnModelCreating(modelBuilder);
        }




    }
}
