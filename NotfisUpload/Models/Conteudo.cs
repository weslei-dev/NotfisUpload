using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotfisUpload.Models
{
    public class Conteudo
    {
        public Conteudo(string tema)
        {
            Tema = tema;
        }
        public string Tema { get; set; }
    }
}
