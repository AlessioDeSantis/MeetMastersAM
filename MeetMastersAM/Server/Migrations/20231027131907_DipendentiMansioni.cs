using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeetMastersAM.Server.Migrations
{
    /// <inheritdoc />
    public partial class DipendentiMansioni : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DipendentiMansioni");

            migrationBuilder.CreateTable(
                name: "Dipendenti_Mansioni",
                columns: table => new
                {
                    DipendenteId = table.Column<int>(type: "int", nullable: false),
                    MansioneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dipendenti_Mansioni", x => new { x.MansioneId, x.DipendenteId });
                    table.ForeignKey(
                        name: "FK_Dipendenti_Mansioni_Dipendenti_DipendenteId",
                        column: x => x.DipendenteId,
                        principalTable: "Dipendenti",
                        principalColumn: "DipendenteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dipendenti_Mansioni_Mansioni_MansioneId",
                        column: x => x.MansioneId,
                        principalTable: "Mansioni",
                        principalColumn: "MansioneId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dipendenti_Mansioni_DipendenteId",
                table: "Dipendenti_Mansioni",
                column: "DipendenteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dipendenti_Mansioni");

            migrationBuilder.CreateTable(
                name: "DipendentiMansioni",
                columns: table => new
                {
                    DipendentiDipendenteId = table.Column<int>(type: "int", nullable: false),
                    MansioniMansioneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DipendentiMansioni", x => new { x.DipendentiDipendenteId, x.MansioniMansioneId });
                    table.ForeignKey(
                        name: "FK_DipendentiMansioni_Dipendenti_DipendentiDipendenteId",
                        column: x => x.DipendentiDipendenteId,
                        principalTable: "Dipendenti",
                        principalColumn: "DipendenteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DipendentiMansioni_Mansioni_MansioniMansioneId",
                        column: x => x.MansioniMansioneId,
                        principalTable: "Mansioni",
                        principalColumn: "MansioneId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DipendentiMansioni_MansioniMansioneId",
                table: "DipendentiMansioni",
                column: "MansioniMansioneId");
        }
    }
}
