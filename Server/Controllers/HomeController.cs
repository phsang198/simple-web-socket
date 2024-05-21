using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Chat.Models;

namespace Chat.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View("InsertUserName");
        }
        
        [HttpPost]
        public IActionResult Index(string username)
        {
            return View("Index", username);
        }
        
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
