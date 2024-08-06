using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Games_Mvc.Migrations
{
    /// <inheritdoc />
    public partial class SobreJogo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagemUrl",
                table: "Personagens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Jogos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagemUrl",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Jogos");
        }
    }
}
