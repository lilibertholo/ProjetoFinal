using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoFinalLivia.Migrations
{
    public partial class AlteracaoProcedimento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoColaboradorNome",
                table: "TipoProcedimento",
                newName: "TipoProcedimentoNome");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoProcedimentoNome",
                table: "TipoProcedimento",
                newName: "TipoColaboradorNome");
        }
    }
}
