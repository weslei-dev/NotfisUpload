﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotfisUpload.Entidade
{
    public class Intercambio
    {
        public long Id { get; set; }
        public string Destinatario { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
        public string Documento { get; set; }
        public string CNPJ { get; set; }
        public string IE { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string DataEmbarque { get; set; }
        public string NomeEmpresaEmbarcadora { get; set; }

        public List<NotaFiscal> NotasFiscais { get; set; }
    }
}
