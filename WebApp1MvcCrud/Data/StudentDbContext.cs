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
                    Id = 1,
                    Firstname = "Patricia",
                    Lastname = "White",
                    Age = 18,
                    RegDate = DateTime.Now,
                    Grade = 3.1F
                },
                new Student
                {
                    Id = 2,
                    Firstname = "Alejandra",
                    Lastname = "Ferguson",
                    Age = 21,
                    RegDate = DateTime.Now,
                    Grade = 2.85F
                },
                new Student
                {
                    Id = 3,
                    Firstname = "Bonnie",
                    Lastname = "Kingsley",
                    Age = 22,
                    RegDate = DateTime.Now,
                    Grade = 2.31F
                },
                new Student
                {
                    Id = 4,
                    Firstname = "Michelle",
                    Lastname = "Pate",
                    Age = 17,
                    RegDate = DateTime.Now,
                    Grade = 3.22F
                }, new Student
                {
                    Id = 5,
                    Firstname = "Shirley ",
                    Lastname = "Krug",
                    Age = 24,
                    RegDate = DateTime.Now,
                    Grade = 3.38F
                }
                );
        }
    }
}
