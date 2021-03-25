using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaAdministrativo.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Livros",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumerodoLivro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CadastroId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCadastro = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Igrejas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BairroIgreja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatadaAbertura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LivrosId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdLivro = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Igrejas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Igrejas_Livros_LivrosId",
                        column: x => x.LivrosId,
                        principalTable: "Livros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cadastros",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroTelefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Profissao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComunCongregcao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IgrejaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cadastros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cadastros_Igrejas_IgrejaId",
                        column: x => x.IgrejaId,
                        principalTable: "Igrejas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cadastros_IgrejaId",
                table: "Cadastros",
                column: "IgrejaId");

            migrationBuilder.CreateIndex(
                name: "IX_Igrejas_LivrosId",
                table: "Igrejas",
                column: "LivrosId");

            migrationBuilder.CreateIndex(
                name: "IX_Livros_CadastroId",
                table: "Livros",
                column: "CadastroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Cadastros_CadastroId",
                table: "Livros",
                column: "CadastroId",
                principalTable: "Cadastros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cadastros_Igrejas_IgrejaId",
                table: "Cadastros");

            migrationBuilder.DropTable(
                name: "Igrejas");

            migrationBuilder.DropTable(
                name: "Livros");

            migrationBuilder.DropTable(
                name: "Cadastros");
        }
    }
}
