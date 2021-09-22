using Microsoft.AspNetCore.Mvc;
using NotfisUpload.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotfisUpload.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult RegistrarLogin()
        {
            return View();
        }

        public IActionResult CadastrarLogin()
        {
            return View();
        }

        public IActionResult RecuperarLogin()
        {
            return View();
        }


    }
}
