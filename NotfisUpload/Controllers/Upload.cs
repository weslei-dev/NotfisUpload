using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotfisUpload.Controllers
{
    public class Upload : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
