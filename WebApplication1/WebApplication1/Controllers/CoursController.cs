using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CoursController : Controller
    {
        public ViewResult  Index()
        {
            int hour = DateTime.Now.Hour;
            //viewbag controller üzerinden viewe dinamik veri göndermek için kullanılır//
            ViewBag.hour = hour > 12 ? "good afternoon" : "good morning";
            return View("Index");
        }
        [HttpGet]
        public ViewResult Apply()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Apply(Student student)
        {
            if(ModelState.IsValid)
            {
                Repository.AddStudent(student);
                return View("thanks", student);
            }
            else
            {
                return View();
            }
            //yukarıda post işleminde model binding yapılıyor
            // model binding modeldeki veriler ile benim gondereceğim verilerin eşlenmesi
           
        }
        public ViewResult List()
        {
           var liste= Repository.Students.Where(i=>i.WillAttend==true).ToList();
            
            return View(liste);
        }
    }

}
