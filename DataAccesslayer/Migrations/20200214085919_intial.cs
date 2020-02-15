using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesslayer.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    ProjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.ProjectId);
                });

            migrationBuilder.CreateTable(
                name: " Employee",
                columns: table => new
                {
                    EId = table.Column<string>(maxLength: 5, nullable: false),
                    Ename = table.Column<string>(nullable: false),
                    joinDate = table.Column<DateTime>(type: "Date", nullable: true),
                    Designation = table.Column<string>(maxLength: 20, nullable: true),
                    salary = table.Column<decimal>(nullable: true),
                    ProjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ Employee", x => x.EId);
                    table.ForeignKey(
                        name: "FK_ Employee_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ Employee_ProjectId",
                table: " Employee",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: " Employee");

            migrationBuilder.DropTable(
                name: "Project");
        }
    }
}
