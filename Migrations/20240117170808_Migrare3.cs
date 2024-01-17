using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect_Cicioc_Daniela_Naomi.Migrations
{
    /// <inheritdoc />
    public partial class Migrare3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Analiza_Analiza_AnalizeID",
                table: "Analiza");

            migrationBuilder.DropForeignKey(
                name: "FK_AnalizaClient_Analiza_AnalizeID",
                table: "AnalizaClient");

            migrationBuilder.DropForeignKey(
                name: "FK_AnalizaClient_Client_ClientiID",
                table: "AnalizaClient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnalizaClient",
                table: "AnalizaClient");

            migrationBuilder.DropIndex(
                name: "IX_Analiza_AnalizeID",
                table: "Analiza");

            migrationBuilder.DropColumn(
                name: "AnalizaID",
                table: "Analiza");

            migrationBuilder.DropColumn(
                name: "AnalizeID",
                table: "Analiza");

            migrationBuilder.RenameColumn(
                name: "ClientiID",
                table: "AnalizaClient",
                newName: "ClientID");

            migrationBuilder.RenameColumn(
                name: "AnalizeID",
                table: "AnalizaClient",
                newName: "AnalizaID");

            migrationBuilder.RenameIndex(
                name: "IX_AnalizaClient_ClientiID",
                table: "AnalizaClient",
                newName: "IX_AnalizaClient_ClientID");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "AnalizaClient",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnalizaClient",
                table: "AnalizaClient",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_AnalizaClient_AnalizaID",
                table: "AnalizaClient",
                column: "AnalizaID");

            migrationBuilder.AddForeignKey(
                name: "FK_AnalizaClient_Analiza_AnalizaID",
                table: "AnalizaClient",
                column: "AnalizaID",
                principalTable: "Analiza",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnalizaClient_Client_ClientID",
                table: "AnalizaClient",
                column: "ClientID",
                principalTable: "Client",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnalizaClient_Analiza_AnalizaID",
                table: "AnalizaClient");

            migrationBuilder.DropForeignKey(
                name: "FK_AnalizaClient_Client_ClientID",
                table: "AnalizaClient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnalizaClient",
                table: "AnalizaClient");

            migrationBuilder.DropIndex(
                name: "IX_AnalizaClient_AnalizaID",
                table: "AnalizaClient");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "AnalizaClient");

            migrationBuilder.RenameColumn(
                name: "ClientID",
                table: "AnalizaClient",
                newName: "ClientiID");

            migrationBuilder.RenameColumn(
                name: "AnalizaID",
                table: "AnalizaClient",
                newName: "AnalizeID");

            migrationBuilder.RenameIndex(
                name: "IX_AnalizaClient_ClientID",
                table: "AnalizaClient",
                newName: "IX_AnalizaClient_ClientiID");

            migrationBuilder.AddColumn<int>(
                name: "AnalizaID",
                table: "Analiza",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AnalizeID",
                table: "Analiza",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnalizaClient",
                table: "AnalizaClient",
                columns: new[] { "AnalizeID", "ClientiID" });

            migrationBuilder.CreateIndex(
                name: "IX_Analiza_AnalizeID",
                table: "Analiza",
                column: "AnalizeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Analiza_Analiza_AnalizeID",
                table: "Analiza",
                column: "AnalizeID",
                principalTable: "Analiza",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AnalizaClient_Analiza_AnalizeID",
                table: "AnalizaClient",
                column: "AnalizeID",
                principalTable: "Analiza",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnalizaClient_Client_ClientiID",
                table: "AnalizaClient",
                column: "ClientiID",
                principalTable: "Client",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
