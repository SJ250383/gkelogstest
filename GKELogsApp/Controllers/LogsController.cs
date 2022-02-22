using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp.Controllers
{
    [Route("Logs")]
    public class LogsController : Controller
    {
        
        [Route("")]
        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("LogWork1")]
        public IActionResult LogWork1()
        {
            return View("LogWork1");
        }

        [HttpPost]
        [Route("LogWork2")]
        public IActionResult LogWork2()
        {
            return View("LogWork2");
        }

       
    }
}
