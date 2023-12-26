using Microsoft.AspNetCore.Mvc;

namespace basics.Models
{
    public class Repository 
    {
        private static readonly List<Course>  _courses = new();


        static Repository()
        {
            _courses = new List<Course>()
            {
                new Course(){ Id = 1, Title= "Frizbee Ultimate", Description = "7 ye 7 oynanan bir spor", image = "1.jpg"},
                new Course(){ Id = 2, Title= "Bazen düşersin", Description = "yakalayamadı", image = "2.jpg"},
                new Course(){ Id = 3, Title= "Sonra kalkarsın", Description = "yakalamak için hazır", image = "3.jpg"},
                new Course(){ Id = 3, Title= "Takım arkadaşlarını yüreklendirirsin", Description = "pek işe yaramadı", image = "4.jpg"},
                new Course(){ Id = 3, Title= "Disk okuma", Description = "işe yaradı", image = "3.jpg"}

            };

        }
        
        public static List<Course> Courses 
        {
            get { return _courses; }
        }
    }
}
