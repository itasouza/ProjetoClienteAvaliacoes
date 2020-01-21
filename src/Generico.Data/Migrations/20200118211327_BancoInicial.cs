using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Generico.Data.Migrations
{
    public partial class BancoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    Sigla = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    Ativo = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeProduto = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    DescricaoProduto = table.Column<string>(type: "text", nullable: true),
                    ValorProduto = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DataFabricacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataValidade = table.Column<DateTime>(type: "datetime", nullable: true),
                    FotoProduto = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    ProdutoPromocao = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    Ativo = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cidades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    EstadoId = table.Column<int>(nullable: false),
                    Ativo = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cidade_Estado",
                        column: x => x.EstadoId,
                        principalTable: "Estados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeCliente = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    EmailCliente = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    EstadoId = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    EstadoId1 = table.Column<int>(nullable: true),
                    CidadeId = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    CidadeId1 = table.Column<int>(nullable: true),
                    Ativo = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_Cidades_CidadeId1",
                        column: x => x.CidadeId1,
                        principalTable: "Cidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clientes_Estados_EstadoId1",
                        column: x => x.EstadoId1,
                        principalTable: "Estados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Avaliacoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    Descricao = table.Column<string>(type: "text", nullable: true),
                    QuantidadeEstrela = table.Column<int>(nullable: true),
                    AvaliacaoUtil = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    ProdutoId = table.Column<int>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false),
                    Ativo = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avaliacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Avaliacao_Cliente",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Avaliacao_Produto",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacoes_ClienteId",
                table: "Avaliacoes",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacoes_ProdutoId",
                table: "Avaliacoes",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cidades_EstadoId",
                table: "Cidades",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_CidadeId1",
                table: "Clientes",
                column: "CidadeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_EstadoId1",
                table: "Clientes",
                column: "EstadoId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Avaliacoes");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Cidades");

            migrationBuilder.DropTable(
                name: "Estados");
        }
    }
}
