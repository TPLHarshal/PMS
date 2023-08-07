using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS.Migrations
{
    /// <inheritdoc />
    public partial class changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Project_Id = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Project_Name = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Start_Time_Plan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    End_Time_Plan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Reasons = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Division = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Priority = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
