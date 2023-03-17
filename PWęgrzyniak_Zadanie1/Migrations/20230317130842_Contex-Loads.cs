using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PWęgrzyniak_Zadanie1.Migrations
{
    /// <inheritdoc />
    public partial class ContexLoads : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Narzedzias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Narzedzias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produkts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produkts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProduktZmianas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProduktId = table.Column<int>(type: "int", nullable: false),
                    DataWprowadzenie = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OpisZmiana = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProduktZmianas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProduktZmianas_Produkts_ProduktId",
                        column: x => x.ProduktId,
                        principalTable: "Produkts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NarzedzieUzycies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NarzedzieId = table.Column<int>(type: "int", nullable: false),
                    ZmianaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NarzedzieUzycies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NarzedzieUzycies_Narzedzias_NarzedzieId",
                        column: x => x.NarzedzieId,
                        principalTable: "Narzedzias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NarzedzieUzycies_ProduktZmianas_ZmianaId",
                        column: x => x.ZmianaId,
                        principalTable: "ProduktZmianas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NarzedzieUzycies_NarzedzieId",
                table: "NarzedzieUzycies",
                column: "NarzedzieId");

            migrationBuilder.CreateIndex(
                name: "IX_NarzedzieUzycies_ZmianaId",
                table: "NarzedzieUzycies",
                column: "ZmianaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProduktZmianas_ProduktId",
                table: "ProduktZmianas",
                column: "ProduktId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NarzedzieUzycies");

            migrationBuilder.DropTable(
                name: "Narzedzias");

            migrationBuilder.DropTable(
                name: "ProduktZmianas");

            migrationBuilder.DropTable(
                name: "Produkts");
        }
    }
}
