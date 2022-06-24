using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudSucesso.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Atividades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescAtv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vacancies = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atividades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pacotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(type: "float", nullable: false),
                    DescPkg = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Participantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacoteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participantes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AtividadeParticipante",
                columns: table => new
                {
                    AtividadesId = table.Column<int>(type: "int", nullable: false),
                    ParticipantesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtividadeParticipante", x => new { x.AtividadesId, x.ParticipantesId });
                    table.ForeignKey(
                        name: "FK_AtividadeParticipante_Atividades_AtividadesId",
                        column: x => x.AtividadesId,
                        principalTable: "Atividades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AtividadeParticipante_Participantes_ParticipantesId",
                        column: x => x.ParticipantesId,
                        principalTable: "Participantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PacoteParticipante",
                columns: table => new
                {
                    PacoteId = table.Column<int>(type: "int", nullable: false),
                    ParticipantesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PacoteParticipante", x => new { x.PacoteId, x.ParticipantesId });
                    table.ForeignKey(
                        name: "FK_PacoteParticipante_Pacotes_PacoteId",
                        column: x => x.PacoteId,
                        principalTable: "Pacotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PacoteParticipante_Participantes_ParticipantesId",
                        column: x => x.ParticipantesId,
                        principalTable: "Participantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AtividadeParticipante_ParticipantesId",
                table: "AtividadeParticipante",
                column: "ParticipantesId");

            migrationBuilder.CreateIndex(
                name: "IX_PacoteParticipante_ParticipantesId",
                table: "PacoteParticipante",
                column: "ParticipantesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AtividadeParticipante");

            migrationBuilder.DropTable(
                name: "PacoteParticipante");

            migrationBuilder.DropTable(
                name: "Atividades");

            migrationBuilder.DropTable(
                name: "Pacotes");

            migrationBuilder.DropTable(
                name: "Participantes");
        }
    }
}
