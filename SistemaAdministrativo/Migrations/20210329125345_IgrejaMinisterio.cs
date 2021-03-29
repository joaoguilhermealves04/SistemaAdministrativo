using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaAdministrativo.Migrations
{
    public partial class IgrejaMinisterio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Igrejas_Livros_LivrosId",
                table: "Igrejas");

            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Cadastros_CadastroId",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "IdCadastro",
                table: "Livros");

            migrationBuilder.RenameColumn(
                name: "CadastroId",
                table: "Livros",
                newName: "IgrejaId");

            migrationBuilder.RenameIndex(
                name: "IX_Livros_CadastroId",
                table: "Livros",
                newName: "IX_Livros_IgrejaId");

            migrationBuilder.RenameColumn(
                name: "LivrosId",
                table: "Igrejas",
                newName: "LivroId");

            migrationBuilder.RenameIndex(
                name: "IX_Igrejas_LivrosId",
                table: "Igrejas",
                newName: "IX_Igrejas_LivroId");

            migrationBuilder.AddColumn<Guid>(
                name: "IdIgreja",
                table: "Cadastros",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "LivroCadastros",
                columns: table => new
                {
                    LivroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CadastroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivroCadastros", x => new { x.LivroId, x.CadastroId });
                    table.ForeignKey(
                        name: "FK_LivroCadastros_Cadastros_CadastroId",
                        column: x => x.CadastroId,
                        principalTable: "Cadastros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LivroCadastros_Livros_LivroId",
                        column: x => x.LivroId,
                        principalTable: "Livros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ministerio",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataOrdenacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ministerio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IgrejaMinisterios",
                columns: table => new
                {
                    MinisterioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    igrejaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IgrejaMinisterios", x => new { x.igrejaId, x.MinisterioId });
                    table.ForeignKey(
                        name: "FK_IgrejaMinisterios_Igrejas_igrejaId",
                        column: x => x.igrejaId,
                        principalTable: "Igrejas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IgrejaMinisterios_Ministerio_MinisterioId",
                        column: x => x.MinisterioId,
                        principalTable: "Ministerio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IgrejaMinisterios_MinisterioId",
                table: "IgrejaMinisterios",
                column: "MinisterioId");

            migrationBuilder.CreateIndex(
                name: "IX_LivroCadastros_CadastroId",
                table: "LivroCadastros",
                column: "CadastroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Igrejas_Livros_LivroId",
                table: "Igrejas",
                column: "LivroId",
                principalTable: "Livros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Igrejas_IgrejaId",
                table: "Livros",
                column: "IgrejaId",
                principalTable: "Igrejas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Igrejas_Livros_LivroId",
                table: "Igrejas");

            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Igrejas_IgrejaId",
                table: "Livros");

            migrationBuilder.DropTable(
                name: "IgrejaMinisterios");

            migrationBuilder.DropTable(
                name: "LivroCadastros");

            migrationBuilder.DropTable(
                name: "Ministerio");

            migrationBuilder.DropColumn(
                name: "IdIgreja",
                table: "Cadastros");

            migrationBuilder.RenameColumn(
                name: "IgrejaId",
                table: "Livros",
                newName: "CadastroId");

            migrationBuilder.RenameIndex(
                name: "IX_Livros_IgrejaId",
                table: "Livros",
                newName: "IX_Livros_CadastroId");

            migrationBuilder.RenameColumn(
                name: "LivroId",
                table: "Igrejas",
                newName: "LivrosId");

            migrationBuilder.RenameIndex(
                name: "IX_Igrejas_LivroId",
                table: "Igrejas",
                newName: "IX_Igrejas_LivrosId");

            migrationBuilder.AddColumn<Guid>(
                name: "IdCadastro",
                table: "Livros",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddForeignKey(
                name: "FK_Igrejas_Livros_LivrosId",
                table: "Igrejas",
                column: "LivrosId",
                principalTable: "Livros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Cadastros_CadastroId",
                table: "Livros",
                column: "CadastroId",
                principalTable: "Cadastros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
