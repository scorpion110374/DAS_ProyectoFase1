using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectoAvance1.Migrations.ProjectDb
{
    public partial class AgregarTablasVentaYVentaDetalle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Norden = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Departamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoPostal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoPago = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cc_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cc_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cc_expiration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cc_cvv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valor = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VentaDetalles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdVenta = table.Column<int>(type: "int", nullable: false),
                    IdProducto = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    PrecioUnitario = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Key_IdVenta = table.Column<int>(type: "int", nullable: true),
                    Key_IdProducto = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VentaDetalles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VentaDetalles_Productos_Key_IdProducto",
                        column: x => x.Key_IdProducto,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VentaDetalles_Ventas_Key_IdVenta",
                        column: x => x.Key_IdVenta,
                        principalTable: "Ventas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Descripcion",
                value: "Llaveros personalizados");

            migrationBuilder.CreateIndex(
                name: "IX_VentaDetalles_Key_IdProducto",
                table: "VentaDetalles",
                column: "Key_IdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_VentaDetalles_Key_IdVenta",
                table: "VentaDetalles",
                column: "Key_IdVenta");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VentaDetalles");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Descripcion",
                value: "Lalveros personalizados");
        }
    }
}
