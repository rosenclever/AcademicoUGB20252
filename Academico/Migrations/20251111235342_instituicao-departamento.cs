using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academico.Migrations
{
    /// <inheritdoc />
    public partial class instituicaodepartamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InstituicaoOrigemInstituicaoId",
                table: "Departamentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_InstituicaoOrigemInstituicaoId",
                table: "Departamentos",
                column: "InstituicaoOrigemInstituicaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departamentos_Instituicoes_InstituicaoOrigemInstituicaoId",
                table: "Departamentos",
                column: "InstituicaoOrigemInstituicaoId",
                principalTable: "Instituicoes",
                principalColumn: "InstituicaoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departamentos_Instituicoes_InstituicaoOrigemInstituicaoId",
                table: "Departamentos");

            migrationBuilder.DropIndex(
                name: "IX_Departamentos_InstituicaoOrigemInstituicaoId",
                table: "Departamentos");

            migrationBuilder.DropColumn(
                name: "InstituicaoOrigemInstituicaoId",
                table: "Departamentos");
        }
    }
}
