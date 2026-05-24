using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HelpDeskWindowsForms.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarUsuarioIdChamado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Chamados",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Chamados_UsuarioId",
                table: "Chamados",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chamados_Usuarios_UsuarioId",
                table: "Chamados",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chamados_Usuarios_UsuarioId",
                table: "Chamados");

            migrationBuilder.DropIndex(
                name: "IX_Chamados_UsuarioId",
                table: "Chamados");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Chamados");
        }
    }
}
