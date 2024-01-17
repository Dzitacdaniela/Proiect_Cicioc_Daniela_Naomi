using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect_Cicioc_Daniela_Naomi.Migrations
{
    /// <inheritdoc />
    public partial class Migrare4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Client_AnalizeID",
                table: "Client",
                column: "AnalizeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Analiza_AnalizeID",
                table: "Client",
                column: "AnalizeID",
                principalTable: "Analiza",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Analiza_AnalizeID",
                table: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Client_AnalizeID",
                table: "Client");
        }
    }
}
