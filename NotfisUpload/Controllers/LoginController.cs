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
        private readonly CadastrarLogin _cadastrarLogin = null;

        public LoginController(CadastrarLogin cadastrarlogin)
        {
            _cadastrarLogin = cadastrarlogin;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AddNewLogin(Usuario usuario)
        {
            _cadastrarLogin.AddNewLogin(usuario);

                return View("~/Home/Index");
        }


        public IActionResult CadastrarLogin()
        {
            //ViewBag.cep = business.cep.Busca("13020320")
            return View();
        }


        public IActionResult RegistrarLogin()
        {
            return View();

        }

        public IActionResult RecuperarLogin()
        {
            return View();
        }


    }
}
