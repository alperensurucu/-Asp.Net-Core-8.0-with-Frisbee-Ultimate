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
        public IActionResult List()
        {
            var kurslar = new  List<Course>()  // Şu anki modelimiz bir list . 
            {
                new Course(){ Id = 1, Title= "Frizbee Ultimate", Description = "7 ye 7 oynanan bir spor", image = "1.jpg"},
                new Course(){ Id = 2, Title= "Bazen düşersin", Description = "yakalayamadı", image = "2.jpg"},
                new Course(){ Id = 3, Title= "Sonra kalkarsın", Description = "yakalamak için hazır", image = "3.jpg"},
                new Course(){ Id = 3, Title= "Takım arkadaşlarını yüreklendirirsin", Description = "pek işe yaramadı", image = "4.jpg"}


            };

            return View("CourseList", kurslar); // buradaki kursList  , View klasörü altında arayacağı dosya adı .eğer View () içi boş şekline ise bu şekilde o zaman metodun ismi olan List i arayacaktır.
        }
    }
}
