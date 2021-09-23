using Microsoft.AspNetCore.Mvc;
using NotfisUpload.Entidade;
using NotfisUpload.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotfisUpload.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public void RegistrarLogin()
        {
            var conta = new Conta();
            conta.Login();
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
