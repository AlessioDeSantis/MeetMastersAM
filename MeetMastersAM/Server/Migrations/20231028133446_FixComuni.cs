using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeetMastersAM.Server.Migrations
{
    /// <inheritdoc />
    public partial class FixComuni : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comuni_Province_ProvinciaNavigationProvinciaId",
                table: "Comuni");

            migrationBuilder.DropForeignKey(
                name: "FK_Province_Regioni_RegioneNavigationRegioneId",
                table: "Province");

            migrationBuilder.DropForeignKey(
                name: "FK_Regioni_Nazioni_NazioneNavigationNazioneId",
                table: "Regioni");

            migrationBuilder.DropIndex(
                name: "IX_Regioni_NazioneNavigationNazioneId",
                table: "Regioni");

            migrationBuilder.DropIndex(
                name: "IX_Province_RegioneNavigationRegioneId",
                table: "Province");

            migrationBuilder.DropIndex(
                name: "IX_Comuni_ProvinciaNavigationProvinciaId",
                table: "Comuni");

            migrationBuilder.DropColumn(
                name: "NazioneNavigationNazioneId",
                table: "Regioni");

            migrationBuilder.DropColumn(
                name: "RegioneNavigationRegioneId",
                table: "Province");

            migrationBuilder.DropColumn(
                name: "ProvinciaNavigationProvinciaId",
                table: "Comuni");

            migrationBuilder.CreateIndex(
                name: "IX_Regioni_NazioneId",
                table: "Regioni",
                column: "NazioneId");

            migrationBuilder.CreateIndex(
                name: "IX_Province_RegioneId",
                table: "Province",
                column: "RegioneId");

            migrationBuilder.CreateIndex(
                name: "IX_Comuni_ProvinciaId",
                table: "Comuni",
                column: "ProvinciaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comuni_Province_ProvinciaId",
                table: "Comuni",
                column: "ProvinciaId",
                principalTable: "Province",
                principalColumn: "ProvinciaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Province_Regioni_RegioneId",
                table: "Province",
                column: "RegioneId",
                principalTable: "Regioni",
                principalColumn: "RegioneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Regioni_Nazioni_NazioneId",
                table: "Regioni",
                column: "NazioneId",
                principalTable: "Nazioni",
                principalColumn: "NazioneId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comuni_Province_ProvinciaId",
                table: "Comuni");

            migrationBuilder.DropForeignKey(
                name: "FK_Province_Regioni_RegioneId",
                table: "Province");

            migrationBuilder.DropForeignKey(
                name: "FK_Regioni_Nazioni_NazioneId",
                table: "Regioni");

            migrationBuilder.DropIndex(
                name: "IX_Regioni_NazioneId",
                table: "Regioni");

            migrationBuilder.DropIndex(
                name: "IX_Province_RegioneId",
                table: "Province");

            migrationBuilder.DropIndex(
                name: "IX_Comuni_ProvinciaId",
                table: "Comuni");

            migrationBuilder.AddColumn<int>(
                name: "NazioneNavigationNazioneId",
                table: "Regioni",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RegioneNavigationRegioneId",
                table: "Province",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProvinciaNavigationProvinciaId",
                table: "Comuni",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Regioni_NazioneNavigationNazioneId",
                table: "Regioni",
                column: "NazioneNavigationNazioneId");

            migrationBuilder.CreateIndex(
                name: "IX_Province_RegioneNavigationRegioneId",
                table: "Province",
                column: "RegioneNavigationRegioneId");

            migrationBuilder.CreateIndex(
                name: "IX_Comuni_ProvinciaNavigationProvinciaId",
                table: "Comuni",
                column: "ProvinciaNavigationProvinciaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comuni_Province_ProvinciaNavigationProvinciaId",
                table: "Comuni",
                column: "ProvinciaNavigationProvinciaId",
                principalTable: "Province",
                principalColumn: "ProvinciaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Province_Regioni_RegioneNavigationRegioneId",
                table: "Province",
                column: "RegioneNavigationRegioneId",
                principalTable: "Regioni",
                principalColumn: "RegioneId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Regioni_Nazioni_NazioneNavigationNazioneId",
                table: "Regioni",
                column: "NazioneNavigationNazioneId",
                principalTable: "Nazioni",
                principalColumn: "NazioneId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
