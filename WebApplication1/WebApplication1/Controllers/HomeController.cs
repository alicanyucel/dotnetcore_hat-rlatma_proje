using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //modeldeki sınıfı kullanmam için nesne örneği almam lazım
            var course = new Course();
            course.Id = 1;
            course.Name = "aspnet core kursu";
            //bilgileri view üzerine gönderiyoruz
            return View(course);
        }
    }
}
