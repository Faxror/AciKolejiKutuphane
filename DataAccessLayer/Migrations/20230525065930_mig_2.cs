using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "kitaps");

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookWritingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookPage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookPublishingHouse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookPublishingDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.CreateTable(
                name: "kitaps",
                columns: table => new
                {
                    KitapID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KitapBasımTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KitapName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapSayfa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapYayınEvi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapYazarName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kitaps", x => x.KitapID);
                });
        }
    }
}
