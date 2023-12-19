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
            kurs.Title = "AspNet Core kursu";
            kurs.Description = "Güzel bir kurs";

            return View(kurs);// Buraya yazılan kurs objesi , View altındaki index içinde karşılanmalı bu yüzden içine gidip, @model kurs yazılır.
        }
        public IActionResult List()
        {
            var kurslar = new  List<Course>()
            {
                new Course(){ Id = 1, Title= "aspnet kursu", Description = "güzel bir kurs."},
                new Course(){ Id = 2, Title= "php kursu", Description = "güzel bir kurs."},
                new Course(){ Id = 3, Title= "django kursu", Description = "güzel bir kurs."},
                new Course(){ Id = 3, Title= "nodejs kursu", Description = "güzel bir kurs."}


            };

            return View("CourseList", kurslar); // buradaki kursList  , View klasörü altında arayacağı dosya adı .eğer View () içi boş şekline ise bu şekilde o zaman metodun ismi olan List i arayacaktır.
        }
    }
}
