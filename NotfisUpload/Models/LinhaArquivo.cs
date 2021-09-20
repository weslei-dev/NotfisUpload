using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotfisUpload.Models
{
    public class LinhaArquivo
    {

        public LinhaArquivo(string linha, string identificador)
        {
            Linha = linha;
            Identificador = identificador;
        }

        public string Linha { get; set; }
        public string Identificador { get; set; }

    }
}
