using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var kurs = new Course();
            kurs.Id = 1;
            kurs.Title = "Frizbee Ultimate";
            kurs.Description = "Çok kural içeren bir takım oyunudur";
            kurs.image = "1.jpg";

            return View(kurs);// Buraya yazılan kurs objesi , View altındaki index içinde karşılanmalı bu yüzden içine gidip, @model kurs yazılır.
        }

        public IActionResult Details()
        {
            var kurs = new Course();
            kurs.Id = 1;
            kurs.Title = "Frizbee Ultimate";
            kurs.Description = "Çok kural içeren bir takım oyunudur";
            kurs.image = "1.jpg";

            return View(kurs);
        }

        public IActionResult List()
        {
            return View("CourseList", Repository.Courses);  //Repository sınıfına alındı . Buradan course listesine ulaşıyoruz.
        }
    }
}
