using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeetMastersAM.Server.Migrations
{
    /// <inheritdoc />
    public partial class AggiuntaFotoProfilo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ImmagineProfilo",
                table: "Candidati",
                type: "varbinary(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImmagineProfilo",
                table: "Candidati");
        }
    }
}
