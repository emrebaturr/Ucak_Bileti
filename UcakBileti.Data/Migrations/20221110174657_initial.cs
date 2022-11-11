using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UcakBileti.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ucuslar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nereden = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nereye = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YolcuSayisi = table.Column<int>(type: "int", nullable: false),
                    GidisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DonusTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Saat = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ucuslar", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ucuslar");
        }
    }
}
