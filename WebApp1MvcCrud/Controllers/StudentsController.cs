using Microsoft.AspNetCore.Mvc;
using WebApp1MvcCrud.Data;
using WebApp1MvcCrud.Models;
using WebApp1MvcCrud.Models.ViewModels;

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

        [HttpGet]
        public IActionResult Add()
        {

            ViewBag.asd = "Viewbag data";
            return View();
        }

        [HttpPost]
        [ActionName("Add")]
        public IActionResult SubmitForm(AddStudentRequest request)
        {

            var firstName = request.FirstName;
            var lastName = request.LastName;

            return View("Add");
        }
    }
}
