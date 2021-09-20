using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotfisUpload.Entidade
{
    public class NotaFiscal
    {
        public int Id { get; set; }
        public string ChaveNFE { get; set; }
        public string Pedido { get; set; }
        public string CodigoRota { get; set; }
        public string MeioDeTransporte { get; set; }
        public string TipoDeTransporte { get; set; }
        public string TipoDeCarga { get; set; }
        public string CodicaoDeFrete { get; set; }
        public string SerieDaNotaFiscal { get; set; }
        public string NumeorDaNotaFiscal { get; set; }
        public string DataDaEmissao { get; set; }
        public string Natureza { get; set; }
        public string Acondicionamento { get; set; }
        public string Volume { get; set; }
        public string Valordanota { get; set; }
        public string Peso { get; set; }
        public string Cubagem { get; set; }
        public string ICMS { get; set; }
        public string Seguro { get; set; }

        public string QuantidadeDeVolumes { get; set; }

        public string OperacaoNotaFiscal { get; set; }
        public string PeriodoDeEntrega { get; set; }
        public string DataInicialEntrega { get; set; }
        public string HoraInicialEnterga { get; set; }
        public string DataFinalEntrega { get; set; }


        public List<NotaFiscalParticipante> Participantes { get; set; }
    }
}
