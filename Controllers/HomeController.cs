using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Models;
using StudentManagementSystem.ViewModels;

namespace StudentManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        public HomeController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public IActionResult Index()
        {
            var students = _studentRepository.GetAllStudents();
            return View(students);
        }

        public IActionResult Details(int id = 1)
        {
            var student = _studentRepository.GetStudent(id);
            var viewmodel = new HomeDetailsViewModel()
            {
                Student = student,
                PageTitle = "Student Details"
            };
            return View(viewmodel);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}