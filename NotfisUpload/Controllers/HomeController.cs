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


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Informacao()
        {
            return View();
        }

        public async Task<IActionResult> Monitoramento()
        {
            var chamada = await _context.Intercambio.ToListAsync();

            return View(    );
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
