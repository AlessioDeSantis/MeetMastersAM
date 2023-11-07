using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeetMastersAM.Server.Migrations
{
    /// <inheritdoc />
    public partial class SocialDipendente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfiloGithub",
                table: "Dipendenti",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfiloInstagram",
                table: "Dipendenti",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfiloLinkedin",
                table: "Dipendenti",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfiloGithub",
                table: "Dipendenti");

            migrationBuilder.DropColumn(
                name: "ProfiloInstagram",
                table: "Dipendenti");

            migrationBuilder.DropColumn(
                name: "ProfiloLinkedin",
                table: "Dipendenti");
        }
    }
}
