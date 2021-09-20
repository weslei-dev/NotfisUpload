using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using NotfisUpload.Entidade;
using NotfisUpload.Models;

namespace UploadFile.Servicos
{
    public class ConversorNotfis
    {
        public Intercambio Converter(IFormFile files)
        {
            var linhasLidas = new List<LinhaArquivo>();

            using var stream = files.OpenReadStream();
            {
                var reader = new StreamReader(stream);
                var intercambio = new Intercambio
                {
                    NotasFiscais = new List<NotaFiscal>()
                };

                string linha;
                while ((linha = reader.ReadLine()) != null)
                {
                    var identificador = linha.Substring(0, 3);

                    linhasLidas.Add(new LinhaArquivo(linha, identificador));

                    switch (identificador)
                    {
                        case "311":
                            LerDadosIniciais(linhasLidas, intercambio);
                            break;
                        case "317":
                            LerDadosFinais(linhasLidas, intercambio);
                            linhasLidas.Clear();
                            break;
                    }
                }

                return intercambio;
            }
        }

        private void LerDadosIniciais(List<LinhaArquivo> linhasLidas, Intercambio intercambio)
        {
            LerDadosIntercambio(linhasLidas.FirstOrDefault(l => l.Identificador == "000").Linha, intercambio);
            LerDadosCabecalho(linhasLidas.FirstOrDefault(l => l.Identificador == "310").Linha, intercambio);
            LerDadosEmbarcador(linhasLidas.FirstOrDefault(l => l.Identificador == "311").Linha, intercambio);
        }

        private void LerDadosFinais(List<LinhaArquivo> linhasLidas, Intercambio intercambio)
        {
            var notaFiscal = new NotaFiscal();
            notaFiscal.Participantes = new List<NotaFiscalParticipante>();

            LerDadosNotaFiscal(linhasLidas.FirstOrDefault(l => l.Identificador == "313").Linha, notaFiscal);
            LerDadosDestinatario(linhasLidas.FirstOrDefault(l => l.Identificador == "312").Linha, notaFiscal);
            LerDadosComplementares(linhasLidas.FirstOrDefault(l => l.Identificador == "333")?.Linha, notaFiscal);

            intercambio.NotasFiscais.Add(notaFiscal);
        }

        private void LerDadosIntercambio(string linha, Intercambio intercambio)
        {
            intercambio.Remetente = linha.Substring(3, 35);
            intercambio.Destinatario = linha.Substring(38, 35);
            intercambio.Data = linha.Substring(73, 6);
            intercambio.Hora = linha.Substring(79, 4);
            intercambio.IndetificadorIntercambio = linha.Substring(83, 12);
        }

        private void LerDadosCabecalho(string linha, Intercambio intercambio)
        {
            intercambio.Documento = linha.Substring(3, 17);
        }

        private void LerDadosEmbarcador(string linha, Intercambio intercambio)
        {
            intercambio.CNPJ = linha.Substring(4, 14);
            intercambio.IE = linha.Substring(18, 14);
            intercambio.Endereco = linha.Substring(32, 40);
            intercambio.Cidade = linha.Substring(72, 35);
            intercambio.Cep = linha.Substring(106, 10);
            intercambio.Estado = linha.Substring(116, 9);
            intercambio.DataEmbarque = linha.Substring(124, 9);
            intercambio.NomeEmpresaEmbarcadora = linha.Substring(134, 40);
        }

        private void LerDadosNotaFiscal(string linha, NotaFiscal notaFiscal)
        {
            notaFiscal.CodigoRota = linha.Substring(18, 7);
            notaFiscal.MeioDeTransporte = linha.Substring(26, 1);
            notaFiscal.TipoDeTransporte = linha.Substring(27, 1);
            notaFiscal.TipoDeCarga = linha.Substring(28, 1);
            notaFiscal.CodicaoDeFrete = linha.Substring(29, 1);
            notaFiscal.SerieDaNotaFiscal = linha.Substring(30, 3);
            notaFiscal.NumeorDaNotaFiscal = linha.Substring(33, 8);
            notaFiscal.DataDaEmissao = linha.Substring(40, 8);
            notaFiscal.Natureza = linha.Substring(48, 15);
            notaFiscal.Acondicionamento = linha.Substring(63, 15);
            notaFiscal.Volume = linha.Substring(82, 1);
            notaFiscal.Valordanota = linha.Substring(86, 14);
            notaFiscal.Peso = linha.Substring(101, 6);
            notaFiscal.Cubagem = linha.Substring(108, 4);
            notaFiscal.ICMS = linha.Substring(113, 1);
            notaFiscal.Seguro = linha.Substring(114, 1);
            notaFiscal.ChaveNFE = linha.Substring(238, 44);
            notaFiscal.Pedido = linha.Substring(282, 9);


        }

        private void LerDadosDestinatario(string linha, NotaFiscal notaFiscal)
        {
            var destinatario = new NotaFiscalParticipante();
            destinatario.RazaoSocial = linha.Substring(3, 40);
            destinatario.CNPJ = linha.Substring(44, 14);
            destinatario.InscricaoEstadual = linha.Substring(58, 15);
            destinatario.Logradouro = linha.Substring(72, 40);
            destinatario.Bairro = linha.Substring(112, 20);
            destinatario.Cidade = linha.Substring(132, 35);
            destinatario.Cep = linha.Substring(167, 9);
            destinatario.IBGE = linha.Substring(176, 9);
            destinatario.Estados = linha.Substring(185, 9);
            destinatario.AreaFrete = linha.Substring(195, 4);


            notaFiscal.Participantes.Add(destinatario);
        }

        private void LerDadosEmbarcador(string linha, NotaFiscal notaFiscal)
        {
            var emitente = new NotaFiscalParticipante();

            emitente.FreteRazaoSocial = linha.Substring(3, 40);
            emitente.FreteCNPJ = linha.Substring(43, 14);
            emitente.FreteIE = linha.Substring(58, 15);
            emitente.FreteLogradouro = linha.Substring(73, 40);
            emitente.FreteBairro = linha.Substring(113, 20);
            emitente.FreteCidade = linha.Substring(133, 35);
            emitente.FreteIBGE = linha.Substring(177, 9);
            emitente.FreteCep = linha.Substring(168, 9);
            emitente.FreteEstado = linha.Substring(186, 9);
            emitente.FreteTelefone = linha.Substring(195, 35);

            notaFiscal.Participantes.Add(emitente);
        }

        private void LerdadosMercadoria(string linha, NotaFiscal notaFiscal)
        {
            notaFiscal.QuantidadeDeVolumes = linha.Substring(7, 3);
        }

        private void LerDadosComplementares(string linha, NotaFiscal notaFiscal)
        {
            if (string.IsNullOrEmpty(linha))
                return ;

            notaFiscal.OperacaoNotaFiscal = linha.Substring(3, 4);
            notaFiscal.PeriodoDeEntrega = linha.Substring(8, 1);
            notaFiscal.DataInicialEntrega = linha.Substring(9, 8);
            notaFiscal.HoraInicialEnterga = linha.Substring(17, 4);
            notaFiscal.DataFinalEntrega = linha.Substring(21, 8);
        }

    }


}
