using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NotfisUpload.Entidade;
using NotfisUpload.Models;
using NotfisUpload.Servicos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace NotfisUpload.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataBaseContext _context;

        public HomeController(DataBaseContext context)
        {
            _context = context;
        }

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Informacao()
        {
            return View();
        }

        public async Task<IActionResult> Monitoramento(string Pedido, string ChaveNFE)
        {
            var notas = await _context.NotaFiscals
                .Where(n => n.Pedido.Contains(Pedido ?? string.Empty) && n.ChaveNFE.Contains(ChaveNFE ?? string.Empty))
                                                  .ToListAsync();

            return View(notas);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
