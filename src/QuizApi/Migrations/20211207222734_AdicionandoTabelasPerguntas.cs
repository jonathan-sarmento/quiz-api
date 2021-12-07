using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizApi.Migrations
{
    public partial class AdicionandoTabelasPerguntas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "pontuacao",
                table: "usuarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "perguntas",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Enunciado = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_perguntas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "alternativas",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Descricao = table.Column<string>(type: "text", nullable: true),
                    RespostaCerta = table.Column<bool>(type: "boolean", nullable: false),
                    PerguntaId = table.Column<int>(type: "integer", nullable: false),
                    PerguntaId1 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alternativas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_alternativas_perguntas_PerguntaId1",
                        column: x => x.PerguntaId1,
                        principalTable: "perguntas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_alternativas_PerguntaId1",
                table: "alternativas",
                column: "PerguntaId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "alternativas");

            migrationBuilder.DropTable(
                name: "perguntas");

            migrationBuilder.DropColumn(
                name: "pontuacao",
                table: "usuarios");
        }
    }
}
