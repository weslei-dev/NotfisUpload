using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NotfisUpload.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arquivo",
                columns: table => new
                {
                    intercambio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FileType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DataFiles = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Emissao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arquivo", x => x.intercambio);
                });

            migrationBuilder.CreateTable(
                name: "Intercambio",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Remetente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Destinatario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndetificadorIntercambio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataEmbarque = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeEmpresaEmbarcadora = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intercambio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NotaFiscal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IntercambioId = table.Column<long>(type: "bigint", nullable: true),
                    NumeorDaNotaFiscal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Natureza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChaveNFE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pedido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataDaEmissao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SerieDaNotaFiscal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoRota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeioDeTransporte = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoDeTransporte = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoDeCarga = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodicaoDeFrete = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Acondicionamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Volume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valordanota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Peso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cubagem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ICMS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Seguro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuantidadeDeVolumes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperacaoNotaFiscal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeriodoDeEntrega = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataInicialEntrega = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoraInicialEnterga = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataFinalEntrega = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaFiscal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotaFiscal_Intercambio_IntercambioId",
                        column: x => x.IntercambioId,
                        principalTable: "Intercambio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NotaFiscalParticipante",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotaFiscalId = table.Column<int>(type: "int", nullable: true),
                    RazaoSocial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InscricaoEstadual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estados = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IBGE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaFrete = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreteRazaoSocial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreteCNPJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreteIE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreteLogradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreteBairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreteCidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreteIBGE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreteCep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreteEstado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreteTelefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperacaoNotaFiscal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeriodoDeEntrega = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataInicialEntrega = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoraInicialEnterga = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataFinalEntrega = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaFiscalParticipante", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NotaFiscalParticipante_NotaFiscal_NotaFiscalId",
                        column: x => x.NotaFiscalId,
                        principalTable: "NotaFiscal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NotaFiscal_IntercambioId",
                table: "NotaFiscal",
                column: "IntercambioId");

            migrationBuilder.CreateIndex(
                name: "IX_NotaFiscalParticipante_NotaFiscalId",
                table: "NotaFiscalParticipante",
                column: "NotaFiscalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arquivo");

            migrationBuilder.DropTable(
                name: "NotaFiscalParticipante");

            migrationBuilder.DropTable(
                name: "NotaFiscal");

            migrationBuilder.DropTable(
                name: "Intercambio");
        }
    }
}
