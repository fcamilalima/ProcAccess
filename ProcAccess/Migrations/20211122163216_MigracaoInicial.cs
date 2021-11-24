using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProcAccess.Migrations;

public partial class MigracaoInicial : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "tbCategoria",
            columns: table => new
            {
                CategoriaId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_tbCategoria", x => x.CategoriaId);
            });

        migrationBuilder.CreateTable(
            name: "tbProcesso",
            columns: table => new
            {
                ProcessoId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Codigo = table.Column<int>(type: "int", nullable: false),
                Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                CategoriaId = table.Column<int>(type: "int", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_tbProcesso", x => x.ProcessoId);
                table.ForeignKey(
                    name: "FK_tbProcesso_tbCategoria_CategoriaId",
                    column: x => x.CategoriaId,
                    principalTable: "tbCategoria",
                    principalColumn: "CategoriaId");
            });

        migrationBuilder.CreateIndex(
            name: "IX_tbProcesso_CategoriaId",
            table: "tbProcesso",
            column: "CategoriaId");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "tbProcesso");

        migrationBuilder.DropTable(
            name: "tbCategoria");
    }
}

