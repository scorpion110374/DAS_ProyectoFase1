using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectoAvance1.Migrations.ProjectDb
{
    public partial class LlaveUsuarioTablaVenta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IdUsuario",
                table: "Ventas",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Key_IdUsuario",
                table: "Ventas",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUser", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_Key_IdUsuario",
                table: "Ventas",
                column: "Key_IdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_ApplicationUser_Key_IdUsuario",
                table: "Ventas",
                column: "Key_IdUsuario",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_ApplicationUser_Key_IdUsuario",
                table: "Ventas");

            migrationBuilder.DropTable(
                name: "ApplicationUser");

            migrationBuilder.DropIndex(
                name: "IX_Ventas_Key_IdUsuario",
                table: "Ventas");

            migrationBuilder.DropColumn(
                name: "Key_IdUsuario",
                table: "Ventas");

            migrationBuilder.AlterColumn<int>(
                name: "IdUsuario",
                table: "Ventas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
