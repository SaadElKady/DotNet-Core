using FirstProjectV1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProjectV1.Controllers
{
    public class GamesController : Controller
    {
        public IActionResult Index()
        {
            var g1 = new Game() { Name = "The Last of us" };
            var g2 = new Game() { Rating = 10 };
            return View(g1);
            return View(g2);
        }

        public IActionResult Print()
        {
            var g1 = new Game() { Name = "The Last of us" };
            var g2 = new Game() { Rating = 100 };
            g2.ToString();
            return View(g1);
            return View(g2);
        }

        public IActionResult Signup()
        {
            return View();
        }
       
        public IActionResult MainScreen()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }
    }

}
