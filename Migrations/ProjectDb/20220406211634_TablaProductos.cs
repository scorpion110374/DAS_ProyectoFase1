using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectoAvance1.Migrations.ProjectDb
{
    public partial class TablaProductos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Precio = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    Disponible = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "Codigo", "Descripcion", "Disponible", "Foto", "IdCategoria", "Precio" },
                values: new object[,]
                {
                    { 1, "GuestBook-1", "Libro de Invitados", true, "/img/productos/1/1.jpg", 1, 10m },
                    { 2, "Coaster-1", "Portavasos personalizados", true, "/img/productos/1/2.jpg", 1, 10m },
                    { 3, "Keychain-1", "Lalveros personalizados", true, "/img/productos/1/3.jpg", 1, 5m },
                    { 4, "Nameboard-1", "Nombres personalizados", true, "/img/productos/1/4.jpg", 1, 10m },
                    { 5, "Led-1", "Lampara Led", true, "/img/productos/2/5.jpg", 2, 25m },
                    { 6, "Led-2", "Lampara Led Luna", true, "/img/productos/2/6.jpg", 2, 25m },
                    { 7, "Led-3", "Lampara Led Darth Vader", true, "/img/productos/2/7.jpg", 2, 25m },
                    { 8, "CNC-1", "Letras", true, "/img/productos/3/8.jpg", 3, 10m },
                    { 9, "CNC-2", "Trineo de Santa", true, "/img/productos/3/9.jpg", 3, 50m },
                    { 10, "CNC-3", "Tabla para picar", true, "/img/productos/3/10.jpg", 3, 10m },
                    { 11, "CNC-4", "Tablas personalizadas", true, "/img/productos/3/11.jpg", 3, 25m },
                    { 12, "PZ-1", "Rompecabeza Caballo", true, "/img/productos/4/12.jpg", 4, 10m },
                    { 13, "PZ-2", "Rompecabeza colores", true, "/img/productos/4/13.jpg", 4, 50m },
                    { 14, "PZ-3", "Rompecabeza Abeja", true, "/img/productos/4/14.jpg", 4, 10m },
                    { 15, "PZ-4", "Rompecabeza Nave Espacial", true, "/img/productos/4/15.jpg", 4, 25m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");
        }
    }
}
