using Microsoft.AspNetCore.Mvc;
using Mission4_JoshuaAllen_Team4_3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4_JoshuaAllen_Team4_3.Controllers
{
    public class mission5Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(FormModel model)
        {
            return View();
        }
    }
}
