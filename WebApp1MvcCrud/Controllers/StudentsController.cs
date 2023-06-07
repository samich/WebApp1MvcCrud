using Microsoft.AspNetCore.Mvc;
using WebApp1MvcCrud.Data;
using WebApp1MvcCrud.Models;

namespace WebApp1MvcCrud.Controllers
{
    public class StudentsController : Controller
    {

        private StudentDbContext _context;

        public StudentsController(StudentDbContext studentDbContext) 
        { 
            _context = studentDbContext;
        }

        public IActionResult Index()
        {

            List<Student> students = _context.Students.ToList();

            return View(students);
        }
    }
}
