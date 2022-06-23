using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SucessoCRUD.Migrations
{
    public partial class CreatTableForms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Atividades",
                columns: table => new
                {
                    CodAtv = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescAtv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vagas = table.Column<int>(type: "int", nullable: false),
                    PreçoAtv = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atividades", x => x.CodAtv);
                });

            migrationBuilder.CreateTable(
                name: "AuxParticipanteAtiv",
                columns: table => new
                {
                    AtivId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuxParticipanteAtiv", x => x.AtivId);
                });

            migrationBuilder.CreateTable(
                name: "AuxParticipantePacote",
                columns: table => new
                {
                    ParId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuxParticipantePacote", x => x.ParId);
                });

            migrationBuilder.CreateTable(
                name: "Pacotes",
                columns: table => new
                {
                    PackId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Preço = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Descrição = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacotes", x => x.PackId);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    CodPar = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.CodPar);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Atividades");

            migrationBuilder.DropTable(
                name: "AuxParticipanteAtiv");

            migrationBuilder.DropTable(
                name: "AuxParticipantePacote");

            migrationBuilder.DropTable(
                name: "Pacotes");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
