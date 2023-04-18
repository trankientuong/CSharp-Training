
using Microsoft.AspNetCore.Mvc;
using NETCOREMVC.Models;

namespace NETCOREMVC.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly IStudentRepository _studentRepository;

        public HomeController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        // Action Method Injection in ASP.NET Core Application

        // public JsonResult Index([FromServices] IStudentRepository repository)
        // {
        //     List<Student> allStudentDetails = repository.GetStudents();
        //     return Json(allStudentDetails);
        // }


        // Manually Injection
        // public JsonResult Index(){
        //     var services = this.HttpContext.RequestServices;
        //     var _repository = (IStudentRepository)services.GetService(typeof(IStudentRepository));
        //     List<Student> students = _repository.GetStudents();
        //     return Json(students);
        // }

        public IActionResult Index()
        {
            var students = _studentRepository.GetStudents();
            return View(students);
        }

        // public JsonResult GetStudents()
        // {
        //     var students = _studentRepository.GetStudents();
        //     return Json(students);
        // }

        [Route("Details/{id}")]
        public IActionResult GetStudentDetails(int id)
        {
            var studentDetails = _studentRepository.GetStudentById(id);
            if(studentDetails == null) return NotFound();
            ViewData["Student"] = studentDetails;
            return View("Details");
        }



    }
}