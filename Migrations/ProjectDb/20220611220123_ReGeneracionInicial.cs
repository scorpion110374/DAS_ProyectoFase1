using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectoAvance1.Migrations.ProjectDb
{
    public partial class ReGeneracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    UserRole = table.Column<string>(type: "nvarchar(15)", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCategoria = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contactos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Asunto = table.Column<string>(type: "varchar(100)", nullable: false),
                    Mensaje = table.Column<string>(type: "text", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contactos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Foto = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IdCategoria = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    PrecioOferta = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Disponible = table.Column<bool>(type: "bit", nullable: false),
                    Nuevo = table.Column<int>(type: "int", nullable: false),
                    Oferta = table.Column<int>(type: "int", nullable: false),
                    Descuento = table.Column<int>(type: "int", nullable: false),
                    Peso = table.Column<decimal>(type: "decimal(4,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Norden = table.Column<string>(type: "nvarchar(25)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuario = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Direccion2 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    Departamento = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    CodigoPostal = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    TipoPago = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Cc_name = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Cc_number = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Cc_expiration = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Cc_cvv = table.Column<string>(type: "nvarchar(5)", nullable: true),
                    Valor = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Key_IdUsuario = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ventas_ApplicationUser_Key_IdUsuario",
                        column: x => x.Key_IdUsuario,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "NombreCategoria" },
                values: new object[,]
                {
                    { 1, "Corte y Grabado Laser" },
                    { 2, "Lamparas Led" },
                    { 3, "Corte y Grabado CNC" },
                    { 4, "Rompecabezas" }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "Codigo", "Descripcion", "Descuento", "Disponible", "Foto", "IdCategoria", "Nuevo", "Oferta", "Peso", "Precio", "PrecioOferta" },
                values: new object[,]
                {
                    { 13, "PZ-2", "Rompecabeza colores", 0, true, "img/productos/4/13.jpg", 4, 1, 0, 0m, 50m, 0m },
                    { 12, "PZ-1", "Rompecabeza Caballo", 0, true, "img/productos/4/12.jpg", 4, 1, 0, 0m, 10m, 0m },
                    { 11, "CNC-4", "Tablas personalizadas", 0, true, "img/productos/3/11.jpg", 3, 1, 0, 0m, 25m, 0m },
                    { 10, "CNC-3", "Tabla para picar", 0, true, "img/productos/3/10.jpg", 3, 1, 0, 0m, 10m, 0m },
                    { 9, "CNC-2", "Trineo de Santa", 0, true, "img/productos/3/9.jpg", 3, 1, 0, 0m, 50m, 0m },
                    { 8, "CNC-1", "Letras", 0, true, "img/productos/3/8.jpg", 3, 1, 0, 0m, 10m, 0m },
                    { 6, "Led-2", "Lampara Led Luna", 0, true, "img/productos/2/6.jpg", 2, 1, 0, 0m, 25m, 0m },
                    { 14, "PZ-3", "Rompecabeza Abeja", 0, true, "img/productos/4/14.jpg", 4, 1, 0, 0m, 10m, 0m },
                    { 5, "Led-1", "Lampara Led", 0, true, "img/productos/2/5.jpg", 2, 1, 0, 0m, 25m, 0m },
                    { 4, "Nameboard-1", "Nombres personalizados", 0, true, "img/productos/1/4.jpg", 1, 1, 0, 0m, 10m, 0m },
                    { 3, "Keychain-1", "Llaveros personalizados", 0, true, "img/productos/1/3.jpg", 1, 1, 0, 0m, 5m, 0m },
                    { 2, "Coaster-1", "Portavasos personalizados", 0, true, "img/productos/1/2.jpg", 1, 1, 0, 0m, 10m, 0m },
                    { 1, "GuestBook-1", "Libro de Invitados", 0, true, "img/productos/1/1.jpg", 1, 0, 0, 0m, 10m, 0m },
                    { 7, "Led-3", "Lampara Led Darth Vader", 0, true, "img/productos/2/7.jpg", 2, 1, 0, 0m, 25m, 0m },
                    { 15, "PZ-4", "Rompecabeza Nave Espacial", 0, true, "img/productos/4/15.jpg", 4, 1, 0, 0m, 25m, 0m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_VentaDetalles_Key_IdProducto",
                table: "VentaDetalles",
                column: "Key_IdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_VentaDetalles_Key_IdVenta",
                table: "VentaDetalles",
                column: "Key_IdVenta");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_Key_IdUsuario",
                table: "Ventas",
                column: "Key_IdUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Contactos");

            migrationBuilder.DropTable(
                name: "VentaDetalles");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "ApplicationUser");
        }
    }
}
