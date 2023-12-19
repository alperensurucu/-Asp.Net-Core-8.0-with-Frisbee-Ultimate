using basics.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace basics.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Contact()
        {
            return View();
        }


        public IActionResult Index()
        {
            return View();
        }
  
        
    }
}
