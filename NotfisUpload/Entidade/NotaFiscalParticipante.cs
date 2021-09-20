﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotfisUpload.Entidade
{
    public class NotaFiscalParticipante
    {
        public string RazaoSocial { get; set; }
        public string CNPJs { get; set; }
        public string InscricaoEstadual { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidades { get; set; }
        public string Ceps { get; set; }
        public string CodigoPostal { get; set; }
        public string Estados { get; set; }
        public string AreaFrete { get; set; }


        public string FreteRazaoSocial { get; set; }
        public string FreteCNPJ { get; set; }
        public string FreteIE{ get; set; }
        public string FreteLogradouro { get; set; }
        public string FreteBairro { get; set; }
        public string FreteCidade { get; set; }
        public string FreteIBGE { get; set; }
        public string FreteCep { get; set; }
        public string FreteEstado { get; set; }
        public string FreteTelefone { get; set; }


        public string OperacaoNotaFiscal { get; set; }
        public string PeriodoDeEntrega { get; set; }
        public string DataInicialEntrega { get; set; }
        public string HoraInicialEnterga { get; set; }
        public string DataFinalEntrega { get; set; }
    }
}
