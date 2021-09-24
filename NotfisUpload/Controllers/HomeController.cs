using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NotfisUpload.Models;
using NotfisUpload.Servicos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NotfisUpload.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //[HttpPost]
        //public IActionResult CadastroLogin(Models.Cep cep)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(cep);
        //    }
        //
        //    var correios = new Conta.AtendeClienteClient();
        //
        //    var consulta = correios.consultaCEPAsync(cep.Codigo.Replace("-", "")).Result;
        //
        //    if (consulta != null)
        //    {
        //        ViewBag.Endereco = new Entidade.Usuario()
        //        {
        //            Complemento = consulta.@return.complemento,
        //            Bairro = consulta.@return.bairro,
        //            Cidade = consulta.@return.cidade,
        //            Estado = consulta.@return.uf
        //        };
        //    }
        //
        //    return View(cep);
        //}


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Informacao()
        {
            return View();
        }
        public IActionResult Monitoramento()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
