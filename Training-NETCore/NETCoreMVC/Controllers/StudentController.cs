using Microsoft.AspNetCore.Mvc;
using NETCOREMVC.Models;
using NETCOREMVC.Models.ViewModels;

namespace NETCOREMVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _repository;

        public StudentController(IStudentRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index(){
            var students = _repository.GetStudents();
            ViewBag.Title = "Student Index";
            ViewBag.Header = "Student List";
            ViewBag.Students = students;
            return View();
        }

        public IActionResult Details(int id){
            //Student Basic Details
            Student student = new Student()
            {
                StudentId = 101,
                Name = "Dillip",
                Branch = "CSE",
                Section = "A",
                Gender = "Male"
            };
            //Student Address
            Address address = new Address()
            {
                StudentId = 101,
                City = "Mumbai",
                State = "Maharashtra",
                Country = "India",
                Pin = "400097"
            };
            //Creating the View model
            StudentDetailsViewModel studentDetailsViewModel = new StudentDetailsViewModel()
            {
                Student = student,
                Address = address,
                Title = "Student Details Page",
                Header = "Student Details",
            };
            //Pass the studentDetailsViewModel to the view
            return View(studentDetailsViewModel);
        }

        public IActionResult Create(){
            return View();
        }

        public IActionResult Edit(){
            return View();
        }

        public IActionResult Delete(){
            return View();
        }
    }
}