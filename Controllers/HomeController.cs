using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "This is my message";
            Message msg = new Message()
            {
                content = "This message is the default content that has been provided for the root route"
            };
            return View("Index", msg);
        }
        [Route("numbers")]
        public IActionResult Numbers()
        {
            ViewData["Title"] = "Here are some numbers!";
            Numbers num = new Numbers()
            {
                numList = new List<int> {1,2,3,4,5,6,7,8,9,0}
            };
            return View("Numbers", num);

        }
    }
}
