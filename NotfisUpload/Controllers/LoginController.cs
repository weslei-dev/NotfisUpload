using Microsoft.AspNetCore.Mvc;
using NotfisUpload.Entidade;
using NotfisUpload.Models;
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


        public IActionResult RegistraLogin()
        {


            return View();
        }


        public IActionResult CadastrarLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarLogin(Cep cep)
        {
            if (!ModelState.IsValid)
            {
                return View(cep);
            }

            var correios = new Correios.AtendeClienteClient();

            var consulta = correios.consultaCEPAsync(cep.Codigo.Replace("-", "")).Result;

            if (consulta != null)
            {
                ViewBag.Endereco = new Usuario()
                {

                    Endereco = consulta.@return.end,
                    Bairro = consulta.@return.bairro,
                    Cidade = consulta.@return.cidade,
                    Estado = consulta.@return.uf
                };
            }

            return View();
        }



        public IActionResult RecuperarLogin()
        {
            return View();
        }


    }
}
