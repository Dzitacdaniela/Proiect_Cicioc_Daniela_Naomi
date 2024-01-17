using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect_Cicioc_Daniela_Naomi.Migrations
{
    /// <inheritdoc />
    public partial class Migrare5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Laborator",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Denumire_Laborator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Adresa_Laborator = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laborator", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Laborant",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume_Laborant = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Salar_Laborant = table.Column<int>(type: "int", nullable: false),
                    LaboratorID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laborant", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Laborant_Laborator_LaboratorID",
                        column: x => x.LaboratorID,
                        principalTable: "Laborator",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Analiza",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Denumire_Analiza = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Pret_Analiza = table.Column<int>(type: "int", nullable: false),
                    LaborantID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analiza", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Analiza_Laborant_LaborantID",
                        column: x => x.LaborantID,
                        principalTable: "Laborant",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume_Client = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EMail_Client = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AnalizeID = table.Column<int>(type: "int", nullable: true),
                    LaboratorID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Client_Analiza_AnalizeID",
                        column: x => x.AnalizeID,
                        principalTable: "Analiza",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Client_Laborator_LaboratorID",
                        column: x => x.LaboratorID,
                        principalTable: "Laborator",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "AnalizaClient",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnalizaID = table.Column<int>(type: "int", nullable: false),
                    ClientID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalizaClient", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AnalizaClient_Analiza_AnalizaID",
                        column: x => x.AnalizaID,
                        principalTable: "Analiza",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnalizaClient_Client_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Client",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Analiza_LaborantID",
                table: "Analiza",
                column: "LaborantID");

            migrationBuilder.CreateIndex(
                name: "IX_AnalizaClient_AnalizaID",
                table: "AnalizaClient",
                column: "AnalizaID");

            migrationBuilder.CreateIndex(
                name: "IX_AnalizaClient_ClientID",
                table: "AnalizaClient",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Client_AnalizeID",
                table: "Client",
                column: "AnalizeID");

            migrationBuilder.CreateIndex(
                name: "IX_Client_LaboratorID",
                table: "Client",
                column: "LaboratorID",
                unique: true,
                filter: "[LaboratorID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Laborant_LaboratorID",
                table: "Laborant",
                column: "LaboratorID",
                unique: true,
                filter: "[LaboratorID] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnalizaClient");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Analiza");

            migrationBuilder.DropTable(
                name: "Laborant");

            migrationBuilder.DropTable(
                name: "Laborator");
        }
    }
}
