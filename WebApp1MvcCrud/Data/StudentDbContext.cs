using Microsoft.EntityFrameworkCore;
using WebApp1MvcCrud.Models;

namespace WebApp1MvcCrud.Data
{
    public class StudentDbContext : DbContext
    {

        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}
