using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotfisUpload.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UploadFile.Servicos;

namespace NotfisUpload.Controllers
{
    public class SalvarUploadController : Controller
    {
        private readonly DataBaseContext _context;

        public SalvarUploadController(DataBaseContext context)
        {
            _context = context;
        }



        public IActionResult Index(IFormFile files)
        {
            if (files == null || files.Length <= 0)
                return View();

            var arquivosExistente = _context.Arquivos
                .FirstOrDefault(n => n.Name.Contains(files.FileName ?? string.Empty));

            if (arquivosExistente != null)
            {
                return View();
            }
            else
            {

                var fileName = Path.GetFileName(files.FileName);
                var fileExtension = Path.GetExtension(fileName);
                var newFileName = string.Concat(fileName, fileExtension);
                var filesdto = new Arquivo()
                {
                    Name = newFileName,
                    FileType = fileExtension,
                    Emissao = DateTime.Now
                };

                using (var target = new MemoryStream())
                {
                    files.CopyTo(target);
                    filesdto.DataFiles = target.ToArray();
                }

                var intercambio = new ConversorNotfis().Converter(files);

                _context.Arquivos.Add(filesdto);
                _context.Intercambios.Add(intercambio);
                _context.SaveChanges();

                return View("ShowFile", new Conteudo(Encoding.UTF8.GetString(filesdto.DataFiles)));
            }
        }
    }
}
