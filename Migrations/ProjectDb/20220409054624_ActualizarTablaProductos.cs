using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectoAvance1.Migrations.ProjectDb
{
    public partial class ActualizarTablaProductos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Precio",
                table: "Productos",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,4)");

            migrationBuilder.AddColumn<int>(
                name: "Descuento",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Nuevo",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Oferta",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Peso",
                table: "Productos",
                type: "decimal(4,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PrecioOferta",
                table: "Productos",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Foto",
                value: "/img/productos/1/1.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Foto", "Nuevo" },
                values: new object[] { "/img/productos/1/2.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Foto", "Nuevo" },
                values: new object[] { "/img/productos/1/3.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Foto", "Nuevo" },
                values: new object[] { "/img/productos/1/4.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Foto", "Nuevo" },
                values: new object[] { "/img/productos/2/5.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Foto", "Nuevo" },
                values: new object[] { "/img/productos/2/6.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Foto", "Nuevo" },
                values: new object[] { "/img/productos/2/7.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Foto", "Nuevo" },
                values: new object[] { "/img/productos/3/8.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Foto", "Nuevo" },
                values: new object[] { "/img/productos/3/9.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Foto", "Nuevo" },
                values: new object[] { "/img/productos/3/10.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Foto", "Nuevo" },
                values: new object[] { "/img/productos/3/11.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Foto", "Nuevo" },
                values: new object[] { "/img/productos/4/12.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Foto", "Nuevo" },
                values: new object[] { "/img/productos/4/13.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Foto", "Nuevo" },
                values: new object[] { "/img/productos/4/14.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Foto", "Nuevo" },
                values: new object[] { "/img/productos/4/15.jpg", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descuento",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Nuevo",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Oferta",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Peso",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "PrecioOferta",
                table: "Productos");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio",
                table: "Productos",
                type: "decimal(10,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Foto",
                value: "~/img/productos/1/1.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Foto",
                value: "~/img/productos/1/2.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Foto",
                value: "~/img/productos/1/3.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Foto",
                value: "~/img/productos/1/4.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Foto",
                value: "~/img/productos/2/5.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 6,
                column: "Foto",
                value: "~/img/productos/1/2.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 7,
                column: "Foto",
                value: "~/img/productos/1/3.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 8,
                column: "Foto",
                value: "~/img/productos/3/8.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 9,
                column: "Foto",
                value: "~/img/productos/3/9.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 10,
                column: "Foto",
                value: "~/img/productos/3/10.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 11,
                column: "Foto",
                value: "~/img/productos/3/11.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 12,
                column: "Foto",
                value: "~/img/productos/4/12.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 13,
                column: "Foto",
                value: "~/img/productos/4/13.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 14,
                column: "Foto",
                value: "~/img/productos/4/14.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 15,
                column: "Foto",
                value: "~/img/productos/4/15.jpg");
        }
    }
}
