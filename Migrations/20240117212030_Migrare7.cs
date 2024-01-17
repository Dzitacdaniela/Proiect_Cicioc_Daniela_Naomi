using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect_Cicioc_Daniela_Naomi.Migrations
{
    /// <inheritdoc />
    public partial class Migrare7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Client_LaboratorID",
                table: "Client");

            migrationBuilder.CreateIndex(
                name: "IX_Client_LaboratorID",
                table: "Client",
                column: "LaboratorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Client_LaboratorID",
                table: "Client");

            migrationBuilder.CreateIndex(
                name: "IX_Client_LaboratorID",
                table: "Client",
                column: "LaboratorID",
                unique: true,
                filter: "[LaboratorID] IS NOT NULL");
        }
    }
}
