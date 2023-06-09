using Microsoft.EntityFrameworkCore;
using WebApp1MvcCrud.Models;

namespace WebApp1MvcCrud.Data
{
    public class StudentDbContext : DbContext
    {

        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                
                new Student 
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Patricia",
                    LastName = "White",
                    Age = 18,
                    RegDate = DateTime.Now,
                    Grade = 3.1F
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Alejandra",
                    LastName = "Ferguson",
                    Age = 21,
                    RegDate = DateTime.Now,
                    Grade = 2.85F
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Bonnie",
                    LastName = "Kingsley",
                    Age = 22,
                    RegDate = DateTime.Now,
                    Grade = 2.31F
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Michelle",
                    LastName = "Pate",
                    Age = 17,
                    RegDate = DateTime.Now,
                    Grade = 3.22F
                }, new Student
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Shirley ",
                    LastName = "Krug",
                    Age = 24,
                    RegDate = DateTime.Now,
                    Grade = 3.38F
                }
                );
        }
    }
}
