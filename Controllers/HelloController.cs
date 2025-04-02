using Microsoft.AspNetCore.Mvc;
using MVC1.Models;

namespace MVC1.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            TempData["Location"] = "India";
            return View();
        }

        public IActionResult Student() 
        {
            Student student = new Student
            {
                Id = 1,
                Name = "Test",
                Gender = "Male",
            };

            ViewBag.CurrentDate = DateTime.Now.ToShortDateString();
            ViewData["Title"] = "Mr";
            string? location = Convert.ToString(TempData["Location"]);

            return View(student);
        }
    }
}
