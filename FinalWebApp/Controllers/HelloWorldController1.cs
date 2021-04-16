using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalWebApp.Controllers
{
    public class HelloWorldController1 : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public string Index()
        {
            return "This is my default action...";
        }
    }
}
