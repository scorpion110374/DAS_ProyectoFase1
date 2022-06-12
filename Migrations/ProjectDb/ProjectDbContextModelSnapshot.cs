﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectoAvance1.Data;

namespace ProjectoAvance1.Migrations.ProjectDb
{
    [DbContext(typeof(ProjectDbContext))]
    partial class ProjectDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjectoAvance1.Areas.Identity.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserRole")
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUser");
                });

            modelBuilder.Entity("ProjectoAvance1.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreCategoria")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NombreCategoria = "Corte y Grabado Laser"
                        },
                        new
                        {
                            Id = 2,
                            NombreCategoria = "Lamparas Led"
                        },
                        new
                        {
                            Id = 3,
                            NombreCategoria = "Corte y Grabado CNC"
                        },
                        new
                        {
                            Id = 4,
                            NombreCategoria = "Rompecabezas"
                        });
                });

            modelBuilder.Entity("ProjectoAvance1.Models.Contacto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Asunto")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mensaje")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Contactos");
                });

            modelBuilder.Entity("ProjectoAvance1.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Descuento")
                        .HasColumnType("int");

                    b.Property<bool>("Disponible")
                        .HasColumnType("bit");

                    b.Property<string>("Foto")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("IdCategoria")
                        .HasColumnType("int");

                    b.Property<int>("Nuevo")
                        .HasColumnType("int");

                    b.Property<int>("Oferta")
                        .HasColumnType("int");

                    b.Property<decimal>("Peso")
                        .HasColumnType("decimal(4,2)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("PrecioOferta")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Codigo = "GuestBook-1",
                            Descripcion = "Libro de Invitados",
                            Descuento = 0,
                            Disponible = true,
                            Foto = "img/productos/1/1.jpg",
                            IdCategoria = 1,
                            Nuevo = 0,
                            Oferta = 0,
                            Peso = 0m,
                            Precio = 10m,
                            PrecioOferta = 0m
                        },
                        new
                        {
                            Id = 2,
                            Codigo = "Coaster-1",
                            Descripcion = "Portavasos personalizados",
                            Descuento = 0,
                            Disponible = true,
                            Foto = "img/productos/1/2.jpg",
                            IdCategoria = 1,
                            Nuevo = 1,
                            Oferta = 0,
                            Peso = 0m,
                            Precio = 10m,
                            PrecioOferta = 0m
                        },
                        new
                        {
                            Id = 3,
                            Codigo = "Keychain-1",
                            Descripcion = "Llaveros personalizados",
                            Descuento = 0,
                            Disponible = true,
                            Foto = "img/productos/1/3.jpg",
                            IdCategoria = 1,
                            Nuevo = 1,
                            Oferta = 0,
                            Peso = 0m,
                            Precio = 5m,
                            PrecioOferta = 0m
                        },
                        new
                        {
                            Id = 4,
                            Codigo = "Nameboard-1",
                            Descripcion = "Nombres personalizados",
                            Descuento = 0,
                            Disponible = true,
                            Foto = "img/productos/1/4.jpg",
                            IdCategoria = 1,
                            Nuevo = 1,
                            Oferta = 0,
                            Peso = 0m,
                            Precio = 10m,
                            PrecioOferta = 0m
                        },
                        new
                        {
                            Id = 5,
                            Codigo = "Led-1",
                            Descripcion = "Lampara Led",
                            Descuento = 0,
                            Disponible = true,
                            Foto = "img/productos/2/5.jpg",
                            IdCategoria = 2,
                            Nuevo = 1,
                            Oferta = 0,
                            Peso = 0m,
                            Precio = 25m,
                            PrecioOferta = 0m
                        },
                        new
                        {
                            Id = 6,
                            Codigo = "Led-2",
                            Descripcion = "Lampara Led Luna",
                            Descuento = 0,
                            Disponible = true,
                            Foto = "img/productos/2/6.jpg",
                            IdCategoria = 2,
                            Nuevo = 1,
                            Oferta = 0,
                            Peso = 0m,
                            Precio = 25m,
                            PrecioOferta = 0m
                        },
                        new
                        {
                            Id = 7,
                            Codigo = "Led-3",
                            Descripcion = "Lampara Led Darth Vader",
                            Descuento = 0,
                            Disponible = true,
                            Foto = "img/productos/2/7.jpg",
                            IdCategoria = 2,
                            Nuevo = 1,
                            Oferta = 0,
                            Peso = 0m,
                            Precio = 25m,
                            PrecioOferta = 0m
                        },
                        new
                        {
                            Id = 8,
                            Codigo = "CNC-1",
                            Descripcion = "Letras",
                            Descuento = 0,
                            Disponible = true,
                            Foto = "img/productos/3/8.jpg",
                            IdCategoria = 3,
                            Nuevo = 1,
                            Oferta = 0,
                            Peso = 0m,
                            Precio = 10m,
                            PrecioOferta = 0m
                        },
                        new
                        {
                            Id = 9,
                            Codigo = "CNC-2",
                            Descripcion = "Trineo de Santa",
                            Descuento = 0,
                            Disponible = true,
                            Foto = "img/productos/3/9.jpg",
                            IdCategoria = 3,
                            Nuevo = 1,
                            Oferta = 0,
                            Peso = 0m,
                            Precio = 50m,
                            PrecioOferta = 0m
                        },
                        new
                        {
                            Id = 10,
                            Codigo = "CNC-3",
                            Descripcion = "Tabla para picar",
                            Descuento = 0,
                            Disponible = true,
                            Foto = "img/productos/3/10.jpg",
                            IdCategoria = 3,
                            Nuevo = 1,
                            Oferta = 0,
                            Peso = 0m,
                            Precio = 10m,
                            PrecioOferta = 0m
                        },
                        new
                        {
                            Id = 11,
                            Codigo = "CNC-4",
                            Descripcion = "Tablas personalizadas",
                            Descuento = 0,
                            Disponible = true,
                            Foto = "img/productos/3/11.jpg",
                            IdCategoria = 3,
                            Nuevo = 1,
                            Oferta = 0,
                            Peso = 0m,
                            Precio = 25m,
                            PrecioOferta = 0m
                        },
                        new
                        {
                            Id = 12,
                            Codigo = "PZ-1",
                            Descripcion = "Rompecabeza Caballo",
                            Descuento = 0,
                            Disponible = true,
                            Foto = "img/productos/4/12.jpg",
                            IdCategoria = 4,
                            Nuevo = 1,
                            Oferta = 0,
                            Peso = 0m,
                            Precio = 10m,
                            PrecioOferta = 0m
                        },
                        new
                        {
                            Id = 13,
                            Codigo = "PZ-2",
                            Descripcion = "Rompecabeza colores",
                            Descuento = 0,
                            Disponible = true,
                            Foto = "img/productos/4/13.jpg",
                            IdCategoria = 4,
                            Nuevo = 1,
                            Oferta = 0,
                            Peso = 0m,
                            Precio = 50m,
                            PrecioOferta = 0m
                        },
                        new
                        {
                            Id = 14,
                            Codigo = "PZ-3",
                            Descripcion = "Rompecabeza Abeja",
                            Descuento = 0,
                            Disponible = true,
                            Foto = "img/productos/4/14.jpg",
                            IdCategoria = 4,
                            Nuevo = 1,
                            Oferta = 0,
                            Peso = 0m,
                            Precio = 10m,
                            PrecioOferta = 0m
                        },
                        new
                        {
                            Id = 15,
                            Codigo = "PZ-4",
                            Descripcion = "Rompecabeza Nave Espacial",
                            Descuento = 0,
                            Disponible = true,
                            Foto = "img/productos/4/15.jpg",
                            IdCategoria = 4,
                            Nuevo = 1,
                            Oferta = 0,
                            Peso = 0m,
                            Precio = 25m,
                            PrecioOferta = 0m
                        });
                });

            modelBuilder.Entity("ProjectoAvance1.Models.Venta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Cc_cvv")
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("Cc_expiration")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Cc_name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Cc_number")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CodigoPostal")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Departamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Direccion2")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Key_IdUsuario")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Norden")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("TipoPago")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("Key_IdUsuario");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("ProjectoAvance1.Models.VentaDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<int>("IdVenta")
                        .HasColumnType("int");

                    b.Property<int?>("Key_IdProducto")
                        .HasColumnType("int");

                    b.Property<int?>("Key_IdVenta")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("Key_IdProducto");

                    b.HasIndex("Key_IdVenta");

                    b.ToTable("VentaDetalles");
                });

            modelBuilder.Entity("ProjectoAvance1.Models.Venta", b =>
                {
                    b.HasOne("ProjectoAvance1.Areas.Identity.Data.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("Key_IdUsuario");

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("ProjectoAvance1.Models.VentaDetalle", b =>
                {
                    b.HasOne("ProjectoAvance1.Models.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("Key_IdProducto");

                    b.HasOne("ProjectoAvance1.Models.Venta", "Venta")
                        .WithMany()
                        .HasForeignKey("Key_IdVenta");

                    b.Navigation("Producto");

                    b.Navigation("Venta");
                });
#pragma warning restore 612, 618
        }
    }
}
