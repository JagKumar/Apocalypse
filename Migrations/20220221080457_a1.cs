using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Apocalypse.Migrations
{
    public partial class a1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "robots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    serialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    manufacturedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_robots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "survivors",
                columns: table => new
                {
                    SurvivorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    asinfected = table.Column<bool>(type: "bit", nullable: false),
                    latitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    longitude = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_survivors", x => x.SurvivorId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "robots");

            migrationBuilder.DropTable(
                name: "survivors");
        }
    }
}
