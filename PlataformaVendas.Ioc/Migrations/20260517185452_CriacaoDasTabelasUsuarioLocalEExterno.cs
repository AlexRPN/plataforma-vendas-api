using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlataformaVendas.Infra.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoDasTabelasUsuarioLocalEExterno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(11)", nullable: false),
                    Cnpj = table.Column<string>(type: "nvarchar(14)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    EmailConfirmado = table.Column<int>(type: "int", nullable: false),
                    DataEmailConfirmado = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TipoUsuario = table.Column<int>(type: "int", nullable: false),
                    Situacao = table.Column<int>(type: "int", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataUltimoLogin = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioExterno",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Provedor = table.Column<int>(type: "int", nullable: false),
                    IdProvedor = table.Column<long>(type: "bigint", nullable: false),
                    DataUltimoLogin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioExterno", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioExterno_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioLocal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenhaHash = table.Column<byte[]>(type: "varbinary(250)", nullable: false),
                    SenhaSalt = table.Column<byte[]>(type: "varbinary(250)", nullable: false),
                    DataUltimoLogin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioLocal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioLocal_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioExterno_UsuarioId",
                table: "UsuarioExterno",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioLocal_UsuarioId",
                table: "UsuarioLocal",
                column: "UsuarioId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsuarioExterno");

            migrationBuilder.DropTable(
                name: "UsuarioLocal");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
