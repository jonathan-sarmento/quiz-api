using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QuizApi.Migrations
{
    public partial class mapping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "perguntas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Enunciado = table.Column<string>(type: "text", nullable: true),
                    Tema = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_perguntas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: true),
                    LinkImagem = table.Column<string>(type: "text", nullable: true),
                    Pontuacao = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "alternativas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descricao = table.Column<string>(type: "text", nullable: true),
                    RespostaCerta = table.Column<bool>(type: "boolean", nullable: false),
                    PerguntaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alternativas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_alternativas_perguntas_PerguntaId",
                        column: x => x.PerguntaId,
                        principalTable: "perguntas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "perguntas",
                columns: new[] { "Id", "Enunciado", "Tema" },
                values: new object[] { 1, "Na linguagem C#, para incrementar uma variável sem a utilização de uma equação, é necessário utilizar \"variavel______.\"", 0 });

            migrationBuilder.InsertData(
                table: "alternativas",
                columns: new[] { "Id", "Descricao", "PerguntaId", "RespostaCerta" },
                values: new object[,]
                {
                    { 1, "++;", 1, true },
                    { 2, "--;", 1, false },
                    { 3, "= variavel + 1;", 1, false },
                    { 4, "+", 1, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_alternativas_PerguntaId",
                table: "alternativas",
                column: "PerguntaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "alternativas");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "perguntas");
        }
    }
}
