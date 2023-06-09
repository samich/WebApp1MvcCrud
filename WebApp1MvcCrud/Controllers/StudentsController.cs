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

            Student student = new Student
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Age = request.Age,
                Grade = request.Grade,
                RegDate = DateTime.Now
                
            };

            _context.Students.Add(student);
            _context.SaveChanges();

            return View("Add");
        }

        [HttpGet]
        public IActionResult Edit(Guid Id) 
        {
            var student = _context.Students.FirstOrDefault(x => x.Id == Id);

            if (student != null) {

                var editStudentRequest = new EditStudentRequest
                {

                    Id = student.Id,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    Age = student.Age,
                    Grade = student.Grade
                };

                return View(editStudentRequest);
            }
            
            
            return View();
        }

        [HttpPost]
        public IActionResult Edit(EditStudentRequest request)
        {

            Student student = new Student
            {
                Id  = request.Id,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Age = request.Age,
                Grade = request.Grade
            };

            //fetch existing row from database
            Student? existingStudent = _context.Students.Find(request.Id);

            if (existingStudent != null) {

                existingStudent.FirstName = student.FirstName; 
                existingStudent.LastName = student.LastName;
                existingStudent.Age = student.Age;
                existingStudent.Grade = student.Grade;

                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            
            //if there is no record in db, display error            
            return View("Edit", new { Id = request.Id });
        }
    }

    
}
