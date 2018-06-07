using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StringLocalizerFactoryCreateDemo.Models;

namespace StringLocalizerFactoryCreateDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SomeAction()
        {
            return View(new SomeModel());
        }

        public IActionResult AnotherAction()
        {
            return View(new SomeModel());
        }
    }
}
