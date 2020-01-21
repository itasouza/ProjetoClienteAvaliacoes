using Microsoft.EntityFrameworkCore.Migrations;

namespace Generico.Data.Migrations
{
    public partial class banco01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "ProdutoPromocao",
                table: "Produtos",
                unicode: false,
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Ativo",
                table: "Produtos",
                unicode: false,
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Ativo",
                table: "Estados",
                unicode: false,
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Ativo",
                table: "Clientes",
                unicode: false,
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Ativo",
                table: "Cidades",
                unicode: false,
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Ativo",
                table: "Avaliacoes",
                unicode: false,
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProdutoPromocao",
                table: "Produtos",
                unicode: false,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(bool),
                oldUnicode: false,
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Ativo",
                table: "Produtos",
                unicode: false,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(bool),
                oldUnicode: false,
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Ativo",
                table: "Estados",
                unicode: false,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(bool),
                oldUnicode: false,
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Ativo",
                table: "Clientes",
                unicode: false,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(bool),
                oldUnicode: false,
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Ativo",
                table: "Cidades",
                unicode: false,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(bool),
                oldUnicode: false,
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Ativo",
                table: "Avaliacoes",
                unicode: false,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(bool),
                oldUnicode: false,
                oldMaxLength: 1);
        }
    }
}
