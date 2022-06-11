using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProjectoAvance1.Models;
using System.IO;

namespace ProjectoAvance1.Data
{
    public class ProjectDbContext: DbContext
    {
        public ProjectDbContext(DbContextOptions options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        //entities
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<VentaDetalle> VentaDetalles { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Llenar datos iniciales a tabla Categorias
            modelBuilder.Entity<Categoria>()
                .HasData(
                new Categoria()
                {
                    Id = 1,
                    NombreCategoria = "Corte y Grabado Laser"
                },
                new Categoria()
                {
                    Id = 2,
                    NombreCategoria = "Lamparas Led"
                },
                new Categoria()
                {
                    Id = 3,
                    NombreCategoria = "Corte y Grabado CNC"
                },
                new Categoria()
                {
                    Id = 4,
                    NombreCategoria = "Rompecabezas"
                }
                );
            //Llenar datos iniciales a tabla Productos
            modelBuilder.Entity<Producto>()
                .HasData(
                new Producto()
                {
                    Id = 1,
                    Codigo = "GuestBook-1",
                    Descripcion = "Libro de Invitados",
                    Foto = "/img/productos/1/1.jpg",
                    IdCategoria = 1,
                    Precio = 10,
                    Disponible = true
                },
                new Producto()
                {
                    Id = 2,
                    Codigo = "Coaster-1",
                    Descripcion = "Portavasos personalizados",
                    Foto = "/img/productos/1/2.jpg",
                    IdCategoria = 1,
                    Precio = 10,
                    PrecioOferta = 0,
                    Disponible = true,
                    Nuevo = 1,
                    Oferta = 0,
                    Descuento = 0,
                    Peso =0
                },
                new Producto()
                {
                    Id = 3,
                    Codigo = "Keychain-1",
                    Descripcion = "Llaveros personalizados",
                    Foto = "/img/productos/1/3.jpg",
                    IdCategoria = 1,
                    Precio = 5,
                    PrecioOferta = 0,
                    Disponible = true,
                    Nuevo = 1,
                    Oferta = 0,
                    Descuento = 0,
                    Peso = 0
                },
                new Producto()
                {
                    Id = 4,
                    Codigo = "Nameboard-1",
                    Descripcion = "Nombres personalizados",
                    Foto = "/img/productos/1/4.jpg",
                    IdCategoria = 1,
                    Precio = 10,
                    PrecioOferta = 0,
                    Disponible = true,
                    Nuevo = 1,
                    Oferta = 0,
                    Descuento = 0,
                    Peso = 0
                },
                new Producto()
                {
                    Id = 5,
                    Codigo = "Led-1",
                    Descripcion = "Lampara Led",
                    Foto = "/img/productos/2/5.jpg",
                    IdCategoria = 2,
                    Precio = 25,
                    PrecioOferta = 0,
                    Disponible = true,
                    Nuevo = 1,
                    Oferta = 0,
                    Descuento = 0,
                    Peso = 0
                },
                new Producto()
                {
                    Id = 6,
                    Codigo = "Led-2",
                    Descripcion = "Lampara Led Luna",
                    Foto = "/img/productos/2/6.jpg",
                    IdCategoria = 2,
                    Precio = 25,
                    PrecioOferta = 0,
                    Disponible = true,
                    Nuevo = 1,
                    Oferta = 0,
                    Descuento = 0,
                    Peso = 0
                },
                new Producto()
                {
                    Id = 7,
                    Codigo = "Led-3",
                    Descripcion = "Lampara Led Darth Vader",
                    Foto = "/img/productos/2/7.jpg",
                    IdCategoria = 2,
                    Precio = 25,
                    PrecioOferta = 0,
                    Disponible = true,
                    Nuevo = 1,
                    Oferta = 0,
                    Descuento = 0,
                    Peso = 0
                },
                new Producto()
                {
                    Id = 8,
                    Codigo = "CNC-1",
                    Descripcion = "Letras",
                    Foto = "/img/productos/3/8.jpg",
                    IdCategoria = 3,
                    Precio = 10,
                    PrecioOferta = 0,
                    Disponible = true,
                    Nuevo = 1,
                    Oferta = 0,
                    Descuento = 0,
                    Peso = 0
                },
                new Producto()
                {
                    Id = 9,
                    Codigo = "CNC-2",
                    Descripcion = "Trineo de Santa",
                    Foto = "/img/productos/3/9.jpg",
                    IdCategoria = 3,
                    Precio = 50,
                    PrecioOferta = 0,
                    Disponible = true,
                    Nuevo = 1,
                    Oferta = 0,
                    Descuento = 0,
                    Peso = 0
                },
                new Producto()
                {
                    Id = 10,
                    Codigo = "CNC-3",
                    Descripcion = "Tabla para picar",
                    Foto = "/img/productos/3/10.jpg",
                    IdCategoria = 3,
                    Precio = 10,
                    PrecioOferta = 0,
                    Disponible = true,
                    Nuevo = 1,
                    Oferta = 0,
                    Descuento = 0,
                    Peso = 0
                },
                new Producto()
                {
                    Id = 11,
                    Codigo = "CNC-4",
                    Descripcion = "Tablas personalizadas",
                    Foto = "/img/productos/3/11.jpg",
                    IdCategoria = 3,
                    Precio = 25,
                    PrecioOferta = 0,
                    Disponible = true,
                    Nuevo = 1,
                    Oferta = 0,
                    Descuento = 0,
                    Peso = 0
                },
                new Producto()
                {
                    Id = 12,
                    Codigo = "PZ-1",
                    Descripcion = "Rompecabeza Caballo",
                    Foto = "/img/productos/4/12.jpg",
                    IdCategoria = 4,
                    Precio = 10,
                    PrecioOferta = 0,
                    Disponible = true,
                    Nuevo = 1,
                    Oferta = 0,
                    Descuento = 0,
                    Peso = 0
                },
                new Producto()
                {
                    Id = 13,
                    Codigo = "PZ-2",
                    Descripcion = "Rompecabeza colores",
                    Foto = "/img/productos/4/13.jpg",
                    IdCategoria = 4,
                    Precio = 50,
                    PrecioOferta = 0,
                    Disponible = true,
                    Nuevo = 1,
                    Oferta = 0,
                    Descuento = 0,
                    Peso = 0
                },
                new Producto()
                {
                    Id = 14,
                    Codigo = "PZ-3",
                    Descripcion = "Rompecabeza Abeja",
                    Foto = "/img/productos/4/14.jpg",
                    IdCategoria = 4,
                    Precio = 10,
                    PrecioOferta = 0,
                    Disponible = true,
                    Nuevo = 1,
                    Oferta = 0,
                    Descuento = 0,
                    Peso = 0
                },
                new Producto()
                {
                    Id = 15,
                    Codigo = "PZ-4",
                    Descripcion = "Rompecabeza Nave Espacial",
                    Foto = "/img/productos/4/15.jpg",
                    IdCategoria = 4,
                    Precio = 25,
                    PrecioOferta = 0,
                    Disponible = true,
                    Nuevo = 1,
                    Oferta = 0,
                    Descuento = 0,
                    Peso = 0
                }
                );
        }
    }
}
