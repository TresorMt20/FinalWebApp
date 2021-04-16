using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalWebApp.Controllers
{
    public class HelloBroController : Controller
    {
        public string Lol()
        {
            return "lol guys come on";
        }

        public IActionResult Bro()
        {
            return View();
        }
    }
}
