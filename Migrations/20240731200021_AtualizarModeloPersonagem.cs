using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Games_Mvc.Migrations
{
    /// <inheritdoc />
    public partial class AtualizarModeloPersonagem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Escolha");

            migrationBuilder.DropTable(
                name: "Relacionamento");

            migrationBuilder.DropTable(
                name: "Cenas");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Personagens");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Personagens",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Personagens",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "JogoId",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Personagens_JogoId",
                table: "Personagens",
                column: "JogoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personagens_Jogos_JogoId",
                table: "Personagens",
                column: "JogoId",
                principalTable: "Jogos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personagens_Jogos_JogoId",
                table: "Personagens");

            migrationBuilder.DropIndex(
                name: "IX_Personagens_JogoId",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "JogoId",
                table: "Personagens");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Personagens",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Personagens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Cenas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descrição = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeCena = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cenas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Relacionamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    NomePersonagemRelacionado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValorRelacionamento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relacionamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Relacionamento_Personagens_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "Personagens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Escolha",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CenaId = table.Column<int>(type: "int", nullable: false),
                    Consequencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descrição = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escolha", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Escolha_Cenas_CenaId",
                        column: x => x.CenaId,
                        principalTable: "Cenas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Escolha_CenaId",
                table: "Escolha",
                column: "CenaId");

            migrationBuilder.CreateIndex(
                name: "IX_Relacionamento_PersonagemId",
                table: "Relacionamento",
                column: "PersonagemId");
        }
    }
}
