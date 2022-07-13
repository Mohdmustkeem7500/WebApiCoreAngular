using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiCoreLecture.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblDesignations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Designation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDesignations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 150, nullable: true),
                    LastName = table.Column<string>(maxLength: 150, nullable: true),
                    Email = table.Column<string>(maxLength: 250, nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Doj = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(maxLength: 20, nullable: true),
                    IsMarried = table.Column<int>(nullable: false),
                    IsActive = table.Column<int>(nullable: false),
                    DesignationID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEmployees", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblDesignations");

            migrationBuilder.DropTable(
                name: "tblEmployees");
        }
    }
}
