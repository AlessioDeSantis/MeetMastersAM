using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeetMastersAM.Server.Migrations
{
    /// <inheritdoc />
    public partial class TipoDiContrattoNullable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidati_TipiContratto_TipoContrattoNavigationTipoContrattoId",
                table: "Candidati");

            migrationBuilder.DropIndex(
                name: "IX_Candidati_TipoContrattoNavigationTipoContrattoId",
                table: "Candidati");

            migrationBuilder.DropColumn(
                name: "TipoContrattoNavigationTipoContrattoId",
                table: "Candidati");

            migrationBuilder.CreateIndex(
                name: "IX_Candidati_TipoContrattoId",
                table: "Candidati",
                column: "TipoContrattoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidati_TipiContratto_TipoContrattoId",
                table: "Candidati",
                column: "TipoContrattoId",
                principalTable: "TipiContratto",
                principalColumn: "TipoContrattoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidati_TipiContratto_TipoContrattoId",
                table: "Candidati");

            migrationBuilder.DropIndex(
                name: "IX_Candidati_TipoContrattoId",
                table: "Candidati");

            migrationBuilder.AddColumn<int>(
                name: "TipoContrattoNavigationTipoContrattoId",
                table: "Candidati",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Candidati_TipoContrattoNavigationTipoContrattoId",
                table: "Candidati",
                column: "TipoContrattoNavigationTipoContrattoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidati_TipiContratto_TipoContrattoNavigationTipoContrattoId",
                table: "Candidati",
                column: "TipoContrattoNavigationTipoContrattoId",
                principalTable: "TipiContratto",
                principalColumn: "TipoContrattoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
