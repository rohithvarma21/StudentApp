using Microsoft.AspNetCore.Mvc;
using StudentCoreDIApp.Models;
using StudentCoreDIApp.Services;
using System.Collections.Generic;

namespace StudentCoreDIApp.Controllers

{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        // DI through constructor
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public IActionResult Index()
        {
            IEnumerable<Student> students = _studentService.GetStudents();
            return View(students);
        }
    }
}
